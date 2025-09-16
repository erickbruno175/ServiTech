
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

        private void FormCadastrarPais_Click(object sender, EventArgs e)
        {

            CadastrarPais cadastrarPais = new CadastrarPais();
            cadastrarPais.ShowDialog();

        }

        private void FormCadastrarCidade_Click(object sender, EventArgs e)
        {

            CadastrarCidade cadastrarCidade = new CadastrarCidade();
            cadastrarCidade.ShowDialog();

        }

        private void FormCadastrarBairro_Click(object sender, EventArgs e)
        {


            CadastrarBairro cadastrarBairro = new CadastrarBairro();
            cadastrarBairro.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastrarCargo_Click(object sender, EventArgs e)
        {

            CadastrarCargo cadastrarCargo = new CadastrarCargo();
            cadastrarCargo.ShowDialog();
        }

        private void FormCadastrarServico_Click(object sender, EventArgs e)
        {

            CadastrarServico cadastrarServico = new CadastrarServico();
            cadastrarServico.ShowDialog();
        }
    }
}
