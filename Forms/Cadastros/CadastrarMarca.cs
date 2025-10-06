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
    public partial class CadastrarMarca : Form
    {
        public CadastrarMarca()
        {
            InitializeComponent();
        }

      
      

        private void LiberarCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {

            textCodigo.ReadOnly = true;
            textNome.ReadOnly = false;
            textMarca.ReadOnly = false;
            textNome.Focus();

        }

        private void LiberarCamposParaNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.F4)
            {
                textCodigo.ReadOnly = true;
                textNome.ReadOnly = false;
                textMarca.ReadOnly = false;
                textNome.Focus();
            }
        }
    }
}
