using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiTech.Caixa.Operacao
{
    public partial class OperacaoConsultarProduto : Form
    {

        private bool podeDigitar = false;
        public OperacaoConsultarProduto()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!podeDigitar)
            {
                e.Handled = true;
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!podeDigitar) 
            
            {
                podeDigitar = true;
                textBox1.Focus();
                textBox1.Select();
                textBox1.BackColor = Color.LightYellow;
                textBox1.SelectionStart = textBox1.Text.Length;
            }


        }
    }
}
