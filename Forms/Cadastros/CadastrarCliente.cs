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
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }




        private void DefinirMascaraCpfCnpj_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonPessaoJuridica.Checked)
            {
                textCpfCnpj.Mask = "00.000.000/0000-00";
                labelCpfCnpj.Text = "CNPJ";
            }
            if (radioButtonPessoaFisica.Checked)
            {
                textCpfCnpj.Mask = "000.000.000-00";
                labelCpfCnpj.Text = "CPF";
            }
        }

        private void CarregarCombosConsultas()
        {
            // Preenche modelo
            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.Items.Add("Exatamente");
            comboModelo.SelectedIndex = 0; // seleciona primeiro item
            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelo.Select();

            comboFiltros.Items.Add("Nome");
            comboFiltros.Items.Add("CPF");
            comboFiltros.Items.Add("CNPJ");
            comboFiltros.Items.Add("Telefone");
            comboFiltros.Items.Add("Email");
            comboFiltros.Items.Add("Bairro");
            comboFiltros.Items.Add("Cidade");
            comboFiltros.Items.Add("Estado");
            comboFiltros.Items.Add("Ativos");
            comboFiltros.Items.Add("Inativos");
            comboFiltros.SelectedIndex = 0;
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Select();

            // Define foco inicial no combo que você quer que fique azul
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

            CarregarCombosConsultas();

        }

        private void LiberararCamposParaNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.F4)
            {
                foreach (TabPage tab in tabControl1.TabPages)
                {
                    HabilitarControles(tab.Controls);
                }
            }
        }

        private void HabilitarControles(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                switch (control)
                {
                    case TextBox textBox:
                        textBox.ReadOnly = false;
                        textNomeCliente.Focus();
                        radioButtonPessaoJuridica.Checked = true;
                        textCod.ReadOnly = true;
                        
                        break;

                    case ComboBox comboBox:
                        comboBox.Enabled = true;
                        break;

                    case MaskedTextBox maskedTextBox:
                        maskedTextBox.ReadOnly = false;
                        break;

                    case RadioButton radioButton:
                        radioButton.Enabled = true;
                        break;

                    case Button button:
                        button.Enabled = true;
                        break;
                }

                // Se o controle tiver filhos (como GroupBox, Panel, etc.), chama de novo
                if (control.HasChildren)
                {
                    HabilitarControles(control.Controls);
                }
            }
        }

        private void LiberararCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {

            foreach (TabPage tab in tabControl1.TabPages)
            {
                HabilitarControles(tab.Controls);
            }
        }

        private void FeicharTelaCadastroCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void groupBox5_Resize(object sender, EventArgs e)
        {
            btnPesquisar.Location = new Point(groupBox5.Width - btnPesquisar.Width - 9, btnPesquisar.Location.Y);
            checkBoxCarregarTodos.Location = new Point(groupBox5.Width - checkBoxCarregarTodos.Width - 9, checkBoxCarregarTodos.Location.Y);
        }

        private void MaskaraCampoMoeda_TextChanged(object sender, EventArgs e)
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
                    textBox.TextChanged -= MaskaraCampoMoeda_TextChanged; // evita loop
                    textBox.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), "{0:C2}", valor / 100);// formata para moeda BRL
                    textBox.SelectionStart = textBox.Text.Length; // cursor no fim
                    textBox.TextChanged += MaskaraCampoMoeda_TextChanged; // reativa o evento
                }
            }

        }
    }
}
