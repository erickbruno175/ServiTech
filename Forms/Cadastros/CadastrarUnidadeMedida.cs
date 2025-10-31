using ServiTech.DbConection;
using ServiTech.Model;
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
    public partial class CadastrarUnidadeMedida : Form
    {
        private readonly DbConection.DbConectionPdv dbConectionPdv;
        public CadastrarUnidadeMedida(DbConectionPdv dbConectionPdv)
        {
            this.dbConectionPdv = dbConectionPdv;
            InitializeComponent();
        }



        private void LiberarCamposParaCadastro_Click(object sender, EventArgs e)
        {

            textDescricao.ReadOnly = false;
            textDescricao.Clear();
            textCod.Clear();
            textDescricao.Focus();

        }

        private void LiberarCampoParaCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {
                textDescricao.ReadOnly = false;
                textDescricao.Clear();
                textCod.Clear();
                textDescricao.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                this.GravarUnidadeMedida();
            }
        }

        private void CadastrarUnidadeMedida_Load(object sender, EventArgs e)
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
            CarregarUnidadeMedida();
        }

        private void CarregarUnidadeMedida()
        {
            //Carregar Unidade de Medida

            try
            {
                var unidadesMedidas = dbConectionPdv.UnidadeMedidas
                   .OrderBy(um => um.Id)
                   .Select(um => new
                   {
                       Codigo = um.Id,
                       Nome = um.Nome
                   })
                   .ToList();

                dataGridUnidadeMedida.DataSource = unidadesMedidas;

                // ==== ESTILO DO CABEÇALHO ====
                dataGridUnidadeMedida.EnableHeadersVisualStyles = false;
                dataGridUnidadeMedida.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
                dataGridUnidadeMedida.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridUnidadeMedida.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dataGridUnidadeMedida.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridUnidadeMedida.ColumnHeadersHeight = 32;

                // ==== ESTILO DAS LINHAS ====
                dataGridUnidadeMedida.DefaultCellStyle.BackColor = Color.White;
                dataGridUnidadeMedida.DefaultCellStyle.ForeColor = Color.Black;
                dataGridUnidadeMedida.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                dataGridUnidadeMedida.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
                dataGridUnidadeMedida.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridUnidadeMedida.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                dataGridUnidadeMedida.RowHeadersVisible = false;

                // ==== CONFIGURAÇÃO DAS COLUNAS ====
                dataGridUnidadeMedida.Columns["Codigo"].HeaderText = "Código";
                dataGridUnidadeMedida.Columns["Codigo"].Width = 80;
                dataGridUnidadeMedida.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridUnidadeMedida.Columns["Nome"].Width = 250;

                // ==== COMPORTAMENTO ====
                dataGridUnidadeMedida.ReadOnly = true;
                dataGridUnidadeMedida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridUnidadeMedida.MultiSelect = false;
                dataGridUnidadeMedida.BorderStyle = BorderStyle.FixedSingle;
                dataGridUnidadeMedida.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridUnidadeMedida.GridColor = Color.FromArgb(220, 220, 220);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Unidade de Medida: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dataGridUnidadeMedida.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridUnidadeMedida.SelectedRows[0];
                int unidadeMedidaId = Convert.ToInt32(selectedRow.Cells["Codigo"].Value);
                var unidadeMedida = dbConectionPdv.UnidadeMedidas.Find(unidadeMedidaId);

                AbrirAbaCadastro(unidadeMedida);

            }
            else
            {
                MessageBox.Show("Selecione uma Unidade de Medida para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AbrirAbaCadastro(UnidadeMedida unidadeMedida)
        {
            tabControl1.SelectedTab = tabCadastro;

            textDescricao.Text = unidadeMedida.Nome;
            textCod.Text = unidadeMedida.Id.ToString();
            textDescricao.ReadOnly = false;

        }



        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dataGridUnidadeMedida.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridUnidadeMedida.SelectedRows[0];
                int unidadeMedidaId = Convert.ToInt32(selectedRow.Cells["Codigo"].Value);
                var unidadeMedida = dbConectionPdv.UnidadeMedidas.Find(unidadeMedidaId);
                var confirmResult = MessageBox.Show($"Tem certeza que deseja excluir a Unidade de Medida '{unidadeMedida.Nome}'?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        dbConectionPdv.UnidadeMedidas.Remove(unidadeMedida);
                        dbConectionPdv.SaveChanges();
                        CarregarUnidadeMedida();
                        MessageBox.Show("Unidade de Medida excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir Unidade de Medida: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma Unidade de Medida para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void GravarUnidadeMedida()
        {
            if (string.IsNullOrWhiteSpace(textDescricao.Text))
            {
                MessageBox.Show("O campo Descrição é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textDescricao.Focus();
                return;
            }



            if (string.IsNullOrWhiteSpace(textCod.Text))
            {
                if (dbConectionPdv.UnidadeMedidas.Any(um => um.Nome == textDescricao.Text.Trim()))
                {
                    MessageBox.Show("Já existe uma Unidade de Medida com essa descrição.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textDescricao.Focus();
                    return;
                }
                else
                {

                    // Novo Cadastro
                    var novaUnidadeMedida = new UnidadeMedida
                    {
                        Nome = textDescricao.Text.Trim()
                    };
                    try
                    {
                        dbConectionPdv.UnidadeMedidas.Add(novaUnidadeMedida);
                        dbConectionPdv.SaveChanges();
                        MessageBox.Show("Unidade de Medida cadastrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textCod.Text = novaUnidadeMedida.Id.ToString();
                        CarregarUnidadeMedida();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar Unidade de Medida: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Edição
                int unidadeMedidaId = Convert.ToInt32(textCod.Text);
                var unidadeMedidaExistente = dbConectionPdv.UnidadeMedidas.Find(unidadeMedidaId);
                if (unidadeMedidaExistente != null)
                {
                    unidadeMedidaExistente.Nome = textDescricao.Text.Trim();
                    try
                    {
                        dbConectionPdv.SaveChanges();
                        MessageBox.Show("Unidade de Medida atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarUnidadeMedida();

                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar Unidade de Medida: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Unidade de Medida não encontrada para atualização.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.GravarUnidadeMedida();
        }

        private void textDadosPesquisa_TextChanged(object sender, EventArgs e)
        {


            string filtro = textDadosPesquisa.Text.Trim().ToLower();
            var query = dbConectionPdv.UnidadeMedidas.AsQueryable();
            if (comboFiltros.SelectedItem.ToString() == "Por Nome ")
            {
                switch (comboModelo.SelectedItem.ToString())
                {
                    case "Inicia Com":
                        query = query.Where(um => um.Nome.ToLower().StartsWith(filtro));
                        break;
                    case "Termina Com":
                        query = query.Where(um => um.Nome.ToLower().EndsWith(filtro));
                        break;
                    case "Contem":
                        query = query.Where(um => um.Nome.ToLower().Contains(filtro));
                        break;
                    case "Exatamente":
                        query = query.Where(um => um.Nome.ToLower() == filtro);
                        break;
                }
            }
            else if (comboFiltros.SelectedItem.ToString() == "Por Codigo ")
            {
                if (int.TryParse(filtro, out int codigo))
                {
                    query = query.Where(um => um.Id == codigo);
                }
                else
                {
                    query = query.Where(um => false); // Nenhum resultado se o filtro não for um número válido
                }
            }
            var resultadosFiltrados = query
                .OrderBy(um => um.Id)
                .Select(um => new
                {
                    Codigo = um.Id,
                    Nome = um.Nome
                })
                .ToList();
            dataGridUnidadeMedida.DataSource = resultadosFiltrados;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            textDescricao.ReadOnly = false;
            textDescricao.Clear();
            textCod.Clear();
            textDescricao.Focus();
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabCadastro;

            textDescricao.ReadOnly = false;
            textDescricao.Clear();
            textCod.Clear();
            textDescricao.Focus();
        }
    }



}
