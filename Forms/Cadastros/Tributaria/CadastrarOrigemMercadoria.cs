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
    public partial class CadastrarOrigemMercadoria : Form
    {
        private readonly DbConectionPdv dbConectionPdv = new DbConectionPdv();
        public CadastrarOrigemMercadoria()
        {
            InitializeComponent();
        }



        private void CadastrarOrigemMercadoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                // limpar os campos e habilitar a edição
                textCodRegra.ReadOnly = false;
                textNome.ReadOnly = false;
                textNome.Focus();
                textCodRegra.Clear();
                textNome.Clear();
                textCod.Clear();
            }
            else if (e.KeyCode == Keys.F5)
            {
                this.GravarOrigem();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // limpar os campos e habilitar a edição
            textCodRegra.ReadOnly = false;
            textNome.ReadOnly = false;
            textNome.Focus();
            textCodRegra.Clear();
            textNome.Clear();
            textCod.Clear();
        }

        private void CadastrarOrigemMercadoria_Load(object sender, EventArgs e)
        {

            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Items.Add("Por Nome ");
            comboFiltros.Items.Add("Por Codigo  de Origem ");
            comboFiltros.SelectedIndex = 0;

            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.SelectedIndex = 0;

            CarregarOrigemMercadoria();
        }


        private void CarregarOrigemMercadoria()
        {
            try
            {
                var origemMercadoria = dbConectionPdv.OrigemMercadorias

                    .ToList();

                gridOrigem.DataSource = origemMercadoria;

                // ==== ESTILO DO CABEÇALHO ====
                gridOrigem.EnableHeadersVisualStyles = false;
                gridOrigem.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
                gridOrigem.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gridOrigem.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                gridOrigem.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gridOrigem.ColumnHeadersHeight = 32;

                // ==== ESTILO DAS LINHAS ====
                gridOrigem.DefaultCellStyle.BackColor = Color.White;
                gridOrigem.DefaultCellStyle.ForeColor = Color.Black;
                gridOrigem.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                gridOrigem.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
                gridOrigem.DefaultCellStyle.SelectionForeColor = Color.White;
                gridOrigem.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                gridOrigem.RowHeadersVisible = false;

                // ==== CONFIGURAÇÃO DAS COLUNAS ====
                gridOrigem.Columns["Codigo"].HeaderText = "Código de Origem";
                gridOrigem.Columns["Codigo"].Width = 150;
                gridOrigem.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                gridOrigem.Columns["Id"].HeaderText = "Código ";
                gridOrigem.Columns["Id"].Width = 80;
                gridOrigem.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                gridOrigem.Columns["Descricao"].HeaderText = "Descrição";
                gridOrigem.Columns["Descricao"].Width = 500;
                gridOrigem.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;



                // ==== COMPORTAMENTO ====
                gridOrigem.ReadOnly = true;
                gridOrigem.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona linha inteira
                gridOrigem.MultiSelect = false; // Só uma linha por vez
                gridOrigem.BorderStyle = BorderStyle.FixedSingle;
                gridOrigem.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                gridOrigem.GridColor = Color.FromArgb(220, 220, 220);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os origem mercadoria: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (gridOrigem.SelectedRows.Count > 0)
            {
                var selectedRow = gridOrigem.SelectedRows[0];
                var origemId = selectedRow.Cells["Codigo"].Value.ToString();
                var origem = dbConectionPdv.OrigemMercadorias
                    .FirstOrDefault(o => o.Codigo == origemId);
                AbaCadastroOrigem(origem);
            }
            else
            {
                MessageBox.Show("Selecione uma origem mercadoria para editar.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void AbaCadastroOrigem(OrigemMercadoria origemMercadoria)
        {
            tabControl1.SelectedTab = tabCadastro;
            textCodRegra.Text = origemMercadoria.Codigo;
            textNome.Text = origemMercadoria.Descricao;
            textCod.Text = origemMercadoria.Id.ToString();
            // Permitir edição do campo Nome
            textCodRegra.ReadOnly = false;
            textNome.ReadOnly = false;
            textNome.Focus();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (gridOrigem.SelectedRows.Count > 0)
            {
                var selectedRow = gridOrigem.SelectedRows[0];
                var origemId = selectedRow.Cells["Codigo"].Value.ToString();
                var origem = dbConectionPdv.OrigemMercadorias
                    .FirstOrDefault(o => o.Codigo == origemId);
                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir a origem mercadoria: " +
                    origem.Descricao + " ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        dbConectionPdv.OrigemMercadorias.Remove(origem);
                        dbConectionPdv.SaveChanges();
                        MessageBox.Show("Origem mercadoria excluída com sucesso!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarOrigemMercadoria();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir a origem mercadoria: " + ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma origem mercadoria para excluir.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textDadosPesquisa_TextChanged(object sender, EventArgs e)
        {

            var filtroSelecionado = comboFiltros.SelectedItem.ToString();
            var modeloSelecionado = comboModelo.SelectedItem.ToString();
            var textoPesquisa = textDadosPesquisa.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(textoPesquisa))
            {
                CarregarOrigemMercadoria();
                return;
            }

            var query = dbConectionPdv.OrigemMercadorias.AsQueryable();

            if (filtroSelecionado == "Por Nome ")
            {
                if (modeloSelecionado == "Inicia Com")
                {
                    query = query.Where(o => o.Descricao.ToLower().StartsWith(textoPesquisa));
                }
                else if (modeloSelecionado == "Termina Com")
                {
                    query = query.Where(o => o.Descricao.ToLower().EndsWith(textoPesquisa));
                }
                else if (modeloSelecionado == "Contem")
                {
                    query = query.Where(o => o.Descricao.ToLower().Contains(textoPesquisa));
                }
            }
            else if (filtroSelecionado == "Por Codigo  de Origem ")
            {
                if (modeloSelecionado == "Inicia Com")
                {
                    query = query.Where(o => o.Codigo.ToLower().StartsWith(textoPesquisa));
                }
                else if (modeloSelecionado == "Termina Com")
                {
                    query = query.Where(o => o.Codigo.ToLower().EndsWith(textoPesquisa));
                }
                else if (modeloSelecionado == "Contem")
                {
                    query = query.Where(o => o.Codigo.ToLower().Contains(textoPesquisa));
                }
            }

            var resultados = query.ToList();
            gridOrigem.DataSource = resultados;

        }

        private void GravarOrigem()
        {

            try
            {
                if (string.IsNullOrWhiteSpace(textCodRegra.Text) || string.IsNullOrWhiteSpace(textNome.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(textCod.Text))
                {
                    // Novo registro
                    var novaOrigem = new OrigemMercadoria
                    {
                        Codigo = textCodRegra.Text.Trim(),
                        Descricao = textNome.Text.Trim()
                    };
                    dbConectionPdv.OrigemMercadorias.Add(novaOrigem);
                    dbConectionPdv.SaveChanges();
                    MessageBox.Show("Origem mercadoria salvo com sucesso!", "Sucesso",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textCod.Text = novaOrigem.Id.ToString();
                    CarregarOrigemMercadoria();
                    return;
                }
                else
                {
                    // Edição de registro existente
                    var origemId = int.Parse(textCod.Text);
                    var origemExistente = dbConectionPdv.OrigemMercadorias
                        .FirstOrDefault(o => o.Id == origemId);
                    if (origemExistente != null)
                    {
                        origemExistente.Codigo = textCodRegra.Text.Trim();
                        origemExistente.Descricao = textNome.Text.Trim();
                        dbConectionPdv.OrigemMercadorias.Update(origemExistente);
                        dbConectionPdv.SaveChanges();
                        MessageBox.Show("Origem mercadoria atualizada com sucesso!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarOrigemMercadoria();
                        return;
                    }
                }
                // Limpar e bloquear os campos após salvar

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a origem mercadoria: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.GravarOrigem();

        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabCadastro;
            textCodRegra.ReadOnly = false;
            textNome.ReadOnly = false;
            textNome.Focus();
            textCodRegra.Clear();
            textNome.Clear();
            textCod.Clear();
        }
    }
}
