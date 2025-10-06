using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace ServiTech.Componentes.Services
{
    public partial class FrmGerarCodigoBarras : Form
    {
        public string CodigoGerado { get; private set; }
        public Bitmap ImagemGerada { get; private set; }
        private Bitmap barcodeToPrint;

        public FrmGerarCodigoBarras()
        {
            InitializeComponent();
        }

        private void GeradorCodigoBarraForm_Load(object sender, EventArgs e)
        {
            int interno = new Random().Next(1, 999999);

            CodigoGerado = BarcodeHelper.GerarEan13(interno);
            ImagemGerada = BarcodeHelper.GerarImagem(CodigoGerado, ZXing.BarcodeFormat.EAN_13);
            pictureBox1.Image = ImagemGerada;
        }



        // Botão "Imprimir Etiqueta"
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (ImagemGerada != null) // ou barcodeToPrint
            {
                barcodeToPrint = new Bitmap(ImagemGerada); // garante que a imagem esteja na variável

                PrintDocument pd = new PrintDocument();
                pd.PrintPage += PrintPage; // vincula o evento

                // Opcional: mostra a caixa de diálogo de impressão
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = pd;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    pd.Print(); // envia para a impressora
                }

                
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            if (barcodeToPrint != null)
            {
                e.Graphics.DrawImage(barcodeToPrint, new Point(10, 10)); // desenha o código de barras
                e.Graphics.DrawString(CodigoGerado, new Font("Arial", 10), // desenha o número embaixo
                    Brushes.Black, new PointF(10, 120)); // ajusta a posição conforme necessário
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        
    }
}
