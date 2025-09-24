using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiTech.Caixa
{
    public partial class Pdv : Form
    {
        private readonly System.Windows.Forms.Timer timer;

        public Pdv()
        {
            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = 100;
            this.timer.Tick += Time_Tick;
            this.timer.Start();
            InitializeComponent();
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
            int x = (gridProdutos.Width - targetWidth) / 2;
            int y = (gridProdutos.Height - targetHeight) / 2;

            // 🔹 Desenha redimensionada
            e.Graphics.DrawImage(watermark, new Rectangle(x, y, targetWidth, targetHeight)); // 
        }

        private void textTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            labelDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
