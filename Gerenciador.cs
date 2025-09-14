
using ServiTech.Forms.Cadastros;
using System;
using System.Collections.Generic;
namespace ServiTech
{
    public partial class Gerenciador : Form
    {
        public Gerenciador()
        {
            InitializeComponent();
        }

        private void FormCadastroCliente_Click(object sender, EventArgs e)
        {

            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.ShowDialog();
        }

    }
}
