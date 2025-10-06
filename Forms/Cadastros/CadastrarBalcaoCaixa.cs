using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarBalcaoCaixa : Form
    {
        public CadastrarBalcaoCaixa()
        {
            InitializeComponent();
        }

     

        private void CadastrarBalcao_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {
                textNome.ReadOnly = false;
                textNome.Focus();
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            textNome.ReadOnly = false;
            textNome.Focus();
        }

       
    }
}
