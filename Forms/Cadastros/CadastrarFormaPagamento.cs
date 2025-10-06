using ServiTech.Componentes.FormConsultas;
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
    public partial class CadastrarFormaPagamento : Form
    {
        public CadastrarFormaPagamento()
        {
            InitializeComponent();
        }





        private void LiberarCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {

            textNome.ReadOnly = false;
            textNome.Focus();
            textOperadora.ReadOnly = false;
            textTaxa.ReadOnly = false;
            textTipo.ReadOnly = false;
            radioAtivoNao.Enabled = true;
            radioAtivoSim.Enabled = true;
            radioButtonAceitaNao.Enabled = true;
            radioButtonAceitaSim.Enabled = true;


        }

        private void LiberarCamposParaCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {
                textNome.ReadOnly = false;
                textNome.Focus();
                textOperadora.ReadOnly = false;
                textTipo.ReadOnly = false;

                textTaxa.ReadOnly = false;
                radioAtivoNao.Enabled = true;
                radioAtivoSim.Enabled = true;
                radioButtonAceitaNao.Enabled = true;
                radioButtonAceitaSim.Enabled = true;
            }
        }

        private void groupBox4_Resize(object sender, EventArgs e)
        {
            btnPesquisarDados.Location = new Point(groupBox4.Width - btnPesquisarDados.Width - 9, btnPesquisarDados.Location.Y);
            checkBoxTodos.Location = new Point(groupBox4.Width - checkBoxTodos.Width - 9, checkBoxTodos.Location.Y);

        }

        private void CadastrarFormaPagamento_Load(object sender, EventArgs e)
        {
            comboFiltros.Items.Add("Por Nome ");
            comboFiltros.Items.Add("Por Codigo ");

            comboFiltros.SelectedIndex = 0;
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;

            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.Items.Add("Exatamente");
            comboModelo.SelectedIndex = 0;
            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
