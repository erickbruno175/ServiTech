using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiTech.Forms.Cadastros.Tributaria
{
    public partial class CadastrarCSTCSOSN : Form
    {
        public CadastrarCSTCSOSN()
        {
            InitializeComponent();
        }



        private void groupBox2_Resize(object sender, EventArgs e)
        {
            btnPesquisar.Location = new Point(groupBox2.Width - btnPesquisar.Width - 9, btnPesquisar.Location.Y);
            checkBoxTodos.Location = new Point(groupBox2.Width - checkBoxTodos.Width - 9, checkBoxTodos.Location.Y);
        }

        private void CadastrarCSTCSOSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                textCodRegra.ReadOnly = false;
                textNome.ReadOnly = false;
                textNome.Focus();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            textCodRegra.ReadOnly = false;
            textNome.ReadOnly = false;
            textNome.Focus();
        }
    }
}
