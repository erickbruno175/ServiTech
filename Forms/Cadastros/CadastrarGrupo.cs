using ServiTech.Model;
using ServiTech.Model.ModelGrupo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarGrupo : Form
    {

        private readonly DbConection.DbConectionPdv dbConectionPdv;
        public CadastrarGrupo()
        {
            dbConectionPdv = new DbConection.DbConectionPdv();
            InitializeComponent();
        }



        private void CadastrarGrupo_Load(object sender, EventArgs e)
        {




            comboFiltros.Items.Add("Por Nome ");
            comboFiltros.Items.Add("Por Codigo ");

            comboFiltros.SelectedIndex = 0;
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;

            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.SelectedIndex = 0;
            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;

            CarregarGridGrupos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            textNome.ReadOnly = false;
            textNome.Focus();
            textCod.Clear();
            textNome.Clear();
            checkAtivo.Enabled = true;

        }

        private void CadastrarGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {

                textNome.ReadOnly = false;
                textNome.Focus();
                textCod.Clear();
                textNome.Clear();
                checkAtivo.Enabled = true;

            }else if (e.KeyCode == Keys.F5)
            {
                this.GravarGrupo();
            }
        }


        private void CarregarGridGrupos()
        {
            try
            {
                // Obtém todos os países do banco
                var grupos = dbConectionPdv.Grupos
                    .OrderBy(g => g.Id).Select(g => new
                    {
                        g.Id,
                        g.Nome,
                        g.Ativo
                    })

                    .ToList();

                dataGridGrupo.DataSource = grupos;

                // ==== ESTILO DO CABEÇALHO ====
                dataGridGrupo.EnableHeadersVisualStyles = false;
                dataGridGrupo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
                dataGridGrupo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridGrupo.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dataGridGrupo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridGrupo.ColumnHeadersHeight = 32;

                // ==== ESTILO DAS LINHAS ====
                dataGridGrupo.DefaultCellStyle.BackColor = Color.White;
                dataGridGrupo.DefaultCellStyle.ForeColor = Color.Black;
                dataGridGrupo.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                dataGridGrupo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
                dataGridGrupo.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridGrupo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                dataGridGrupo.RowHeadersVisible = false;

                // ==== CONFIGURAÇÃO DAS COLUNAS ====
                dataGridGrupo.Columns["Id"].HeaderText = "Código";
                dataGridGrupo.Columns["Id"].Width = 80;
                dataGridGrupo.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridGrupo.Columns["Nome"].HeaderText = "Descrição";
                dataGridGrupo.Columns["Nome"].Width = 300;

                // ==== COMPORTAMENTO ====
                dataGridGrupo.ReadOnly = true;
                dataGridGrupo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridGrupo.MultiSelect = false;
                dataGridGrupo.BorderStyle = BorderStyle.FixedSingle;
                dataGridGrupo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridGrupo.GridColor = Color.FromArgb(220, 220, 220);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar grupos : " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textDadosPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtroSelecionado = comboFiltros.Text;
                string modeloSelecionado = comboModelo.Text;
                string campoDados = textDadosPesquisa.Text.Trim();

                IQueryable<Model.ModelGrupo.Grupo> query = dbConectionPdv.Grupos.AsQueryable();

                if (string.IsNullOrWhiteSpace(campoDados))
                {
                    CarregarGridGrupos();
                    return;
                }


                if (filtroSelecionado == "Por Nome ")
                {
                    if (modeloSelecionado == "Inicia Com")
                    {
                        query = query.Where(g => g.Nome.Trim().StartsWith(campoDados));

                    }
                    else if (modeloSelecionado == "Termina Com")
                    {
                        query = query.Where(g => g.Nome.Trim().EndsWith(campoDados));
                    }
                    else if (modeloSelecionado == "Contem")
                    {
                        query = query.Where(g => g.Nome.Trim().Contains(campoDados));

                    }

                }
                else if (filtroSelecionado == "Por Codigo ")
                {

                    if (int.TryParse(campoDados, out int grupoId))
                    {
                        query = query.Where(g => g.Id == grupoId);
                    }
                }

                var resuldado = query.Select(g => new
                {
                    g.Id,
                    g.Nome,
                    g.Ativo
                }).ToList();
                dataGridGrupo.DataSource = resuldado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao fazer a consulta:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridGrupo.SelectedRows.Count > 0)
                {
                    int linhaSelecionadaId = (int)dataGridGrupo.SelectedRows[0].Cells["Id"].Value;
                    Grupo grupoParaEdicao = dbConectionPdv.Grupos.Find(linhaSelecionadaId);

                    AbrirAbaCadastro(grupoParaEdicao);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu erro na sua consulta:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AbrirAbaCadastro(Grupo grupo)
        {
            tabControl1.SelectedTab = tabCadastro;
            textNome.ReadOnly = false;
            checkAtivo.Enabled = true;

            textCod.Text = grupo.Id.ToString();
            textNome.Text = grupo.Nome.ToString();
            checkAtivo.Checked = (bool)grupo.Ativo;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir um grupo selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    if (dataGridGrupo.SelectedRows.Count > 0)
                    {
                        var linhaSelecionada = dataGridGrupo.SelectedRows[0];
                        var grupoId = (int)linhaSelecionada.Cells["Id"].Value;
                        var gruposParaExclusao = dbConectionPdv.Grupos.FirstOrDefault(g => g.Id == grupoId);

                        if (gruposParaExclusao != null)
                        {
                            dbConectionPdv.Grupos.Remove(gruposParaExclusao);
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("Grupo excluído com sucesso!", "Sucesso", MessageBoxButtons.OK);
                            CarregarGridGrupos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione um grupo para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o grupo: " + ex.Message);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            GravarGrupo();
        }


        private void GravarGrupo()
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
                    if (string.IsNullOrWhiteSpace(textCod.Text))
                    {
                        // e um novo regitros

                        bool jaExistGrupo = dbConectionPdv.Grupos.Any(g => g.Nome == textNome.Text.Trim());
                        if (jaExistGrupo)
                        {
                            MessageBox.Show("Essa grupo ja existe", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            var grupo = new Grupo
                            {
                                Nome = textNome.Text,
                                Ativo = checkAtivo.Checked,

                            };

                            dbConectionPdv.Add(grupo);
                            dbConectionPdv.SaveChanges();

                            MessageBox.Show("Grupo salva com sucesso:", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textCod.Text = grupo.Id.ToString();
                            CarregarGridGrupos();
                            return;

                        }
                    }
                    else
                    {
                        int grupoId = int.Parse(textCod.Text);
                        var grupoParaEdicao = dbConectionPdv.Grupos.Find(grupoId);
                        if (grupoParaEdicao != null)
                        {
                            grupoParaEdicao.Nome = textNome.Text;
                            grupoParaEdicao.Ativo = checkAtivo.Checked;
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("Grupo atualizada  com sucesso:", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textCod.Text = grupoParaEdicao?.Id.ToString();
                            CarregarGridGrupos();
                            return;

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a grupo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabCadastro;
            textNome.ReadOnly = false;
            textNome.Focus();
            textCod.Clear();
            textNome.Clear();
            checkAtivo.Enabled = true;
        }
    }
}

