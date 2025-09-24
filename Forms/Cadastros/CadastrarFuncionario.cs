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
    public partial class CadastrarFuncionario : Form
    {
        public CadastrarFuncionario()
        {
            InitializeComponent();
        }



        private void MaskaraCampoFreteMoeda(object sender, EventArgs e)
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
                if (decimal.TryParse(texto, out decimal valor))
                {
                    textBox.TextChanged -= MaskaraCampoFreteMoeda; // evita loop
                    textBox.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), "{0:C2}", valor / 100);// formata para moeda BRL
                    textBox.SelectionStart = textBox.Text.Length; // cursor no fim
                    textBox.TextChanged += MaskaraCampoFreteMoeda;
                }
            }
        }

        private void LiberarCamposParaNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {

                foreach (TabPage page in tabControl1.TabPages)
                {
                    foreach (Control control in page.Controls)
                    {


                        if (control is TextBox textBox)
                        {
                            textBox.ReadOnly = false;
                            textNome.Focus();
                            textNome.SelectionStart = textNome.TextLength;
                            textCodigo.ReadOnly = true;
                            
                        }

                        if (control is MaskedTextBox maskedTextBox)
                        {
                            maskedTextBox.ReadOnly = false;
                        }
                        if (control is ComboBox comboBox)
                        {
                            comboBox.Enabled = true;
                        }


                        if (control is GroupBox groupBox)
                        {
                            foreach (Control rbControl in groupBox.Controls)
                            {
                                if (rbControl is RadioButton radioButton)
                                {
                                    radioButton.Enabled = true;
                                }
                                if (rbControl is MaskedTextBox maskedTextBoxGroup)
                                {
                                    maskedTextBoxGroup.ReadOnly = false;
                                }

                                if (rbControl is TextBox textBoxGroup)
                                {
                                    textBoxGroup.ReadOnly = false;
                                }
                                if (rbControl is ComboBox comboBoxGroup)
                                {
                                    comboBoxGroup.Enabled = true;
                                }
                            }
                        }

                    }
                }



            }
        }
    }
}
