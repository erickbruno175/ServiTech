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
    public partial class CadastrarAtividade : Form
    {
        public CadastrarAtividade()
        {
            InitializeComponent();
        }

        private void groupBox1_Resize(object sender, EventArgs e)
        {
            btnPesquisarPais.Location = new Point(this.groupBox1.Width - btnPesquisarPais.Width - 9, btnPesquisarPais.Location.Y);
            checkBoxTodos.Location = new Point(this.groupBox1.Width - checkBoxTodos.Width - 9, checkBoxTodos.Location.Y);
        }

        private void CadastrarAtividade_KeyDown(object sender, KeyEventArgs e)
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
