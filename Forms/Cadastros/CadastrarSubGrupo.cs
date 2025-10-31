using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using ServiTech.DbConection;
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

namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarSubGrupo : Form
    {

        private readonly DbConectionPdv dbConectionPdv;
        public CadastrarSubGrupo()
        {
            dbConectionPdv = new DbConectionPdv();
            InitializeComponent();
        }



        private void CadastrarSubGrupo_Load(object sender, EventArgs e)
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
            CarregarGridSubGrupos();
            CarregarComboGrupo();

        }



        private void CarregarGridSubGrupos()
        {
            try
            {
                // Obtém todos os países do banco
                var subGrupo = dbConectionPdv.SubGrupos
                    .Include(x => x.Grupo)
                    .OrderBy(sg => sg.Id).Select(sg => new
                    {
                        sg.Id,
                        sg.Nome,
                        sg.Ativo,
                        Grupo = sg.Grupo.Nome,
                        IdGrupo = sg.Grupo.Id

                    })

                    .ToList();

                dataGridSubGrupo.DataSource = subGrupo;

                // ==== ESTILO DO CABEÇALHO ====
                dataGridSubGrupo.EnableHeadersVisualStyles = false;
                dataGridSubGrupo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
                dataGridSubGrupo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridSubGrupo.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dataGridSubGrupo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridSubGrupo.ColumnHeadersHeight = 32;

                // ==== ESTILO DAS LINHAS ====
                dataGridSubGrupo.DefaultCellStyle.BackColor = Color.White;
                dataGridSubGrupo.DefaultCellStyle.ForeColor = Color.Black;
                dataGridSubGrupo.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                dataGridSubGrupo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
                dataGridSubGrupo.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridSubGrupo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                dataGridSubGrupo.RowHeadersVisible = false;

                // ==== CONFIGURAÇÃO DAS COLUNAS ====
                dataGridSubGrupo.Columns["Id"].HeaderText = "Código";
                dataGridSubGrupo.Columns["Id"].Width = 80;
                dataGridSubGrupo.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridSubGrupo.Columns["Nome"].HeaderText = "Descrição";
                dataGridSubGrupo.Columns["Nome"].Width = 300;

                dataGridSubGrupo.Columns["IdGrupo"].HeaderText = "Codigo Grupo";

                dataGridSubGrupo.Columns["IdGrupo"].Width = 150;

                dataGridSubGrupo.Columns["Grupo"].HeaderText = "Grupo Perteçente";

                dataGridSubGrupo.Columns["Grupo"].Width = 450;




                // ==== COMPORTAMENTO ====
                dataGridSubGrupo.ReadOnly = true;
                dataGridSubGrupo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridSubGrupo.MultiSelect = false;
                dataGridSubGrupo.BorderStyle = BorderStyle.FixedSingle;
                dataGridSubGrupo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridSubGrupo.GridColor = Color.FromArgb(220, 220, 220);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar subgrupo : " + ex.Message,
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

                IQueryable<Model.ModelGrupo.SubGrupo> query = dbConectionPdv.SubGrupos.AsQueryable();

                if (string.IsNullOrWhiteSpace(campoDados))
                {
                    CarregarGridSubGrupos();
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


                var resultado = query.Include(x => x.Grupo)
                    .OrderBy(sg => sg.Id).Select(sg => new
                    {
                        sg.Id,
                        sg.Nome,
                        sg.Ativo,
                        Grupo = sg.Grupo.Nome,
                        IdGrupo = sg.Grupo.Id

                    })

                    .ToList();
                dataGridSubGrupo.DataSource = resultado;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao fazer a consulta:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void CadastrarSubGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                textNome.ReadOnly = false;
                textNome.Focus();
                checkAtivo.Enabled = true;

                textCod.Clear();
                textNome.Clear();
                comboGrupos.Enabled = true;

            }else if (e.KeyCode == Keys.F5)
            {
                this.GravarSubGrupo();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            textNome.ReadOnly = false;
            textNome.Focus();
            checkAtivo.Enabled = true;

            textCod.Clear();
            textNome.Clear();
            comboGrupos.Enabled = true;




        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            GravarSubGrupo();
        }


        private void GravarSubGrupo()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textNome.Text) || string.IsNullOrWhiteSpace(comboGrupos.Text))
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

                        bool jaExistSubGrupo = dbConectionPdv.SubGrupos.Any(sg => sg.Nome == textNome.Text.Trim());
                        if (jaExistSubGrupo)
                        {
                            MessageBox.Show("Essa subgrupo ja existe", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            var subGrupo = new SubGrupo
                            {
                                Nome = textNome.Text,
                                Ativo = checkAtivo.Checked,
                                GrupoId = (int)comboGrupos.SelectedValue

                            };

                            dbConectionPdv.Add(subGrupo);
                            dbConectionPdv.SaveChanges();

                            MessageBox.Show("SubGrupo salva com sucesso:", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textCod.Text = subGrupo.Id.ToString();
                            CarregarGridSubGrupos();
                            return;

                        }
                    }
                    else
                    {
                        int subGrupoId = int.Parse(textCod.Text);
                        var subGrupoParaEdicao = dbConectionPdv.SubGrupos.Find(subGrupoId);
                        if (subGrupoParaEdicao != null)
                        {
                            subGrupoParaEdicao.Nome = textNome.Text;
                            subGrupoParaEdicao.Ativo = checkAtivo.Checked;
                            subGrupoParaEdicao.GrupoId = (int)comboGrupos.SelectedValue;
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("SubGrupo atualizada  com sucesso:", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textCod.Text = subGrupoParaEdicao.Id.ToString();
                            CarregarGridSubGrupos();
                            return;

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a subgrupo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir um subgrupo selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    if (dataGridSubGrupo.SelectedRows.Count > 0)
                    {
                        var linhaSelecionada = dataGridSubGrupo.SelectedRows[0];
                        var subGrupoId = (int)linhaSelecionada.Cells["Id"].Value;
                        var subGrupoIdParaExclusao = dbConectionPdv.SubGrupos.FirstOrDefault(sg => sg.Id == subGrupoId);

                        if (subGrupoIdParaExclusao != null)
                        {
                            dbConectionPdv.SubGrupos.Remove(subGrupoIdParaExclusao);
                            dbConectionPdv.SaveChanges();
                            MessageBox.Show("SubGrupo excluído com sucesso!", "Sucesso", MessageBoxButtons.OK);
                            CarregarGridSubGrupos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione um subgrupo para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir  o subgrupo: " + ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void CarregarComboGrupo()
        {
            comboGrupos.DataSource = dbConectionPdv.Grupos.OrderBy(g => g.Nome).ToList();
            comboGrupos.DisplayMember = "Nome";
            comboGrupos.ValueMember = "Id";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridSubGrupo.Rows.Count > 0)
            {
                try
                {
                    int subGrupoId = (int)dataGridSubGrupo.SelectedRows[0].Cells["Id"].Value;
                    SubGrupo subGrupo = dbConectionPdv.SubGrupos.Find(subGrupoId);
                    if (subGrupo != null)
                    {
                        AbrirAbaCadastro(subGrupo);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ao  consultar subgrupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Selecione um registro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AbrirAbaCadastro(SubGrupo subGrupo)
        {
            tabControl1.SelectedTab = tabCadastro;
            textCod.Text = subGrupo.Id.ToString();
            textNome.Text = subGrupo.Nome;
            checkAtivo.Checked = subGrupo.Ativo;
            comboGrupos.Text = subGrupo.Grupo.Nome;



            textNome.ReadOnly = false;
            textNome.Focus();
            checkAtivo.Enabled = true;
            comboGrupos.Enabled = true;
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabCadastro;
            textNome.ReadOnly = false;
            textNome.Focus();
            textCod.Clear();
        }
    }
}
