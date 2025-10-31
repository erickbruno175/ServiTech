using ServiTech.DbConection;
using ServiTech.Model.ModelTributacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiTech.Forms.Cadastros.Tributaria
{
    public partial class CadastrarCSTCSOSN : Form
    {
        private readonly DbConection.DbConectionPdv _dbContext = new DbConection.DbConectionPdv();
        public CadastrarCSTCSOSN()
        {
            InitializeComponent();
        }





        private void CadastrarCSTCSOSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                textCodRegra.ReadOnly = false;
                textNome.ReadOnly = false;
                textNome.Focus();
                // limpar os campos
                textCod.Clear();
                textCodRegra.Clear();
                textNome.Clear();
            }else if (e.KeyCode == Keys.F5)
            {
                this.GravarCst();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            textCodRegra.ReadOnly = false;
            textNome.ReadOnly = false;
            textNome.Focus();
            // limpar os campos
            textCod.Clear();
            textCodRegra.Clear();
            textNome.Clear();

        }

        private void CadastrarCSTCSOSN_Load(object sender, EventArgs e)
        {

            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Items.Add("Por Nome ");
            comboFiltros.Items.Add("Por Codigo CST ");
            comboFiltros.SelectedIndex = 0;

            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.SelectedIndex = 0;

            CarregarCst();
        }



        private void CarregarCst()
        {
            try
            {
                var cst = _dbContext.CSTCSOSNs

                    .ToList();

                dataGridCST.DataSource = cst;

                // ==== ESTILO DO CABEÇALHO ====
                dataGridCST.EnableHeadersVisualStyles = false;
                dataGridCST.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
                dataGridCST.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridCST.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dataGridCST.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridCST.ColumnHeadersHeight = 32;

                // ==== ESTILO DAS LINHAS ====
                dataGridCST.DefaultCellStyle.BackColor = Color.White;
                dataGridCST.DefaultCellStyle.ForeColor = Color.Black;
                dataGridCST.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                dataGridCST.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
                dataGridCST.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridCST.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                dataGridCST.RowHeadersVisible = false;

                // ==== CONFIGURAÇÃO DAS COLUNAS ====
                dataGridCST.Columns["Codigo"].HeaderText = "Código do Cst";
                dataGridCST.Columns["Codigo"].Width = 150;
                dataGridCST.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                dataGridCST.Columns["Id"].HeaderText = "Código";
                dataGridCST.Columns["Id"].Width = 150;
                dataGridCST.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridCST.Columns["Descricao"].HeaderText = "Descrição";
                dataGridCST.Columns["Descricao"].Width = 500;
                dataGridCST.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;



                // ==== COMPORTAMENTO ====
                dataGridCST.ReadOnly = true;
                dataGridCST.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona linha inteira
                dataGridCST.MultiSelect = false; // Só uma linha por vez
                dataGridCST.BorderStyle = BorderStyle.FixedSingle;
                dataGridCST.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridCST.GridColor = Color.FromArgb(220, 220, 220);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar  Cst: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textDadosPesquisa_TextChanged(object sender, EventArgs e)
        {
            var dadosPesquisa = textDadosPesquisa.Text.Trim().ToLower();
            var modelo = comboModelo.SelectedItem.ToString();
            var filtroSelecionado = comboFiltros.SelectedItem.ToString();

            IQueryable<ServiTech.Model.ModelTributacao.CSTCSOSN> cstQuery = _dbContext.CSTCSOSNs;

            if (string.IsNullOrWhiteSpace(dadosPesquisa))
            {
                CarregarCst();
            }
            else
            {
                if (filtroSelecionado == "Por Nome ")
                {
                    if (modelo == "Inicia Com")
                    {
                        cstQuery = cstQuery.Where(c => c.Descricao.ToLower().StartsWith(dadosPesquisa));
                    }
                    else if (modelo == "Termina Com")
                    {
                        cstQuery = cstQuery.Where(c => c.Descricao.ToLower().EndsWith(dadosPesquisa));
                    }
                    else if (modelo == "Contem")
                    {
                        cstQuery = cstQuery.Where(c => c.Descricao.ToLower().Contains(dadosPesquisa));
                    }
                }
                else if (filtroSelecionado == "Por Codigo CST ")
                {
                    if (modelo == "Inicia Com")
                    {
                        cstQuery = cstQuery.Where(c => c.Codigo.ToLower().StartsWith(dadosPesquisa));
                    }
                    else if (modelo == "Termina Com")
                    {
                        cstQuery = cstQuery.Where(c => c.Codigo.ToLower().EndsWith(dadosPesquisa));
                    }
                    else if (modelo == "Contem")
                    {
                        cstQuery = cstQuery.Where(c => c.Codigo.ToLower().Contains(dadosPesquisa));
                    }
                }

                var resultadoFiltrado = cstQuery.ToList();
                dataGridCST.DataSource = resultadoFiltrado;
            }



        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {


            if (dataGridCST.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir a regra selecionada?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        var selectedRow = dataGridCST.SelectedRows[0];
                        var cstId = (int)selectedRow.Cells["Id"].Value;
                        var cstToDelete = _dbContext.CSTCSOSNs.Find(cstId);
                        if (cstToDelete != null)
                        {
                            _dbContext.CSTCSOSNs.Remove(cstToDelete);
                            _dbContext.SaveChanges();
                            MessageBox.Show("Regra excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarCst();
                        }
                        else
                        {
                            MessageBox.Show("Regra não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir a regra: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Selecione uma regra para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridCST.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridCST.SelectedRows[0];
                int cstId = (int)selectedRow.Cells["Id"].Value;
                CSTCSOSN cSTCSOSN = _dbContext.CSTCSOSNs.Find(cstId);
                AbrirAbaCadastro(cSTCSOSN);

            }
            else
            {
                MessageBox.Show("Selecione uma regra para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AbrirAbaCadastro(CSTCSOSN? cSTCSOSN)
        {
            tabControl1.SelectedTab = tabCadastro;
            textCod.Text = cSTCSOSN?.Id.ToString();
            textCodRegra.Text = cSTCSOSN?.Codigo;
            textNome.Text = cSTCSOSN?.Descricao;

            textCodRegra.ReadOnly = false;
            textNome.ReadOnly = false;
            textNome.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.GravarCst();
        }

        private void GravarCst()
        {
            if (string.IsNullOrWhiteSpace(textCodRegra.Text) || string.IsNullOrWhiteSpace(textNome.Text))
            {
                MessageBox.Show("Dados é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textCodRegra.Focus();
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(textCod.Text))// verifica se e um novo registro
                {
                    // se existe codigo ou cst com esse nome
                    bool existeCst = _dbContext.CSTCSOSNs
                        .Any(c => c.Codigo == textCodRegra.Text || c.Descricao == textNome.Text.ToLower().Trim());

                    if (existeCst)
                    {
                        MessageBox.Show("Já existe uma regra com esse código ou nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textCodRegra.Focus();

                        return;
                    }
                    else
                    {
                        var novoCst = new CSTCSOSN
                        {
                            Codigo = textCodRegra.Text,
                            Descricao = textNome.Text.ToLower().Trim()
                        };

                        try
                        {
                            _dbContext.CSTCSOSNs.Add(novoCst);
                            _dbContext.SaveChanges();
                            MessageBox.Show("Regra cadastrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textCod.Text = novoCst.Id.ToString();
                            CarregarCst();
                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao cadastrar a regra: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }
                else
                {
                    // editar
                    int cstId = int.Parse(textCod.Text);
                    CSTCSOSN cstExistente = _dbContext.CSTCSOSNs.Find(cstId);

                    if (cstExistente != null)
                    {
                        cstExistente.Codigo = textCodRegra.Text;
                        cstExistente.Descricao = textNome.Text.ToLower().Trim();
                        try
                        {
                            _dbContext.SaveChanges();
                            MessageBox.Show("Regra atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CarregarCst();
                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao atualizar a regra: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                }


            }
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabCadastro;
            textCodRegra.ReadOnly = false;
            textNome.ReadOnly = false;
            textNome.Focus();
            // limpar os campos
            textCod.Clear();
            textCodRegra.Clear();
            textNome.Clear();

        }
    }
}
