using ServiTech.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarMarca : Form
    {
        private readonly DbConection.DbConectionPdv dbConectionPdv = new DbConection.DbConectionPdv();
        public CadastrarMarca()
        {
            InitializeComponent();
        }




        private void LiberarCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {

            textCodigo.ReadOnly = true;
            textNome.ReadOnly = false;
            textNome.Focus();
            textCodigo.Clear();
            textNome.Clear();

        }

        private void LiberarCamposParaNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {
                textCodigo.ReadOnly = true;
                textNome.ReadOnly = false;
                textNome.Focus();

                textCodigo.Clear();
                textNome.Clear();
            }else if (e.KeyCode == Keys.F5)
            {
                this.GravarMarca();
            }
        }

        private void CadastrarMarca_Load(object sender, EventArgs e)
        {
            CarregarMarca();
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Items.Add("Por Nome ");
            comboFiltros.Items.Add("Por Codigo ");
            comboFiltros.SelectedIndex = 0;

            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.SelectedIndex = 0;
        }

        private void CarregarMarca()
        {
            try
            {
                // Obtém todos os países do banco
                var marcas = dbConectionPdv.Marcas
                    .OrderBy(p => p.Id)

                    .ToList();

                dataGridMarca.DataSource = marcas;

                // ==== ESTILO DO CABEÇALHO ====
                dataGridMarca.EnableHeadersVisualStyles = false;
                dataGridMarca.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
                dataGridMarca.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridMarca.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dataGridMarca.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridMarca.ColumnHeadersHeight = 32;

                // ==== ESTILO DAS LINHAS ====
                dataGridMarca.DefaultCellStyle.BackColor = Color.White;
                dataGridMarca.DefaultCellStyle.ForeColor = Color.Black;
                dataGridMarca.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                dataGridMarca.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
                dataGridMarca.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridMarca.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                dataGridMarca.RowHeadersVisible = false;

                // ==== CONFIGURAÇÃO DAS COLUNAS ====
                dataGridMarca.Columns["Id"].HeaderText = "Código";
                dataGridMarca.Columns["Id"].Width = 80;
                dataGridMarca.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridMarca.Columns["Nome"].HeaderText = "Nome da Marca/Fabricante";
                dataGridMarca.Columns["Nome"].Width = 300;

                // ==== COMPORTAMENTO ====
                dataGridMarca.ReadOnly = true;
                dataGridMarca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridMarca.MultiSelect = false;
                dataGridMarca.BorderStyle = BorderStyle.FixedSingle;
                dataGridMarca.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridMarca.GridColor = Color.FromArgb(220, 220, 220);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar marcas : " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textDadosPesquisa_TextChanged(object sender, EventArgs e)
        {

            string filtroSelecindo = comboFiltros.Text;
            string modelo = comboModelo.Text;
            string dadosBuscar = textDadosPesquisa.Text;

            IQueryable<Model.Marca> query = dbConectionPdv.Marcas.AsQueryable();

            if (string.IsNullOrWhiteSpace(filtroSelecindo))
            {
                CarregarMarca();
                return;
            }

            if (filtroSelecindo == "Por Nome ")
            {
                if (modelo == "Inicia Com")
                {
                    query = query.Where(m => m.Nome.Trim().StartsWith(dadosBuscar));
                }
                else if (modelo == "Termina Com")
                {
                    query = query.Where(m => m.Nome.Trim().EndsWith(dadosBuscar));
                }
                else if (modelo == "Contem")
                {
                    query = query.Where(m => m.Nome.Trim().Contains(dadosBuscar));

                }
            }
            else if (filtroSelecindo == "Por Codigo ")
            {
                if (int.TryParse(dadosBuscar, out int idMarca))
                {
                    query = query.Where(m => m.Id == idMarca);
                }
                else
                {
                    dataGridMarca.DataSource = null;

                }

            }

            var resultado = query.ToList();
            dataGridMarca.DataSource = resultado;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridMarca.SelectedRows.Count > 0)
                {
                    int marcaId = (int)dataGridMarca.SelectedRows[0].Cells["Id"].Value;
                    Marca marca = dbConectionPdv.Marcas.Find(marcaId);
                    this.AbriAbaCadastro(marca);
                }
                else
                {
                    MessageBox.Show("Selecione  uma  marca.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar marca para edição: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void AbriAbaCadastro(Marca marca)
        {
            tabControl.SelectedTab = tabCadastro;
            textCodigo.Text = marca.Id.ToString();
            textNome.Text = marca.Nome.ToString();
            checkedAtivo.Checked = (bool)marca.Ativo;
            textCodigo.ReadOnly = true;
            textNome.ReadOnly = false;
            textNome.Focus();



        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir uma marca selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    if (dataGridMarca.SelectedRows.Count > 0)
                    {
                        var linhaSelecionada = dataGridMarca.SelectedRows[0];
                        var marcaId = (int)linhaSelecionada.Cells["Id"].Value;
                        var marcasParaExclusao = dbConectionPdv.Marcas.FirstOrDefault(m => m.Id == marcaId);

                        if (marcasParaExclusao != null)
                        {
                            dbConectionPdv.Marcas.Remove(marcasParaExclusao);
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("Marca excluído com sucesso!", "Sucesso", MessageBoxButtons.OK);
                            CarregarMarca();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione um marca para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o marca: " + ex.Message);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            GravarMarca();
        }


        private void GravarMarca()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textNome.Text))
                {

                    MessageBox.Show("Campo obrigatorio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textNome.Focus();
                    return;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textCodigo.Text))
                    {
                        // e um novo regitros

                        bool jaExisteMarcas = dbConectionPdv.Marcas.Any(m => m.Nome == textNome.Text.Trim());
                        if (jaExisteMarcas)
                        {
                            MessageBox.Show("Essa marca ja existe", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            var marca = new Marca
                            {
                                Nome = textNome.Text,
                                Ativo = checkedAtivo.Checked,
                            };

                            dbConectionPdv.Add(marca);
                            dbConectionPdv.SaveChanges();

                            MessageBox.Show("Marca salva com sucesso:", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textCodigo.Text = marca.Id.ToString();
                            CarregarMarca();
                            return;

                        }
                    }
                    else
                    {
                        int marcaId = int.Parse(textCodigo.Text);
                        var marcaParaEdicao = dbConectionPdv.Marcas.Find(marcaId);
                        if (marcaParaEdicao != null)
                        {
                            marcaParaEdicao.Nome = textNome.Text;
                            marcaParaEdicao.Ativo = checkedAtivo.Checked;
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("Marca atualizada  com sucesso:", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textCodigo.Text = marcaParaEdicao?.Id.ToString();
                            CarregarMarca();
                            return;

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a marca: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabCadastro;
            textCodigo.ReadOnly = true;
            textNome.ReadOnly = false;
            textNome.Focus();
            textCodigo.Clear();
            textNome.Clear();
        }
    }
}
