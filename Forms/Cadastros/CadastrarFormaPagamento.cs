using ServiTech.DbConection;
using ServiTech.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarFormaPagamento : Form
    {
        private readonly DbConection.DbConectionPdv dbConection;
        public CadastrarFormaPagamento(DbConectionPdv dbConectionPdv)
        {

            dbConection = dbConectionPdv;
            InitializeComponent();
        }





        private void LiberarCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {
            textNome.ReadOnly = false;
            textNome.Focus();
            textOperadora.ReadOnly = false;
            textTipo.ReadOnly = false;
            textTaxa.ReadOnly = false;
            checkAtivo.Enabled = true;
            checkedAceita.Enabled = true;

            textNome.Text = "";
            textTipo.Text = "";
            textOperadora.Text = "";
            textTaxa.Text = "0,00";
            checkAtivo.Checked = true;
            checkedAceita.Checked = false;
            textCod.Text = "";

        }

        private void LiberarCamposParaCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {
                textNome.ReadOnly = false;
                textNome.Focus();
                textOperadora.ReadOnly = false;
                textTipo.ReadOnly = false;
                textTaxa.ReadOnly = false;
                checkAtivo.Enabled = true;
                checkedAceita.Enabled = true;

                textNome.Text = "";
                textTipo.Text = "";
                textOperadora.Text = "";
                checkAtivo.Checked = false;
                checkedAceita.Checked = false;
                textCod.Text = "";


            }else if (e.KeyCode == Keys.F5)
            {
                this.GravarFormaPagamento();
            }
        }



        private void CadastrarFormaPagamento_Load(object sender, EventArgs e)
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
            CarregarFormasPagamento();
        }


        private void CarregarFormasPagamento()
        {

            try
            {
                // Obtém todos os países do banco
                var formasPagamento = dbConection.FormaPagamentos

                    .ToList();

                dataFormasPagamento.DataSource = formasPagamento;

                // ==== ESTILO DO CABEÇALHO ====
                dataFormasPagamento.EnableHeadersVisualStyles = false;
                dataFormasPagamento.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
                dataFormasPagamento.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataFormasPagamento.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dataFormasPagamento.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataFormasPagamento.ColumnHeadersHeight = 32;

                // ==== ESTILO DAS LINHAS ====
                dataFormasPagamento.DefaultCellStyle.BackColor = Color.White;
                dataFormasPagamento.DefaultCellStyle.ForeColor = Color.Black;
                dataFormasPagamento.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                dataFormasPagamento.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
                dataFormasPagamento.DefaultCellStyle.SelectionForeColor = Color.White;
                dataFormasPagamento.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                dataFormasPagamento.RowHeadersVisible = false;

                // ==== CONFIGURAÇÃO DAS COLUNAS ====
                dataFormasPagamento.Columns["Id"].HeaderText = "Código";
                dataFormasPagamento.Columns["Id"].Width = 80;
                dataFormasPagamento.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                dataFormasPagamento.Columns["PermiteParcelamento"].HeaderText = "Permiti Parçelamento";
                dataFormasPagamento.Columns["PermiteParcelamento"].Width = 250;
                dataFormasPagamento.Columns["PermiteParcelamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                dataFormasPagamento.Columns["Nome"].Width = 250;

                // ==== COMPORTAMENTO ====
                dataFormasPagamento.ReadOnly = true;
                dataFormasPagamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataFormasPagamento.MultiSelect = false;
                dataFormasPagamento.BorderStyle = BorderStyle.FixedSingle;
                dataFormasPagamento.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataFormasPagamento.GridColor = Color.FromArgb(220, 220, 220);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os forma de pagamento: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textDadosPesquisa_TextChanged(object sender, EventArgs e)
        {

            string filtro = comboFiltros.SelectedItem.ToString();
            string modelo = comboModelo.SelectedItem.ToString();
            string textoPesquisa = textDadosPesquisa.Text;
            var query = dbConection.FormaPagamentos.AsQueryable();
            if (string.IsNullOrEmpty(textoPesquisa))
            {
                CarregarFormasPagamento();
                return;
            }


            if (filtro == "Por Nome ")
            {
                if (modelo == "Inicia Com")
                {
                    query = query.Where(fp => fp.Nome.StartsWith(textoPesquisa));
                }
                else if (modelo == "Termina Com")
                {
                    query = query.Where(fp => fp.Nome.EndsWith(textoPesquisa));
                }
                else if (modelo == "Contem")
                {
                    query = query.Where(fp => fp.Nome.Contains(textoPesquisa));
                }
            }
            else if (filtro == "Por Codigo ")
            {
                if (int.TryParse(textoPesquisa, out int codigo))
                {
                    query = query.Where(fp => fp.Id == codigo);
                }
                else
                {
                    // Se a conversão falhar, retorna uma lista vazia
                    query = query.Where(fp => false);
                }
            }
            var resultadosFiltrados = query.ToList();
            dataFormasPagamento.DataSource = resultadosFiltrados;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataFormasPagamento.SelectedRows.Count > 0)
            {
                var selectedRow = dataFormasPagamento.SelectedRows[0];
                int formaPagamentoId = (int)selectedRow.Cells["Id"].Value;
                var formaPagamento = dbConection.FormaPagamentos.Find(formaPagamentoId);

                if (formaPagamento != null)
                {
                    this.AbrirAbaCadastro(formaPagamento.Id, formaPagamento.Nome, formaPagamento.Tipo, formaPagamento.Ativo, formaPagamento.PermiteParcelamento, formaPagamento.Banco, formaPagamento.Taxa);
                }

            }
            else
            {
                MessageBox.Show("Selecione uma forma de pagamento para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AbrirAbaCadastro(int id, string nome, string tipo, bool ativo, bool permiteParcelamento, string banco, decimal taxa)
        {
            tabControl.SelectedTab = tabCadastro;
            LiberarCamposParaCadastro_KeyDown(null, new KeyEventArgs(Keys.F4));
            textCod.Text = id.ToString();

            textNome.Text = nome;
            textTipo.Text = tipo;
            textOperadora.Text = banco;
            textTaxa.Text = taxa.ToString("F2");
            checkAtivo.Checked = ativo;
            checkedAceita.Checked = permiteParcelamento;
        }


        private void GravarFormaPagamento()
        {
            if (string.IsNullOrWhiteSpace(textNome.Text) || string.IsNullOrWhiteSpace(textTipo.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrWhiteSpace(textCod.Text))
            {
                // e novo registro
                var jaExiste = dbConection.FormaPagamentos.Any(fp => fp.Nome == textNome.Text);
                if (jaExiste)
                {
                    MessageBox.Show("Já existe uma forma de pagamento com esse nome. Por favor, escolha outro nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var novaFormaPagamento = new FormaPagamento
                    {
                        Nome = textNome.Text,
                        Tipo = textTipo.Text,
                        Ativo = checkAtivo.Checked,
                        PermiteParcelamento = checkedAceita.Checked,
                        Banco = textOperadora.Text,
                        Taxa = string.IsNullOrWhiteSpace(textTaxa.Text) ? 0 : decimal.Parse(textTaxa.Text.Replace("R$", ""), CultureInfo.GetCultureInfo("pt-BR"))
                    };
                    dbConection.FormaPagamentos.Add(novaFormaPagamento);


                    dbConection.SaveChanges();
                    MessageBox.Show("Forma de pagamento cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textCod.Text = novaFormaPagamento.Id.ToString();
                    CarregarFormasPagamento();
                    return;

                }
            }
            else
            {

                var formaPagamentoId = int.Parse(textCod.Text);
                var formaPagamento = dbConection.FormaPagamentos.Find(formaPagamentoId);
                if (formaPagamento != null)
                {
                    formaPagamento.Nome = textNome.Text;
                    formaPagamento.Tipo = textTipo.Text;
                    formaPagamento.Ativo = checkAtivo.Checked;
                    formaPagamento.PermiteParcelamento = checkedAceita.Checked;
                    formaPagamento.Banco = textOperadora.Text;
                    formaPagamento.Taxa = string.IsNullOrWhiteSpace(textTaxa.Text) ? 0 : decimal.Parse(textTaxa.Text.Replace("R$", ""), CultureInfo.GetCultureInfo("pt-BR"));
                    dbConection.SaveChanges();
                    MessageBox.Show("Forma de pagamento atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarFormasPagamento();
                    return;
                }
                else
                {
                    MessageBox.Show("Forma de pagamento não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.GravarFormaPagamento();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dataFormasPagamento.SelectedRows.Count > 0)
            {
                var selectedRow = dataFormasPagamento.SelectedRows[0];
                int formaPagamentoId = (int)selectedRow.Cells["Id"].Value;
                var formaPagamento = dbConection.FormaPagamentos.Find(formaPagamentoId);
                if (formaPagamento != null)
                {
                    var confirmResult = MessageBox.Show($"Tem certeza que deseja excluir a forma de pagamento '{formaPagamento.Nome}'?",
                                         "Confirmação de Exclusão",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            dbConection.FormaPagamentos.Remove(formaPagamento);
                            dbConection.SaveChanges();
                            CarregarFormasPagamento();
                            MessageBox.Show("Forma de pagamento excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao excluir a forma de pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma forma de pagamento para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma forma de pagamento para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            textNome.ReadOnly = false;
            textNome.Focus();
            textOperadora.ReadOnly = false;
            textTipo.ReadOnly = false;
            textTaxa.ReadOnly = false;
            checkAtivo.Enabled = true;
            checkedAceita.Enabled = true;

            textNome.Text = "";
            textTipo.Text = "";
            textOperadora.Text = "";
            checkAtivo.Checked = false;
            checkedAceita.Checked = false;
            textCod.Text = "";
        }

        private void MskararCampoMoeda_Changed(object sender, EventArgs e)
        {

            TextBox textBox = sender as TextBox;


            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string newText = new string(textBox.Text.Where(c => char.IsDigit(c)).ToArray());// Remove todos os caracteres que não são dígitos
                textBox.Text = newText;// Atualiza o texto da TextBox
                textBox.SelectionStart = textBox.Text.Length; // Coloca o cursor no final do texto
            }


            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string texto = textBox.Text.Replace("R$", "")
                                   .Replace(".", "")
                                   .Replace(",", "")
                                   .Trim();
                if (decimal.TryParse(texto, out decimal valor)) // tenta converter o texto para decimal
                {
                    textBox.TextChanged -= MskararCampoMoeda_Changed; // evita loop
                    textBox.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), "{0:C2}", valor / 100);// formata para moeda BRL
                    textBox.SelectionStart = textBox.Text.Length; // cursor no fim
                    textBox.TextChanged += MskararCampoMoeda_Changed; // reativa o evento
                }
            }

        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabCadastro;
            textNome.ReadOnly = false;
            textNome.Focus();
            textOperadora.ReadOnly = false;
            textTipo.ReadOnly = false;
            textTaxa.ReadOnly = false;
            checkAtivo.Enabled = true;
            checkedAceita.Enabled = true;

            textNome.Text = "";
            textTipo.Text = "";
            textOperadora.Text = "";
            checkAtivo.Checked = false;
            checkedAceita.Checked = false;
            textCod.Text = "";

        }
    }


}
