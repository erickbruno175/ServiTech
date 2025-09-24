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
    public partial class CadastrarCidade : Form
    {
        public CadastrarCidade()
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

            comboBoxUf.SelectedIndex = 0;

        }

        private void groupBox2_Resize(object sender, EventArgs e)
        {
            btnPesquisar.Location = new Point(this.groupBox2.Width - btnPesquisar.Width - 9, btnPesquisar.Location.Y);

        }

        private void groupBox1_Resize(object sender, EventArgs e)
        {
            comboBoxUf.Location = new Point(this.groupBox1.Width - comboBoxUf.Width - 9, comboBoxUf.Location.Y);
            btnBuscaPais.Location = new Point(this.groupBox1.Width - btnBuscaPais.Width - 9, btnBuscaPais.Location.Y);
            labelUf.Location = new Point(this.groupBox1.Width - labelUf.Width - 24, labelUf.Location.Y);
        }

     
        private void LiberarCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {

            textNomePais.ReadOnly = false;
            textCodigoPais.ReadOnly = false;
            comboBoxUf.Enabled = true;

            textCodigoCidade.ReadOnly = false;
            textNomeCidade.ReadOnly = false;
            btnBuscaPais.Enabled = true;
            textNomeCidade.Focus();


        }

        private void LiberarCamposParaNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {
                textNomePais.ReadOnly = false;
                textCodigoPais.ReadOnly = false;
                comboBoxUf.Enabled = true;
                textCodigoCidade.ReadOnly = false;
                textNomeCidade.ReadOnly = false;
                btnBuscaPais.Enabled = true;
                textNomeCidade.Focus();
            }
        }

     
    }
}
