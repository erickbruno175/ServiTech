
using ServiTech.Forms.Cadastros;
using System;
using System.Collections.Generic;
namespace ServiTech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FormCadastroCliente_Click(object sender, EventArgs e)
        {

            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
