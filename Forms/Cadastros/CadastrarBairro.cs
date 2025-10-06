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
            comboModelo.Items.Add("Exatamente");
            comboModelo.SelectedIndex = 0;

            this.CaregarGridBairros();
            this.CarregarCidadesCombo();

        }

        private void groupBox2_Resize(object sender, EventArgs e)
        {
            btnPesquisar.Location = new Point(this.groupBox2.Width - btnPesquisar.Width - 9, btnPesquisar.Location.Y);
            checkBoxTodos.Location = new Point(this.groupBox2.Width - checkBoxTodos.Width - 9, checkBoxTodos.Location.Y);


        }





        private void LiberararCamposParaNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {

                textBairro.ReadOnly = false;
                textBairro.Focus();
                comboCidades.Enabled = true;
                textCodigo.Text = "";
                textBairro.Text = "";

            }

        }



        private void LiberararCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {
            textBairro.ReadOnly = false;
            textBairro.Focus();
            comboCidades.Enabled = true;
            textCodigo.Text = "";
            textBairro.Text = "";

        }

        private void SairFormCadastroBairro(object sender, EventArgs e)
        {

            this.Close();
        }

        private void CaregarGridBairros()
        {

            try
            {
                var bairros = dbConectionPdv.Bairro.
                    Select(b => new
                    {
                        Codigo = b.Id,
                        Nome = b.Nome,
                        Cidade = b.Cidade.Nome,

                    }).ToList();
                dataGridBairro.DataSource = bairros;
                dataGridBairro.Columns["Nome"].HeaderText = "Nome do Bairro";
                dataGridBairro.Columns["Nome"].Width = 200;
                dataGridBairro.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os bairros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CarregarCidadesCombo()
        {
            var cidades = dbConectionPdv.Cidades.OrderBy(c => c.Nome).ToList();
            comboCidades.DataSource = cidades;
            comboCidades.DisplayMember = "Nome";
            comboCidades.ValueMember = "Id";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBairro.Text))
                {
                    MessageBox.Show("O nome do bairro não pode estar vazio.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrEmpty(textCodigo.Text))
                {
                    // Atualização
                    int bairroId = int.Parse(textCodigo.Text);
                    var bairroExistente = dbConectionPdv.Bairro.Find(bairroId);

                    if (bairroExistente != null)
                    {
                        bairroExistente.Nome = textBairro.Text.Trim();
                        bairroExistente.CidadeId = (int)comboCidades.SelectedValue;

                        dbConectionPdv.Bairro.Update(bairroExistente); // opcional, mas deixa explícito
                        dbConectionPdv.SaveChanges();

                        MessageBox.Show("Bairro atualizado com sucesso!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bairro não encontrado para atualização.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Novo registro

                    var bairroExistente = dbConectionPdv.Bairro
                        .FirstOrDefault(b => b.Nome.ToLower() == textBairro.Text.Trim().ToLower()
                                             && b.CidadeId == (int)comboCidades.SelectedValue);

                    if (bairroExistente != null)
                    {
                        MessageBox.Show("Já existe um bairro com esse nome na cidade selecionada.", "Atenção",
 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
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
                }

                this.CaregarGridBairros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o bairro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            tabControl1.SelectedTab = tabPage1;

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
                        this.CaregarGridBairros();
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
            if ( !string.IsNullOrWhiteSpace(filtro))
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
                        case "Exatamente":
                            bairros = bairros.Where(b => b.Nome.ToLower() == filtro);
                            break;
                    }
                }
                else if (comboFiltros.SelectedItem.ToString() == "Por Codigo ")
                {
                    if (int.TryParse(filtro, out int codigo))
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
    }
}
