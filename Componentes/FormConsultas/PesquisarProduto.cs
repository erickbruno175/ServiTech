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
    public partial class PesquisarProduto : Form
    {
        public PesquisarProduto()
        {
            InitializeComponent();
        }

        private void groupBox2_Resize(object sender, EventArgs e)
        {
            btnPesquisar.Location = new Point(groupBox2.Width - btnPesquisar.Width - 10, btnPesquisar.Location.Y);
            checkBoxTodos.Location = new Point(groupBox2.Width - checkBoxTodos.Width - 10, checkBoxTodos.Location.Y);

        }
    }
}
