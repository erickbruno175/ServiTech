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
    public partial class CadastrarCondicaoPagamento : Form
    {
        public CadastrarCondicaoPagamento()
        {
            InitializeComponent();
        }

        private void groupBox3_Resize(object sender, EventArgs e)
        {
            btnPesquisar.Location = new Point(groupBox3.Width - btnPesquisar.Width - 9, btnPesquisar.Location.Y);
            checkBoxTodos.Location = new Point(groupBox3.Width - checkBoxTodos.Width - 9, checkBoxTodos.Location.Y);
        }

        private void CadastrarCondicaoPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                HabilitarControles(tab.Controls);
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
                        textCod.ReadOnly = true;
                        textCodFormaPag.ReadOnly = true;
                        textBox.ReadOnly = false;
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
    }
}
