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
using ServiTech.Componentes.Services;

namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
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
                    HabilitarControles(page.Controls);
                }
            }
            else if (e.KeyCode == Keys.F12)

            {
                if (textCodBarra.ReadOnly == true)

                {
                    MessageBox.Show("Para gerar um código de barras, primeiro habilite os campos com F4", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                FrmGerarCodigoBarras frmGerador = new FrmGerarCodigoBarras();

                frmGerador.ShowDialog();

                if (!string.IsNullOrWhiteSpace(frmGerador.CodigoGerado))
                {
                    textCodBarra.Text = frmGerador.CodigoGerado;
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
                        textNomeProd.Focus();
                        break;

                    case ComboBox comboBox:
                        comboBox.Enabled = true;
                        break;

                    case Button button:
                        button.Enabled = true;
                        break;

                    case NumericUpDown numericUpDown:
                        numericUpDown.ReadOnly = false;
                        break;

                    case RadioButton radioButton:
                        radioButton.Enabled = true;
                        break;

                    case MaskedTextBox maskedTextBox:
                        maskedTextBox.ReadOnly = false;

                        break;


                    case GroupBox groupBox:
                        // chamada recursiva para liberar os controles internos
                        HabilitarControles(groupBox.Controls);
                        break;
                }
            }

            // campos que SEMPRE ficam bloqueados
            textCodForn.ReadOnly = true;
            textCodProd.ReadOnly = true;
            textPrecoVenda.ReadOnly = true;
            textCod.ReadOnly = true;
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

            textDataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textUltimaEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textUltimaSaida.Text = DateTime.Now.ToString("dd/MM/yyyy");


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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

    

