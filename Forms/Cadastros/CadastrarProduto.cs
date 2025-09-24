using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }



        private void tabPage1_Resize(object sender, EventArgs e)
        {
            btnBuscaForn.Location = new Point(tabPage1.Width - btnBuscaForn.Width - 9, btnBuscaForn.Location.Y);
            btnBuscaOriProduto.Location = new Point(tabPage1.Width - btnBuscaOriProduto.Width - 9, btnBuscaOriProduto.Location.Y);


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



        private void LiberaCamposParaCadastro_KeyDown(object sender, KeyEventArgs e)
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
                        }
                        else if (control is NumericUpDown numeric)
                        {
                            numeric.ReadOnly = false;
                        }
                        else if (control is Button button)
                        {
                            button.Enabled = true;
                        }
                        else if (control is GroupBox groupBox)
                        {
                            foreach (Control item in groupBox.Controls)
                            {
                                if (item is RadioButton radio)
                                {
                                    radio.Enabled = true;
                                }
                            }

                        }
                        else if (control is ComboBox comboBox)
                        {
                            comboBox.Enabled = true;
                        }
                    }

                    textCodBarra.Focus(); // foco apenas no principal

                    textCodProd.ReadOnly = true;

                    textCodCfop.ReadOnly = true;
                    textCodForn.ReadOnly = true;
                    textPrecoVenda.ReadOnly = true;
                    textCodCst.ReadOnly = true;
                    textCodOrigemProd.ReadOnly = true;



                }
            }

        }

        private void textMargemCalc_Leave(object sender, EventArgs e)
        {
            // Tenta ler o valor da margem
            bool margemOk = decimal.TryParse(
                textMargemCalc.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim(),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out decimal margem);

            // Tenta ler o valor de custo
            bool custoOk = decimal.TryParse(
                textPrecoCusto.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim(),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out decimal valorCusto);

            if (margemOk && custoOk)
            {
                decimal valorVendaCalculada = valorCusto + (valorCusto * (margem / 100));
                textPrecoVenda.Text = valorVendaCalculada.ToString("N2");
            }
            else
            {
                textPrecoVenda.Text = "0,00";
            }
        }

        private void CadastrarProduto_Load(object sender, EventArgs e)
        {
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Items.Add("Por Nome ");
            comboFiltros.Items.Add("Por Codigo ");
            comboFiltros.Items.Add("Por Codigo Barra ");
            comboFiltros.Items.Add("Por Fornecedor ");
            comboFiltros.Items.Add("Por Marca ");




            comboFiltros.SelectedIndex = 0;

            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.Items.Add("Exatamente");
            comboModelo.SelectedIndex = 0;
        }

        private void InserirImagem_Produto_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Arquivos CSV|*.csv|Todos os arquivos|*.*";
            openFileDialog1.Title = "Selecione o arquivo de produtos";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagem = openFileDialog1.FileName;
                pictureFotoProduto.ImageLocation = imagem;
                pictureFotoProduto.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

    

