using ServiTech.Util;
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
    public partial class CadastrarCargo : Form
    {
        public CadastrarCargo()
        {
            InitializeComponent();
        }



        private void CadastrarPais_Load(object sender, EventArgs e)
        {
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Items.Add("Por Nome ");
            comboFiltros.Items.Add("Por Codigo ");
            comboFiltros.SelectedIndex = 0;

            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.Items.Add("Exatamente");
            comboModelo.SelectedIndex = 0;

        }

        private void groupBox2_Resize(object sender, EventArgs e)
        {
            btnPesquisar.Location = new Point(groupBox2.Width - btnPesquisar.Width - 9, btnPesquisar.Location.Y);
            checkBoxTodos.Location = new Point(groupBox2.Width - checkBoxTodos.Width - 9, checkBoxTodos.Location.Y);

        }

        private void LiberarCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {

            textNome.ReadOnly = false;
            textNome.Focus();
        }

        private void LiberarCamposParaNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {
                textNome.ReadOnly = false;

                textNome.Focus();
            }
        }

        private void LiberarCampos_Click(object sender, EventArgs e)
        {
            textNome.ReadOnly = false;

            textNome.Focus();


        }
    }
}
