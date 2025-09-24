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
    public partial class CadastrarFornecedor : Form
    {
        public CadastrarFornecedor()
        {
            InitializeComponent();
        }



        private void groupBox5_Resize(object sender, EventArgs e)
        {
            btnPesquisar.Location = new Point(groupBox5.Width - btnPesquisar.Width - 9, btnPesquisar.Location.Y);
            checkBoxCarregarTodos.Location = new Point(groupBox5.Width - checkBoxCarregarTodos.Width - 9, checkBoxCarregarTodos.Location.Y);

        }
        private void LiberarCamposParaCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                foreach (TabPage tab in tabControl1.TabPages)
                {
                    HabilitarControles(tab.Controls);
                }
            }
        }

        private void HabilitarControles(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                switch (control)
                {
                    case TextBox textBox:
                        this.textCodigo.ReadOnly = true; // seu campo específico
                        this.textRazaoSocial.Focus();
                        radioButtonPessaoJuridica.Checked = true;
                        textBox.ReadOnly = false;
                        break;

                    case ComboBox comboBox:
                        comboBox.Enabled = true;
                        break;

                    case MaskedTextBox maskedTextBox:
                        maskedTextBox.ReadOnly = false;
                        break;

                    case RadioButton radioButton:
                        radioButton.Enabled = true;
                        break;

                    case Button button:
                        button.Enabled = true;
                        break;
                }

                // Se o controle tiver filhos (como GroupBox, Panel, etc.), chama de novo
                if (control.HasChildren)
                {
                    HabilitarControles(control.Controls);
                }
            }
        }





        private void LiberarCamposParaCadastro_Click(object sender, EventArgs e)
        {


            foreach (TabPage tab in tabControl1.TabPages)
            {
                HabilitarControles(tab.Controls);
            }

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

        private void CadastrarFornecedor_Load(object sender, EventArgs e)
        {
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Items.Add("Por Nome ");
            comboFiltros.Items.Add("Por Codigo ");
            comboFiltros.Items.Add("Por Cpf  ");
            comboFiltros.Items.Add("Por Cnpj ");
            comboFiltros.Items.Add("Por Email ");
            comboFiltros.Items.Add("Por Nome Responssavel ");


            comboFiltros.SelectedIndex = 0;

            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.Items.Add("Exatamente");
            comboModelo.SelectedIndex = 0;


            comboFiltros.SelectedIndex = 0;

            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.Items.Add("Exatamente");
            comboModelo.SelectedIndex = 0;
        }
    }
}

