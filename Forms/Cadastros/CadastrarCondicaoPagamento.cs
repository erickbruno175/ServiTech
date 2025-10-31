using ServiTech.DbConection;
using ServiTech.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarCondicaoPagamento : Form
    {
        private readonly DbConection.DbConectionPdv dbConection;
        public CadastrarCondicaoPagamento(DbConectionPdv connection)
        {
            dbConection = connection;
            InitializeComponent();
        }



        private void CadastrarCondicaoPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                foreach (TabPage tab in tabControl1.TabPages)
                {
                    HabilitarControles(tab.Controls);
                }
            }
            else if (e.KeyCode == Keys.F5)
            {
                this.GravarCondicaoPagamento();
            }
        }
        private void HabilitarControles(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                switch (control)
                {
                    case TextBox textBox:
                        textNome.Focus();
                        textBox.Clear();
                        textCod.ReadOnly = true;
                        textBox.ReadOnly = false;
                        break;

                    case ComboBox comboBox:
                        comboBox.Enabled = true;
                        comboBox.SelectedIndex = -1;
                        break;

                    case MaskedTextBox maskedTextBox:
                        maskedTextBox.ReadOnly = false;
                        maskedTextBox.Clear();
                        break;

                    case RadioButton radioButton:
                        radioButton.Enabled = true;

                        break;

                    case Button button:
                        button.Enabled = true;
                        break;

                    case NumericUpDown numericUpDown:
                        numericUpDown.Enabled = true;
                        numericUpDown.Value = 0;
                        break;
                }

                // Se o controle tiver filhos (como GroupBox, Panel, etc.), chama de novo
                if (control.HasChildren)
                {
                    HabilitarControles(control.Controls);
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                HabilitarControles(tab.Controls);
            }
        }

        private void textJuro_TextChanged(object sender, EventArgs e)
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
                    textBox.TextChanged -= textJuro_TextChanged; // evita loop
                    textBox.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), "{0:C2}", valor / 100);// formata para moeda BRL
                    textBox.SelectionStart = textBox.Text.Length; // cursor no fim
                    textBox.TextChanged += textJuro_TextChanged; // reativa o evento
                }
            }
        }

        private void CadastrarCondicaoPagamento_Load(object sender, EventArgs e)
        {
            comboFiltros.Items.Add("Por Nome ");
            comboFiltros.Items.Add("Por Codigo ");

            comboFiltros.SelectedIndex = 1;
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;

            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.SelectedIndex = 1;
            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            CarregarCondicaoPagamento();
            CarregarFoermasPagamneto();


        }

        private void CarregarFoermasPagamneto()
        {
            try
            {

                var formasPagamentos = dbConection.FormaPagamentos
                    .ToList();
                comboFormasPagamento.DataSource = formasPagamentos;
                comboFormasPagamento.DisplayMember = "Nome";
                comboFormasPagamento.ValueMember = "Id";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as formas de pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarCondicaoPagamento()
        {
            //
            try
            {
                // Obtém todos os países do banco
                var condicoesPagamentos = dbConection.CondicaoPagamentos
                    .Select(cp => new
                    {
                        cp.Id,
                        cp.Nome,
                        cp.TaxaJuros,
                        cp.Ativo,
                        cp.Intervalo,
                        FormaPagamentoNome = cp.FormaPagamento.Nome


                    })

                    .ToList();

                dataCondicoesPagamento.DataSource = condicoesPagamentos;

                // ==== ESTILO DO CABEÇALHO ====
                dataCondicoesPagamento.EnableHeadersVisualStyles = false;
                dataCondicoesPagamento.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
                dataCondicoesPagamento.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataCondicoesPagamento.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dataCondicoesPagamento.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataCondicoesPagamento.ColumnHeadersHeight = 32;

                // ==== ESTILO DAS LINHAS ====
                dataCondicoesPagamento.DefaultCellStyle.BackColor = Color.White;
                dataCondicoesPagamento.DefaultCellStyle.ForeColor = Color.Black;
                dataCondicoesPagamento.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
                dataCondicoesPagamento.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
                dataCondicoesPagamento.DefaultCellStyle.SelectionForeColor = Color.White;
                dataCondicoesPagamento.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                dataCondicoesPagamento.RowHeadersVisible = false;

                // ==== CONFIGURAÇÃO DAS COLUNAS ====
                dataCondicoesPagamento.Columns["Id"].HeaderText = "Código";
                dataCondicoesPagamento.Columns["Id"].Width = 80;
                dataCondicoesPagamento.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                dataCondicoesPagamento.Columns["Nome"].HeaderText = "Nome ";
                dataCondicoesPagamento.Columns["Nome"].Width = 250;


                dataCondicoesPagamento.Columns["FormaPagamentoNome"].HeaderText = "Forma de Pagamento Associado ";
                dataCondicoesPagamento.Columns["FormaPagamentoNome"].Width = 300;
                // ==== COMPORTAMENTO ====
                dataCondicoesPagamento.ReadOnly = true;
                dataCondicoesPagamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataCondicoesPagamento.MultiSelect = false;
                dataCondicoesPagamento.BorderStyle = BorderStyle.FixedSingle;
                dataCondicoesPagamento.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataCondicoesPagamento.GridColor = Color.FromArgb(220, 220, 220);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as condições de pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GravarCondicaoPagamento()
        {

            try
            {
                // Validação do Nome
                if (string.IsNullOrWhiteSpace(textNome.Text) || comboFormasPagamento.SelectedValue == null)
                {
                    MessageBox.Show("O campo  é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textNome.Focus();
                    return;
                }

                // Verifica se estamos cadastrando ou atualizando
                if (string.IsNullOrWhiteSpace(textCod.Text))
                {
                    // Cadastro: verifica se já existe
                    bool existeCondicaoPagamento = dbConection.CondicaoPagamentos
                        .Any(cp => cp.Nome.ToLower() == textNome.Text.Trim().ToLower());

                    if (existeCondicaoPagamento)
                    {
                        MessageBox.Show("Já existe uma condição de pagamento com esse nome. Por favor, escolha outro nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textNome.Focus();
                        return;
                    }

                    // Criação de nova condição de pagamento
                    var novaCondicaoPagamento = new CondicaoPagamento
                    {
                        Nome = textNome.Text.Trim(),
                        TaxaJuros = string.IsNullOrWhiteSpace(textJuro.Text) ? 0 : decimal.Parse(textJuro.Text.Replace("R$", ""), CultureInfo.GetCultureInfo("pt-BR")),
                        Desconto = string.IsNullOrWhiteSpace(textDesconto.Text) ? 0 : decimal.Parse(textDesconto.Text.Replace("R$", ""), CultureInfo.GetCultureInfo("pt-BR")),
                        Intervalo = string.IsNullOrWhiteSpace(textIntervalo.Text) ? 0 : int.Parse(textIntervalo.Text),
                        NumeroParcela = string.IsNullOrWhiteSpace(textParcela.Text) ? 0 : int.Parse(textParcela.Text),
                        Ativo = checkAtivo.Checked,
                        FormaPagamentoId = (int)(comboFormasPagamento.SelectedValue != null ? (int?)comboFormasPagamento.SelectedValue : null)
                    };

                    dbConection.CondicaoPagamentos.Add(novaCondicaoPagamento);
                    dbConection.SaveChanges();

                    MessageBox.Show("Condição de pagamento cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textCod.Text = novaCondicaoPagamento.Id.ToString();
                    CarregarCondicaoPagamento();
                    return;
                }
                else
                {
                    // Atualização
                    var id = int.Parse(textCod.Text);
                    var condicaoPagamentoExistente = dbConection.CondicaoPagamentos.Find(id);

                    if (condicaoPagamentoExistente != null)
                    {
                        condicaoPagamentoExistente.Nome = textNome.Text.Trim();
                        condicaoPagamentoExistente.TaxaJuros = string.IsNullOrWhiteSpace(textJuro.Text) ? 0 : decimal.Parse(textJuro.Text.Replace("R$", ""), CultureInfo.GetCultureInfo("pt-BR"));
                        condicaoPagamentoExistente.Desconto = string.IsNullOrWhiteSpace(textDesconto.Text) ? 0 : decimal.Parse(textDesconto.Text.Replace("R$", ""), CultureInfo.GetCultureInfo("pt-BR"));
                        condicaoPagamentoExistente.Intervalo = string.IsNullOrWhiteSpace(textIntervalo.Text) ? 0 : int.Parse(textIntervalo.Text);
                        condicaoPagamentoExistente.NumeroParcela = string.IsNullOrWhiteSpace(textParcela.Text) ? 0 : int.Parse(textParcela.Text);
                        condicaoPagamentoExistente.Ativo = checkAtivo.Checked;
                        condicaoPagamentoExistente.FormaPagamentoId = (int)(comboFormasPagamento.SelectedValue != null ? (int?)comboFormasPagamento.SelectedValue : null);

                        dbConection.SaveChanges();

                        MessageBox.Show("Condição de pagamento atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarCondicaoPagamento();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Condição de pagamento não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a condição de pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.GravarCondicaoPagamento();
        }

        private void textDadosPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (comboFiltros.SelectedItem == null || comboModelo.SelectedItem == null)
                return;

            string filtro = comboFiltros.SelectedItem.ToString().Trim();
            string modelo = comboModelo.SelectedItem.ToString().Trim();
            string textoPesquisa = textDadosPesquisa.Text.Trim().ToLower();


            var query = dbConection.CondicaoPagamentos.AsQueryable();

            if (string.IsNullOrEmpty(textoPesquisa))
            {
                CarregarCondicaoPagamento();
                return;
            }

            if (!string.IsNullOrWhiteSpace(textoPesquisa))
            {
                if (filtro == "Por Nome")
                {
                    if (modelo == "Inicia Com")
                    {
                        query = query.Where(cp => cp.Nome.ToLower().StartsWith(textoPesquisa));
                    }
                    else if (modelo == "Termina Com")
                    {
                        query = query.Where(cp => cp.Nome.ToLower().EndsWith(textoPesquisa));
                    }
                    else if (modelo == "Contém" || modelo == "Contem") // aceita as duas grafias
                    {
                        query = query.Where(cp => cp.Nome.ToLower().Contains(textoPesquisa));
                    }
                }
                else if (filtro == "Por Código" || filtro == "Por Codigo")
                {
                    if (int.TryParse(textoPesquisa, out int codigo))
                    {
                        query = query.Where(cp => cp.Id == codigo);
                    }
                    else
                    {
                        // Retorna lista vazia caso não seja número válido
                        query = query.Where(cp => false);
                    }
                }
            }

            dataCondicoesPagamento.DataSource = query
                .Select(cp => new
                {
                    cp.Id,
                    cp.Nome,
                    cp.TaxaJuros,
                    cp.Ativo,
                    cp.Intervalo,
                    FormaPagamentoNome = cp.FormaPagamento.Nome
                })
                .ToList();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dataCondicoesPagamento.SelectedRows.Count > 0)
            {
                int id = (int)dataCondicoesPagamento.SelectedRows[0].Cells["Id"].Value;
                var condicaoPagamento = dbConection.CondicaoPagamentos.Find(id);
                AbrirAbaCadastro(condicaoPagamento);
            }
            else
            {
                MessageBox.Show("Selecione uma condição de pagamento para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void AbrirAbaCadastro(CondicaoPagamento condicaoPagamento)
        {
            tabControl1.SelectedTab = tabCadastros;
            foreach (TabPage tab in tabControl1.TabPages)
            {
                HabilitarControles(tab.Controls);
            }
            if (condicaoPagamento != null)
            {
                textCod.Text = condicaoPagamento.Id.ToString();
                textNome.Text = condicaoPagamento.Nome;
                textJuro.Text = condicaoPagamento.TaxaJuros.ToString("C2");
                textDesconto.Text = condicaoPagamento.Desconto.ToString("C2");
                textIntervalo.Text = condicaoPagamento.Intervalo.ToString();
                textParcela.Text = condicaoPagamento.NumeroParcela.ToString();
                checkAtivo.Checked = (bool)condicaoPagamento.Ativo;
                comboFormasPagamento.SelectedValue = condicaoPagamento.FormaPagamentoId;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {


            if (dataCondicoesPagamento.SelectedRows.Count > 0)
            {
                int id = (int)dataCondicoesPagamento.SelectedRows[0].Cells["Id"].Value;
                var condicaoPagamento = dbConection.CondicaoPagamentos.Find(id);
                var result = MessageBox.Show($"Tem certeza que deseja excluir a condição de pagamento '{condicaoPagamento.Nome}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        dbConection.CondicaoPagamentos.Remove(condicaoPagamento);
                        dbConection.SaveChanges();
                        MessageBox.Show("Condição de pagamento excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarCondicaoPagamento();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir a condição de pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma condição de pagamento para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabCadastros;
            foreach (TabPage tab in tabControl1.TabPages)
            {
                HabilitarControles(tab.Controls);
            }
        }
    }
}
