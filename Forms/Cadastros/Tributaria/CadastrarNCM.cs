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
    public partial class CadastrarNCM : Form
    {
        private readonly DbConectionPdv dbConectionPdv;
        public CadastrarNCM(DbConectionPdv dbConectionPdv)
        {
            this.dbConectionPdv = dbConectionPdv;
            InitializeComponent();
        }

        private void CadastrarNCM_Load(object sender, EventArgs e)
        {
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Items.Add("Por Nome");
            comboFiltros.Items.Add("Por Codigo Ncm");
            comboFiltros.SelectedIndex = 0;

            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.SelectedIndex = 0;

            this.CarregarNcmGrid();
        }


        private void CarregarNcmGrid()
        {
            try
            {
                var ncm = dbConectionPdv.Ncms

                    .ToList();

                dataGridNCM.DataSource = ncm;

                // ==== ESTILO DO CABEÇALHO ====
                dataGridNCM.EnableHeadersVisualStyles = false;
                dataGridNCM.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
                dataGridNCM.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridNCM.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dataGridNCM.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridNCM.ColumnHeadersHeight = 32;

                // ==== ESTILO DAS LINHAS ====
                dataGridNCM.DefaultCellStyle.BackColor = Color.White;
                dataGridNCM.DefaultCellStyle.ForeColor = Color.Black;
                dataGridNCM.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                dataGridNCM.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
                dataGridNCM.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridNCM.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                dataGridNCM.RowHeadersVisible = false;

                // ==== CONFIGURAÇÃO DAS COLUNAS ====
                dataGridNCM.Columns["Codigo"].HeaderText = "Código do Ncm";
                dataGridNCM.Columns["Codigo"].Width = 150;
                dataGridNCM.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                dataGridNCM.Columns["Id"].HeaderText = "Código";
                dataGridNCM.Columns["Id"].Width = 150;
                dataGridNCM.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridNCM.Columns["Nome"].HeaderText = "Descrição";
                dataGridNCM.Columns["Nome"].Width = 500;
                dataGridNCM.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;



                // ==== COMPORTAMENTO ====
                dataGridNCM.ReadOnly = true;
                dataGridNCM.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona linha inteira
                dataGridNCM.MultiSelect = false; // Só uma linha por vez
                dataGridNCM.BorderStyle = BorderStyle.FixedSingle;
                dataGridNCM.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridNCM.GridColor = Color.FromArgb(220, 220, 220);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar  NCM: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CadastrarNCM_KeyDown(object sender, KeyEventArgs e)
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
                this.GravarNCM();

            }
        }

        private void textDadosPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = comboFiltros.SelectedItem?.ToString();
                string modeloPesquisa = comboModelo.SelectedItem?.ToString();
                string campoPesquisa = textDadosPesquisa.Text.ToLower().ToString();

                IQueryable<NCM> query = dbConectionPdv.Ncms.AsQueryable();

                if (string.IsNullOrWhiteSpace(campoPesquisa))
                {
                    CarregarNcmGrid();
                    return;
                }

                if (filtro == "Por Nome")
                {
                    if (modeloPesquisa == "Inicia Com")
                    {
                        query = query.Where(nc => nc.Nome.ToLower().StartsWith(campoPesquisa));

                    }
                    else if (modeloPesquisa == "Termina Com")
                    {
                        query = query.Where(nc => nc.Nome.ToLower().EndsWith(campoPesquisa));

                    }
                    else if (filtro == "Contem")
                    {
                        query = query.Where(nc => nc.Nome.ToLower().Contains(campoPesquisa));

                    }
                }
                else if (filtro == "Por Codigo Ncm")
                {
                    if (modeloPesquisa == "Inicia Com")
                    {
                        query = query.Where(nc => nc.Codigo.StartsWith(campoPesquisa));

                    }
                    else if (modeloPesquisa == "Termina Com")
                    {
                        query = query.Where(nc => nc.Codigo.EndsWith(campoPesquisa));

                    }
                    else if (filtro == "Contem")
                    {
                        query = query.Where(nc => nc.Codigo.Contains(campoPesquisa));

                    }
                }

                var resultado = query.ToList();
                dataGridNCM.DataSource = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erros ao carregar ncm " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridNCM.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridNCM.SelectedRows[0];
                var ncmpId = (int)selectedRow.Cells["Id"].Value;
                NCM ncm = dbConectionPdv.Ncms.FirstOrDefault(n => n.Id == ncmpId);

                AbrirAbaCadastro(ncm);

            }
            else
            {
                MessageBox.Show("Selecione um NCM para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AbrirAbaCadastro(NCM ncm)
        {

            tabControl1.SelectedTab = tabCadastro;
            textCodRegra.ReadOnly = false;
            textNome.ReadOnly = false;
            textNome.Focus();

            if (ncm != null)
            {
                textCodRegra.Text = ncm.Codigo;
                textNome.Text = ncm.Nome;
                textCod.Text = ncm.Id.ToString(); // Armazena o ID no Tag para referência futura

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridNCM.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridNCM.SelectedRows[0];
                var ncmId = (int)selectedRow.Cells["Id"].Value;
                NCM ncm = dbConectionPdv.Ncms.FirstOrDefault(n => n.Id == ncmId);
                if (ncm != null)
                {
                    var confirmResult = MessageBox.Show($"Tem certeza que deseja excluir o NCM '{ncm.Nome}'?",
                                                         "Confirmação de Exclusão",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            dbConectionPdv.Ncms.Remove(ncm);
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("ncm excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarNcmGrid();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao excluir o NCM: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um NCM válido para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selecione um NCM para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.GravarNCM();
        }

        private void GravarNCM()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textCodRegra.Text) || string.IsNullOrWhiteSpace(textNome.Text))
                {

                    MessageBox.Show("Campo obrigatorio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textCod.Text))
                    {
                        bool jaExiste = dbConectionPdv.Ncms.Any(nc => nc.Nome == textNome.Text || nc.Codigo == textCodRegra.Text);

                        if (jaExiste)
                        {
                            MessageBox.Show("Já existe um registro com esse nome ou código.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        var ncm = new NCM
                        {
                            Nome = textNome.Text,
                            Codigo = textCodRegra.Text,
                        };

                        dbConectionPdv.Add(ncm);
                        dbConectionPdv.SaveChanges();

                        MessageBox.Show("NCM cadastrado com sucesso.",
                               "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textCod.Text = ncm.Id.ToString();
                        CarregarNcmGrid();
                        return;



                    }
                    else
                    {
                        int ncmId = int.Parse(textCod.Text);
                        var ncmEdicao = dbConectionPdv.Ncms.Find(ncmId);

                        if (ncmEdicao != null)
                        {
                            ncmEdicao.Nome = textNome.Text;
                            ncmEdicao.Codigo = textCodRegra.Text;

                            dbConectionPdv.SaveChanges();

                            MessageBox.Show("NCM atualizado  com sucesso.",
                                   "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            CarregarNcmGrid();
                            return;

                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao gravar NCM" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
