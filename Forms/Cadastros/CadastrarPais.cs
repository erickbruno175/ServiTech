using Microsoft.EntityFrameworkCore;
using ServiTech.Model.ModelLocalidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarPais : Form
    {

        private readonly DbConection.DbConectionPdv dbConectionPdv;
        public CadastrarPais(DbConection.DbConectionPdv dbConectionPdv)
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

            this.CarregarDataGrid();

        }



        private void LiberarCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {

            textNome.ReadOnly = false;
        }

        private void LiberarCamposParaNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {
                textNome.ReadOnly = false;

                textNome.ReadOnly = false;
                textCodigoPais.Text = "";
                textNome.Text = "";
                textNome.Focus();
            }else if (e.KeyCode == Keys.F5)
            {
                this.GravarPais();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            textNome.ReadOnly = false;
            textCodigoPais.Text = "";
            textNome.Text = "";
            textNome.Focus();
        }


        private void CarregarDataGrid()
        {
            try
            {
                // Obtém todos os países do banco
                var paises = dbConectionPdv.Paises
                    .OrderBy(p => p.Id)
                    .Select(p => new
                    {
                        Codigo = p.Id,
                        Nome = p.Nome
                    })
                    .ToList();

                dataGridPais.DataSource = paises;

                // ==== ESTILO DO CABEÇALHO ====
                dataGridPais.EnableHeadersVisualStyles = false;
                dataGridPais.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
                dataGridPais.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridPais.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dataGridPais.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridPais.ColumnHeadersHeight = 32;

                // ==== ESTILO DAS LINHAS ====
                dataGridPais.DefaultCellStyle.BackColor = Color.White;
                dataGridPais.DefaultCellStyle.ForeColor = Color.Black;
                dataGridPais.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                dataGridPais.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
                dataGridPais.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridPais.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                dataGridPais.RowHeadersVisible = false;

                // ==== CONFIGURAÇÃO DAS COLUNAS ====
                dataGridPais.Columns["Codigo"].HeaderText = "Código";
                dataGridPais.Columns["Codigo"].Width = 80;
                dataGridPais.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridPais.Columns["Nome"].HeaderText = "Nome do País";
                dataGridPais.Columns["Nome"].Width = 250;

                // ==== COMPORTAMENTO ====
                dataGridPais.ReadOnly = true;
                dataGridPais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridPais.MultiSelect = false;
                dataGridPais.BorderStyle = BorderStyle.FixedSingle;
                dataGridPais.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridPais.GridColor = Color.FromArgb(220, 220, 220);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os países: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GravarPais()
        {

            try
            {
                if (string.IsNullOrWhiteSpace(textNome.Text))
                {
                    MessageBox.Show("O campo Nome do Pais é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textNome.Focus();
                    return;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textCodigoPais.Text))
                    {

                        if (dbConectionPdv.Paises.Any(p => p.Nome == textNome.Text))
                        {
                            MessageBox.Show("Já existe um país com esse nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textNome.Focus();
                            return;

                        }
                        else
                        {

                            var novoPais = new Pais
                            {
                                Nome = textNome.Text
                            };
                            dbConectionPdv.Paises.Add(novoPais);
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("País cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                            textCodigoPais.Text = novoPais.Id.ToString();
                            CarregarDataGrid();
                            return;
                        }
                    }
                    else
                    {
                        // editar pais
                        var paisId = int.Parse(textCodigoPais.Text);
                        var paisExistente = dbConectionPdv.Paises.Find(paisId);
                        if (paisExistente != null)
                        {
                            if (dbConectionPdv.Paises.Any(p => p.Nome == textNome.Text && p.Id != paisId))
                            {
                                MessageBox.Show("Já existe um país com esse nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                textNome.Focus();
                                return;
                            }
                            else
                            {
                                paisExistente.Nome = textNome.Text;
                                dbConectionPdv.SaveChanges();
                                MessageBox.Show("País atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                                CarregarDataGrid();
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("País não encontrado para atualização.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o país: " + ex.Message);
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.GravarPais();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dataGridPais.SelectedRows.Count > 0)
            {
                var linhaSelecionada = dataGridPais.SelectedRows[0];
                var paisId = (int)linhaSelecionada.Cells["Codigo"].Value;
                var paisEditar = dbConectionPdv.Paises.Find(paisId);
                this.AbrirAbaCadastro(paisEditar.Id, paisEditar.Nome);
            }
            else
            {
                MessageBox.Show("Selecione um país para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AbrirAbaCadastro(int id, string nome)
        {
            tabControl.SelectedTab = tabCadastro;
            textCodigoPais.Text = id.ToString();
            textNome.Text = nome;
            textNome.ReadOnly = false;
            textNome.Focus();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // ecluir linha selecionada
            try
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o país selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    if (dataGridPais.SelectedRows.Count > 0)
                    {
                        var linhaSelecionada = dataGridPais.SelectedRows[0];
                        var paisId = (int)linhaSelecionada.Cells["Codigo"].Value;
                        var paisParaExclusao = dbConectionPdv.Paises.FirstOrDefault(p => p.Id == paisId);

                        if (paisParaExclusao != null)
                        {
                            dbConectionPdv.Paises.Remove(paisParaExclusao);
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("País excluído com sucesso!", "Sucesso", MessageBoxButtons.OK);
                            CarregarDataGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione um país para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o país: " + ex.Message);
            }
        }

        private void textDadosPesquisa_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string filtro = textDadosPesquisa.Text.Trim().ToLower();
                IQueryable<Pais> query = dbConectionPdv.Paises;
                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    if (comboFiltros.SelectedItem.ToString() == "Por Nome ")
                    {
                        if (comboModelo.SelectedItem.ToString() == "Inicia Com")
                        {
                            query = query.Where(p => p.Nome.ToLower().StartsWith(filtro));
                        }
                        else if (comboModelo.SelectedItem.ToString() == "Termina Com")
                        {
                            query = query.Where(p => p.Nome.ToLower().EndsWith(filtro));
                        }
                        else // Contem
                        {
                            query = query.Where(p => p.Nome.ToLower().Contains(filtro));
                        }
                    }
                    else if (comboFiltros.SelectedItem.ToString() == "Por Codigo ")
                    {
                        if (int.TryParse(textDadosPesquisa.Text, out int codigo))
                        {
                            query = query.Where(p => p.Id == codigo);
                        }
                        else
                        {
                            query = query.Where(p => false); // Nenhum resultado se o filtro não for um número válido
                        }
                    }
                }
                var resultados = query.OrderBy(p => p.Id).ToList();
                dataGridPais.DataSource = resultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao filtrar os países: " + ex.Message);
            }


        }

        private void CadastrarPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEditar_Click(this, new EventArgs());
            }
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {

            tabControl.SelectedTab = tabCadastro;
            textNome.ReadOnly = false;
            textNome.Focus();
            textCodigoPais.Clear();
        }
    }
}
