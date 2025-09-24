using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiTech.Componentes.FormConsultas
{
    public partial class PesquisaCategoriasPagamento : Form
    {
        public PesquisaCategoriasPagamento()
        {
            InitializeComponent();
        }

        private void groupBox2_Resize(object sender, EventArgs e)
        {
            btnPesquisarDados.Location = new Point(groupBox2.Width - btnPesquisarDados.Width - 9 , btnPesquisarDados.Location.Y);
        }
    }
}
