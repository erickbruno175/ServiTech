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
            comboFiltros.Items.Add("Ativos");
            comboFiltros.Items.Add("Inativos");
            comboFiltros.SelectedIndex = 0;
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Select();

            // Define foco inicial no combo que você quer que fique azul
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

            CarregarCombosConsultas();

        }

        private void LiberararCamposParaNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {

                textBairro.ReadOnly = false;
                textCep.ReadOnly = false;
                textCidade.ReadOnly = false;
                textUf.ReadOnly = false;
                textRg.ReadOnly = false;
                textNomeContato.ReadOnly = false;
                textEmailContato.ReadOnly = false;
                textTelFixoContato.ReadOnly = false;
                textWhatsApp.ReadOnly = false;
                textBairro.ReadOnly = false;
                textWhatsAppContato.ReadOnly = false;
                textCpfCnpj.ReadOnly = false;
                textNomeCliente.ReadOnly = false;
                textNumero.ReadOnly = false;
                textNomeCliente.Focus();
                textNomeCliente.Select();
                textTelefoneFixo.ReadOnly = false;
                comboBoxGralParentesco.Enabled = true;
                comboBoxSexo.Enabled = true;
                radioButtonAtivoNao.Enabled = true;
                radioButtonAtivoNao.Enabled = true;
                radioButtonPessaoJuridica.Enabled = true;
                radioButtonPessoaFisica.Enabled = true;
                textDataNascimento.ReadOnly = false;
                textEmail.ReadOnly = false;
                textCpfContato.ReadOnly = false;
                textPais.ReadOnly = false;
                textRgContato.ReadOnly = false;
                btnBuscaBairro.Enabled = true;
                btnBuscaCidade.Enabled = true;
                btnBuscarPais.Enabled = true;
                radioButtonAtivoSim.Enabled = true;
                btnGravar.Enabled = true;
                radioButtonPessaoJuridica.Checked = true;



            }
        }

        private void LiberararCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {
            textBairro.ReadOnly = false;
            textCep.ReadOnly = false;
            textCidade.ReadOnly = false;
            textUf.ReadOnly = false;
            textRg.ReadOnly = false;
            textNomeContato.ReadOnly = false;
            textEmailContato.ReadOnly = false;
            textTelFixoContato.ReadOnly = false;
            textWhatsApp.ReadOnly = false;
            textBairro.ReadOnly = false;
            textWhatsAppContato.ReadOnly = false;
            textCpfCnpj.ReadOnly = false;
            textNomeCliente.ReadOnly = false;
            textNumero.ReadOnly = false;
            textNomeCliente.Focus();
            textNomeCliente.Select();
            textTelefoneFixo.ReadOnly = false;
            comboBoxGralParentesco.Enabled = true;
            comboBoxSexo.Enabled = true;
            radioButtonAtivoNao.Enabled = true;
            radioButtonAtivoNao.Enabled = true;
            radioButtonPessaoJuridica.Enabled = true;
            radioButtonPessoaFisica.Enabled = true;
            textDataNascimento.ReadOnly = false;
            textEmail.ReadOnly = false;
            textCpfContato.ReadOnly = false;
            textPais.ReadOnly = false;
            textRgContato.ReadOnly = false;
            btnBuscaBairro.Enabled = true;
            btnBuscaCidade.Enabled = true;
            btnBuscarPais.Enabled = true;
            radioButtonAtivoSim.Enabled = true;
            btnGravar.Enabled = true;
            radioButtonPessaoJuridica.Checked = true;

        }

        private void FeicharTelaCadastroCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            btnSair.Location = new Point(panel1.Width - btnSair.Width - 9, btnSair.Location.Y);
        }

        private void groupBox5_Resize(object sender, EventArgs e)
        {
            btnPesquisarCliente.Location = new Point(groupBox5.Width - btnPesquisarCliente.Width - 9, btnPesquisarCliente.Location.Y);
            checkBoxCarregarTodos.Location = new Point(groupBox5.Width - checkBoxCarregarTodos.Width - 9, checkBoxCarregarTodos.Location.Y);
        }
    }
}
