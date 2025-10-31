using ServiTech.Caixa.Operacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ServiTech.Caixa
{
    public partial class Pdv : Form
    {
        private readonly System.Windows.Forms.Timer timer;
        private string textoOriginal = "Bem - vindo  ao UniPDV " +
            "";
        private int indiceAtual = 0;

        public Pdv()
        {
            InitializeComponent();
            textBoxTitulo.Text = textoOriginal;
            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = 500;
            this.timer.Tick += Time_Tick;
            this.timer.Start();
        }

        private void panel3_Resize(object sender, EventArgs e)
        {
            painelGridProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void CarregarMarcaDgua_Paint(object sender, PaintEventArgs e)
        {
            Image watermark = Properties.Resources.marca_dagua;

            // 🔹 Define a largura desejada (exemplo: 200px)
            int targetWidth = 600;
            // 🔹 Mantém a proporção da imagem
            int targetHeight = (int)((double)watermark.Height / watermark.Width * targetWidth);

            // 🔹 Centraliza no DataGridView
            int x = (gridItensVendas.Width - targetWidth) / 2;
            int y = (gridItensVendas.Height - targetHeight) / 2;

            // 🔹 Desenha redimensionada
            e.Graphics.DrawImage(watermark, new Rectangle(x, y, targetWidth, targetHeight)); // 
        }

        private void textTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            labelDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " : ";
            indiceAtual++;
            if (indiceAtual >= textoOriginal.Length)
                indiceAtual = 0;

            // faz o texto “andar”
            string textoRolando = textoOriginal.Substring(indiceAtual) + textoOriginal.Substring(0, indiceAtual);
            textBoxTitulo.Text = textoRolando;
        }




        private void SairPdv_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void textReadCodProduto_Enter(object sender, EventArgs e)

        {

            textCodProduto.Clear();
        }

        private void textReadCodProduto_TextChanged(object sender, EventArgs e)
        {



            if (!string.IsNullOrEmpty(textCodProduto.Text))
            {
                string newText = new string(textCodProduto.Text.Where(c => char.IsDigit(c)).ToArray());// Remove todos os caracteres que não são dígitos
                textCodProduto.Text = newText;// Atualiza o texto da TextBox
                textCodProduto.SelectionStart = textCodProduto.Text.Length; // Coloca o cursor no final do texto
            }
        }

        private void CapturaTecla(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {

            }
            else if (e.KeyCode == Keys.F2)
            {
                OperacaoConsultarProduto operacaoConsultarProduto = new OperacaoConsultarProduto();
                operacaoConsultarProduto.ShowDialog();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Image watermark = Properties.Resources.marca;

            // 🔹 Define a largura desejada (exemplo: 200px)
            int targetWidth = 150;
            // 🔹 Mantém a proporção da imagem
            int targetHeight = (int)((double)watermark.Height / watermark.Width * targetWidth);

            // 🔹 Centraliza no DataGridView
            int x = (pictureLogo.Width - targetWidth) / 2;
            int y = (pictureLogo.Height - targetHeight) / 2;

            // 🔹 Desenha redimensionada
            e.Graphics.DrawImage(watermark, new Rectangle(x, y, targetWidth, targetHeight)); // 
        }

        private void MskararCampoMoeda_Changed(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;


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


        private void textReadTotalPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textTotal_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void painelGridProdutos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
