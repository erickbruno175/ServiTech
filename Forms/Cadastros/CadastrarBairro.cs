using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarBairro : Form
    {

        private readonly DbConection.DbConectionPdv dbConectionPdv;
        public CadastrarBairro(DbConection.DbConectionPdv dbConectionPdv)
        {
            InitializeComponent();
            this.dbConectionPdv = dbConectionPdv;
        }



        private void CadastrarPais_Load(object sender, EventArgs e)
        {
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Items.Add("Por Nome ");
            comboFiltros.Items.Add("Por Codigo ");
            comboFiltros.SelectedIndex = 0;

            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.SelectedIndex = 0;

            this.CarregarGridBairros();
            this.CarregarCidadesCombo();

        }





        private void LiberararCamposParaNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {

                textBairro.ReadOnly = false;
                textBairro.Focus();
                comboCidades.Enabled = true;
                textCodigo.Clear();
                textBairro.Clear();

            }
            else if (e.KeyCode == Keys.F5)
            {
                this.GravarBairro();
            }

        }



        private void LiberararCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {
            textBairro.ReadOnly = false;
            textBairro.Focus();
            comboCidades.Enabled = true;
            textCodigo.Clear();
            textBairro.Clear();

        }


        private void CarregarGridBairros()
        {
            try
            {
                var bairros = dbConectionPdv.Bairro
                    .Select(b => new
                    {
                        Codigo = b.Id,
                        Nome = b.Nome,
                        Cidade = b.Cidade.Nome,
                    })
                    .OrderBy(b => b.Nome)
                    .ToList();

                dataGridBairro.DataSource = bairros;

                // ==== ESTILO DO CABEÇALHO ====
                dataGridBairro.EnableHeadersVisualStyles = false;
                dataGridBairro.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
                dataGridBairro.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridBairro.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dataGridBairro.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridBairro.ColumnHeadersHeight = 32;

                // ==== ESTILO DAS LINHAS ====
                dataGridBairro.DefaultCellStyle.BackColor = Color.White;
                dataGridBairro.DefaultCellStyle.ForeColor = Color.Black;
                dataGridBairro.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                dataGridBairro.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
                dataGridBairro.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridBairro.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                dataGridBairro.RowHeadersVisible = false;

                // ==== CONFIGURAÇÃO DAS COLUNAS ====
                dataGridBairro.Columns["Codigo"].HeaderText = "Código";
                dataGridBairro.Columns["Codigo"].Width = 80;
                dataGridBairro.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridBairro.Columns["Nome"].HeaderText = "Nome do Bairro";
                dataGridBairro.Columns["Nome"].Width = 250;

                dataGridBairro.Columns["Cidade"].HeaderText = "Cidade";
                dataGridBairro.Columns["Cidade"].Width = 200;

                // ==== COMPORTAMENTO ====
                dataGridBairro.ReadOnly = true;
                dataGridBairro.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona linha inteira
                dataGridBairro.MultiSelect = false; // Só uma linha por vez
                dataGridBairro.BorderStyle = BorderStyle.FixedSingle;
                dataGridBairro.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridBairro.GridColor = Color.FromArgb(220, 220, 220);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os bairros: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CarregarCidadesCombo()
        {
            var cidades = dbConectionPdv.Cidades.OrderBy(c => c.Nome).ToList();
            comboCidades.DataSource = cidades;
            comboCidades.DisplayMember = "Nome";
            comboCidades.ValueMember = "Id";
        }

        private void GravarBairro()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBairro.Text))
                {
                    MessageBox.Show("O nome do bairro não pode estar vazio.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textCodigo.Text))
                    {
                        // 🔹 Novo bairro
                        bool existeBairro = dbConectionPdv.Bairro
                            .Any(b => b.Nome.ToLower() == textBairro.Text.Trim().ToLower()
                                   && b.CidadeId == (int)comboCidades.SelectedValue);

                        if (existeBairro)
                        {
                            MessageBox.Show("Já existe um bairro com esse nome na cidade selecionada.", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            var novoBairro = new Model.ModelLocalidade.Bairro
                            {
                                Nome = textBairro.Text.Trim(),
                                CidadeId = (int)comboCidades.SelectedValue
                            };

                            dbConectionPdv.Bairro.Add(novoBairro);
                            dbConectionPdv.SaveChanges();

                            textCodigo.Text = novoBairro.Id.ToString();

                            MessageBox.Show("Bairro cadastrado com sucesso!", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CarregarGridBairros();
                            return;
                        }
                    }
                    else
                    {
                        // 🔹 Atualizar bairro existente
                        int bairroId = int.Parse(textCodigo.Text);
                        var bairroParaEditar = dbConectionPdv.Bairro.Find(bairroId);

                        if (bairroParaEditar != null)
                        {
                            bairroParaEditar.Nome = textBairro.Text.Trim();
                            bairroParaEditar.CidadeId = (int)comboCidades.SelectedValue;

                            dbConectionPdv.SaveChanges();

                            MessageBox.Show("Bairro atualizado com sucesso!", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CarregarGridBairros();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Bairro não encontrado para atualização.", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o bairro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.GravarBairro();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridBairro.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridBairro.SelectedRows[0];
                int bairroId = (int)selectedRow.Cells["Codigo"].Value;
                var bairroParaEditar = dbConectionPdv.Bairro.Find(bairroId);

                this.AbrirAbaCadastro(bairroParaEditar.Id, bairroParaEditar.Nome, bairroParaEditar.CidadeId);
            }
            else
            {
                MessageBox.Show("Selecione um bairro para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AbrirAbaCadastro(int id, string nome, int cidadeId)
        {
            // Seleciona a aba de cadastro
            tabControl1.SelectedTab = tabCadastro;

            // Preenche os campos do cadastro
            textCodigo.Text = id.ToString();
            textBairro.Text = nome;
            textBairro.ReadOnly = false;
            comboCidades.Enabled = true;
            comboCidades.SelectedValue = cidadeId; // ComboBox populado com Id e Nome das cidades
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dataGridBairro.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridBairro.SelectedRows[0];
                int bairroId = (int)selectedRow.Cells["Codigo"].Value;
                var bairroParaExcluir = dbConectionPdv.Bairro.Find(bairroId);
                var confirmResult = MessageBox.Show($"Tem certeza que deseja excluir o bairro '{bairroParaExcluir.Nome}'?",
                                     "Confirmação de Exclusão",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        dbConectionPdv.Bairro.Remove(bairroParaExcluir);
                        dbConectionPdv.SaveChanges();
                        MessageBox.Show("Bairro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarGridBairros();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o bairro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um bairro para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textDadosPesquisa_TextChanged(object sender, EventArgs e)
        {

            string filtro = textDadosPesquisa.Text.Trim().ToLower();
            var bairros = dbConectionPdv.Bairro.AsQueryable();


            if (string.IsNullOrEmpty(filtro))
            {
                this.CarregarGridBairros();
                return;
            }
            if (!string.IsNullOrWhiteSpace(filtro))
            {
                if (comboFiltros.SelectedItem.ToString() == "Por Nome ")
                {
                    switch (comboModelo.SelectedItem.ToString())
                    {
                        case "Inicia Com":
                            bairros = bairros.Where(b => b.Nome.ToLower().StartsWith(filtro));
                            break;
                        case "Termina Com":
                            bairros = bairros.Where(b => b.Nome.ToLower().EndsWith(filtro));
                            break;
                        case "Contem":
                            bairros = bairros.Where(b => b.Nome.ToLower().Contains(filtro));
                            break;

                    }
                }
                else if (comboFiltros.SelectedItem.ToString() == "Por Codigo ")
                {
                    if (int.TryParse(textDadosPesquisa.Text, out int codigo))
                    {
                        bairros = bairros.Where(b => b.Id == codigo);
                    }
                    else
                    {
                        bairros = Enumerable.Empty<Model.ModelLocalidade.Bairro>().AsQueryable();
                    }
                }
            }
            var resultado = bairros.Select(b => new
            {
                Codigo = b.Id,
                Nome = b.Nome,
                Cidade = b.Cidade.Nome,
            }).ToList();
            dataGridBairro.DataSource = resultado;
        }

        private void CadastrarBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEditar_Click(this, new EventArgs());
            }
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabCadastro;
            textBairro.ReadOnly = false;
            textBairro.Focus();
            comboCidades.Enabled = true;
            textCodigo.Clear();
            textBairro.Clear();
        }
    }
}
