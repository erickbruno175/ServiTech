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
    public partial class CadastrarPais : Form
    {
        public CadastrarPais()
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
            btnPesquisarPais.Location = new Point(this.groupBox2.Width - btnPesquisarPais.Width - 9, btnPesquisarPais.Location.Y);

        }

        private void LiberarCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {

            textCodigoPais.ReadOnly = false;
            textNomePais.ReadOnly = false;
        }

        private void LiberarCamposParaNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.F4)
            {
                textCodigoPais.ReadOnly = false;
                textNomePais.ReadOnly = false;
                textNomePais.Focus();
            }
        }
    }
}
