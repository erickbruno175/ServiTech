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
    public partial class CadastrarCFOP : Form
    {

        private readonly DbConection.DbConectionPdv dbConectionPdv = new DbConection.DbConectionPdv();
        public CadastrarCFOP()
        {
            InitializeComponent();
        }



        private void CadastrarCFOP_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {
                textCodRegra.ReadOnly = false;
                textNome.ReadOnly = false;
                textNome.Focus();
                // Limpar os campos para um novo cadastro
                textCodRegra.Clear();
                textNome.Clear();
                textCod.Clear();
            }
            else if (e.KeyCode == Keys.F5)
            {
                this.GravarCFOP();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            textCodRegra.ReadOnly = false;
            textNome.ReadOnly = false;
            textNome.Focus();
            // Limpar os campos para um novo cadastro
            textCodRegra.Clear();
            textNome.Clear();
            textCod.Clear();

        }

        private void CadastrarCFOP_Load(object sender, EventArgs e)
        {

            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Items.Add("Por Nome ");
            comboFiltros.Items.Add("Por Codigo Cfop ");
            comboFiltros.SelectedIndex = 0;

            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.SelectedIndex = 0;

            CarregarCFOP();
        }


        private void CarregarCFOP()
        {
            try
            {
                var cfop = dbConectionPdv.CFOPs

                    .ToList();

                dataGridCOFP.DataSource = cfop;

                // ==== ESTILO DO CABEÇALHO ====
                dataGridCOFP.EnableHeadersVisualStyles = false;
                dataGridCOFP.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
                dataGridCOFP.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridCOFP.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dataGridCOFP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridCOFP.ColumnHeadersHeight = 32;

                // ==== ESTILO DAS LINHAS ====
                dataGridCOFP.DefaultCellStyle.BackColor = Color.White;
                dataGridCOFP.DefaultCellStyle.ForeColor = Color.Black;
                dataGridCOFP.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                dataGridCOFP.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
                dataGridCOFP.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridCOFP.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                dataGridCOFP.RowHeadersVisible = false;

                // ==== CONFIGURAÇÃO DAS COLUNAS ====
                dataGridCOFP.Columns["Codigo"].HeaderText = "Código do Cfop";
                dataGridCOFP.Columns["Codigo"].Width = 150;
                dataGridCOFP.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                dataGridCOFP.Columns["Id"].HeaderText = "Código";
                dataGridCOFP.Columns["Id"].Width = 150;
                dataGridCOFP.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridCOFP.Columns["Descricao"].HeaderText = "Descrição";
                dataGridCOFP.Columns["Descricao"].Width = 500;
                dataGridCOFP.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;



                // ==== COMPORTAMENTO ====
                dataGridCOFP.ReadOnly = true;
                dataGridCOFP.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona linha inteira
                dataGridCOFP.MultiSelect = false; // Só uma linha por vez
                dataGridCOFP.BorderStyle = BorderStyle.FixedSingle;
                dataGridCOFP.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridCOFP.GridColor = Color.FromArgb(220, 220, 220);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os origem CFOPs: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textDadosPesquisa_TextChanged(object sender, EventArgs e)
        {

            var filtro = comboFiltros.SelectedItem.ToString();
            var modelo = comboModelo.SelectedItem.ToString();
            var textoPesquisa = textDadosPesquisa.Text.Trim();

            IQueryable<Model.ModelTributacao.CFOP> query = dbConectionPdv.CFOPs;

            if (string.IsNullOrEmpty(textoPesquisa))
            {
                CarregarCFOP();
                return;
            }

            if (!string.IsNullOrEmpty(textoPesquisa))
            {
                if (filtro == "Por Nome ")
                {
                    if (modelo == "Inicia Com")
                    {
                        query = query.Where(c => c.Descricao.StartsWith(textoPesquisa));
                    }
                    else if (modelo == "Termina Com")
                    {
                        query = query.Where(c => c.Descricao.EndsWith(textoPesquisa));
                    }
                    else if (modelo == "Contem")
                    {
                        query = query.Where(c => c.Descricao.Contains(textoPesquisa));
                    }
                }
                else if (filtro == "Por Codigo Cfop ")
                {
                    if (modelo == "Inicia Com")
                    {
                        query = query.Where(c => c.Codigo.StartsWith(textoPesquisa));
                    }
                    else if (modelo == "Termina Com")
                    {
                        query = query.Where(c => c.Codigo.EndsWith(textoPesquisa));
                    }
                    else if (modelo == "Contem")
                    {
                        query = query.Where(c => c.Codigo.Contains(textoPesquisa));
                    }
                }
            }

            var resultado = query.ToList();
            dataGridCOFP.DataSource = resultado;



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {


            if (dataGridCOFP.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridCOFP.SelectedRows[0];
                var cfopId = (int)selectedRow.Cells["Id"].Value;
                CFOP cfop = dbConectionPdv.CFOPs.FirstOrDefault(c => c.Id == cfopId);

                AbrirAbaCadastro(cfop);

            }
            else
            {
                MessageBox.Show("Selecione um CFOP para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AbrirAbaCadastro(CFOP? cfop)
        {

            tabControl1.SelectedTab = tabCadastro;
            textCodRegra.ReadOnly = false;
            textNome.ReadOnly = false;
            textNome.Focus();

            if (cfop != null)
            {
                textCodRegra.Text = cfop.Codigo;
                textNome.Text = cfop.Descricao;
                textCod.Text = cfop.Id.ToString(); // Armazena o ID no Tag para referência futura

            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            this.GravarCFOP();

        }

        private void GravarCFOP()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textCodRegra.Text) || string.IsNullOrWhiteSpace(textNome.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textCod.Text))
                    {
                        // 🔹 Novo CFOP
                        bool existeCFOP = dbConectionPdv.CFOPs
                            .Any(c => c.Codigo.Trim() == textCodRegra.Text.Trim() &&
                                      c.Descricao.Trim().ToLower() == textNome.Text.Trim().ToLower());

                        if (existeCFOP)
                        {
                            MessageBox.Show("Já existe um CFOP com este código e descrição.", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            var novoCFOP = new CFOP
                            {
                                Codigo = textCodRegra.Text.Trim(),
                                Descricao = textNome.Text.Trim()
                            };

                            dbConectionPdv.CFOPs.Add(novoCFOP);
                            dbConectionPdv.SaveChanges();

                            textCod.Text = novoCFOP.Id.ToString();

                            MessageBox.Show("CFOP cadastrado com sucesso!", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CarregarCFOP();
                            return;
                        }
                    }
                    else
                    {
                        // 🔹 Atualizar CFOP existente
                        if (!int.TryParse(textCod.Text, out int cfopId))
                        {
                            MessageBox.Show("Código inválido.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var cfopExistente = dbConectionPdv.CFOPs.Find(cfopId);

                        if (cfopExistente != null)
                        {
                            cfopExistente.Codigo = textCodRegra.Text.Trim();
                            cfopExistente.Descricao = textNome.Text.Trim();

                            dbConectionPdv.SaveChanges();

                            MessageBox.Show("CFOP atualizado com sucesso!", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CarregarCFOP();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("CFOP não encontrado para atualização.", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o CFOP: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dataGridCOFP.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridCOFP.SelectedRows[0];
                var cfopId = (int)selectedRow.Cells["Id"].Value;
                CFOP cfop = dbConectionPdv.CFOPs.FirstOrDefault(c => c.Id == cfopId);
                if (cfop != null)
                {
                    var confirmResult = MessageBox.Show($"Tem certeza que deseja excluir o CFOP '{cfop.Descricao}'?",
                                                         "Confirmação de Exclusão",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            dbConectionPdv.CFOPs.Remove(cfop);
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("CFOP excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarCFOP();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao excluir o CFOP: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um CFOP válido para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selecione um CFOP para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabCadastro;
            textCodRegra.ReadOnly = false;
            textNome.ReadOnly = false;
            textNome.Focus();
            // Limpar os campos para um novo cadastro
            textCodRegra.Clear();
            textNome.Clear();
            textCod.Clear();

        }
    }
}
