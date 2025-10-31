using ServiTech.Model;
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

namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarAtividadeEconomica : Form
    {
        private readonly DbConection.DbConectionPdv dbConectionPdv;
        public CadastrarAtividadeEconomica(DbConection.DbConectionPdv dbConectionPdv)
        {
            InitializeComponent();
            this.dbConectionPdv = dbConectionPdv;
        }



        private void CadastrarAtividade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                textNome.ReadOnly = false;
                textCod.Clear();
                textNome.Clear();
                textNome.Focus();

            }
            else if (e.KeyCode == Keys.F5)
            {
                this.GravarAtividade();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            textNome.ReadOnly = false;
            textCod.Clear();
            textNome.Clear();
            textNome.Focus();
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabCadastro;
            textNome.ReadOnly = false;
            textCod.Clear();
            textNome.Clear();
            textNome.Focus();
        }

        private void CadastrarAtividadeEconomica_Load(object sender, EventArgs e)
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

            this.CarregarAtividadesGrid();
        }


        private void CarregarAtividadesGrid()
        {
            try
            {
                var atividadeEconomicas = dbConectionPdv.AtividadeEconomicas

                    .ToList();

                dataGridAtividade.DataSource = atividadeEconomicas;

                // ==== ESTILO DO CABEÇALHO ====
                dataGridAtividade.EnableHeadersVisualStyles = false;
                dataGridAtividade.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
                dataGridAtividade.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridAtividade.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dataGridAtividade.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridAtividade.ColumnHeadersHeight = 32;

                // ==== ESTILO DAS LINHAS ====
                dataGridAtividade.DefaultCellStyle.BackColor = Color.White;
                dataGridAtividade.DefaultCellStyle.ForeColor = Color.Black;
                dataGridAtividade.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                dataGridAtividade.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
                dataGridAtividade.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridAtividade.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                dataGridAtividade.RowHeadersVisible = false;

                // ==== CONFIGURAÇÃO DAS COLUNAS ====


                dataGridAtividade.Columns["Id"].HeaderText = "Código";
                dataGridAtividade.Columns["Id"].Width = 150;
                dataGridAtividade.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridAtividade.Columns["Nome"].HeaderText = "Descrição";
                dataGridAtividade.Columns["Nome"].Width = 300;
                dataGridAtividade.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;



                // ==== COMPORTAMENTO ====
                dataGridAtividade.ReadOnly = true;
                dataGridAtividade.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona linha inteira
                dataGridAtividade.MultiSelect = false; // Só uma linha por vez
                dataGridAtividade.BorderStyle = BorderStyle.FixedSingle;
                dataGridAtividade.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridAtividade.GridColor = Color.FromArgb(220, 220, 220);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar atividades economicas: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textDadosPesquisa_TextChanged(object sender, EventArgs e)
        {
            var filtro = comboFiltros.SelectedItem.ToString();
            var modelo = comboModelo.SelectedItem.ToString();
            var textoPesquisa = textDadosPesquisa.Text.Trim();

            IQueryable<Model.AtividadeEconomica> query = dbConectionPdv.AtividadeEconomicas;

            if (string.IsNullOrEmpty(textoPesquisa))
            {
                CarregarAtividadesGrid();
                return;
            }

            if (!string.IsNullOrEmpty(textoPesquisa))
            {
                if (filtro == "Por Nome ")
                {
                    if (modelo == "Inicia Com")
                    {
                        query = query.Where(a => a.Nome.StartsWith(textoPesquisa));
                    }
                    else if (modelo == "Termina Com")
                    {
                        query = query.Where(a => a.Nome.EndsWith(textoPesquisa));
                    }
                    else if (modelo == "Contem")
                    {
                        query = query.Where(a => a.Nome.Contains(textoPesquisa));
                    }
                }
                else if (filtro == "Por Codigo ")
                {
                    if (int.TryParse(textoPesquisa, out int codigo))
                    {
                        query = query.Where(a => a.Id == codigo);
                    }
                    else
                    {
                        query = Enumerable.Empty<AtividadeEconomica>().AsQueryable();
                    }
                }
            }

            var resultado = query.ToList();
            dataGridAtividade
                .DataSource = resultado;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o atividade  selecionada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    if (dataGridAtividade.SelectedRows.Count > 0)
                    {
                        var linhaSelecionada = dataGridAtividade.SelectedRows[0];
                        var atividadeId = (int)linhaSelecionada.Cells["Id"].Value;
                        var atividadeIdParaExclusao = dbConectionPdv.AtividadeEconomicas.FirstOrDefault(a => a.Id == atividadeId);

                        if (atividadeIdParaExclusao != null)
                        {
                            dbConectionPdv.AtividadeEconomicas.Remove(atividadeIdParaExclusao);
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("Atividade  excluída com sucesso!", "Sucesso", MessageBoxButtons.OK);
                            CarregarAtividadesGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma  atividade  para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir a  atividade: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridAtividade.SelectedRows.Count > 0)
            {
                var linhaSelecionada = dataGridAtividade.SelectedRows[0];
                var atividadeId = (int)linhaSelecionada.Cells["Id"].Value;
                var atividadeEdicao = dbConectionPdv.AtividadeEconomicas.Find(atividadeId);
                this.AbrirAbaCadastro(atividadeEdicao.Id, atividadeEdicao.Nome);
            }
            else
            {
                MessageBox.Show("Selecione uma atividade  para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AbrirAbaCadastro(int id, string nome)
        {
            tabControl.SelectedTab = tabCadastro;
            textNome.ReadOnly = false;

            textCod.Text = id.ToString();
            textNome.Text = nome;
        }



        private void GravarAtividade()
        {

            try
            {
                if (string.IsNullOrWhiteSpace(textNome.Text))
                {
                    MessageBox.Show("O campo Nome da  atividade  é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textNome.Focus();
                    return;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textCod.Text))
                    {

                        if (dbConectionPdv.AtividadeEconomicas.Any(a => a.Nome == textNome.Text))
                        {
                            MessageBox.Show("Já existe uma atividade com esse nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textNome.Focus();
                            return;

                        }
                        else
                        {

                            var novaAtividade = new AtividadeEconomica
                            {
                                Nome = textNome.Text
                            };
                            dbConectionPdv.AtividadeEconomicas.Add(novaAtividade);
                            dbConectionPdv.SaveChanges();
                            textCod.Text = novaAtividade.Id.ToString();
                            MessageBox.Show("Atividade  cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        // editar pais
                        var atividadeId = int.Parse(textCod.Text);
                        var atividadeExistente = dbConectionPdv.AtividadeEconomicas.Find(atividadeId);
                        if (atividadeExistente != null)
                        {

                            atividadeExistente.Nome = textNome.Text;
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("Atividade atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK);

                        }
                        else
                        {
                            MessageBox.Show("Atividade não encontrado para atualização.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar  atividade: " + ex.Message);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.GravarAtividade();
        }
    }
}
