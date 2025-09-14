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
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }




        private void DefinirMascaraCpfCnpj_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonPessaoJuridica.Checked)
            {
                textCpfCnpj.Mask = "00.000.000/0000-00";
                labelCpfCnpj.Text = "CNPJ";
            }
            if (radioButtonPessoaFisica.Checked)
            {
                textCpfCnpj.Mask = "000.000.000-00";
                labelCpfCnpj.Text = "CPF";
            }
        }

        private void CarregarCombosConsultas()
        {
            // Preenche modelo
            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.Items.Add("Exatamente");
            comboModelo.SelectedIndex = 0; // seleciona primeiro item
            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelo.Select();

            comboFiltros.Items.Add("Nome");
            comboFiltros.Items.Add("CPF");
            comboFiltros.Items.Add("CNPJ");
            comboFiltros.Items.Add("Telefone");
            comboFiltros.Items.Add("Email");
            comboFiltros.Items.Add("Bairro");
            comboFiltros.Items.Add("Cidade");
            comboFiltros.Items.Add("Estado");
            comboFiltros.SelectedIndex = 0;
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Select();

            // Define foco inicial no combo que você quer que fique azul
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

            CarregarCombosConsultas();
          
        }
    }
}
