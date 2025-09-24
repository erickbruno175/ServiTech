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
    public partial class CadastrarBairro : Form
    {
        public CadastrarBairro()
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
            btnPesquisar.Location = new Point(this.groupBox2.Width - btnPesquisar.Width - 9, btnPesquisar.Location.Y);

        }

        private void groupBox1_Resize(object sender, EventArgs e)
        {
            comboBoxUf.Location = new Point(this.groupBox1.Width - comboBoxUf.Width - 9, comboBoxUf.Location.Y);
            btnBuscaMunici.Location = new Point(this.groupBox1.Width - btnBuscaMunici.Width - 9, btnBuscaMunici.Location.Y);
            btnBuscaMunici.Location = new Point(this.groupBox1.Width - btnBuscaMunici.Width - 9, btnBuscaMunici.Location.Y);
            labelUf.Location = new Point(this.groupBox1.Width - labelUf.Width - 24, labelUf.Location.Y);
        }

      

        private void LiberararCamposParaNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {

                textBairro.ReadOnly = false;
                textBairro.Focus();
                textCodigoBairro.ReadOnly = false;
                textNomeCidade.ReadOnly = false;
                btnBuscaMunici.Enabled = true;
                comboBoxUf.Enabled = true;

            }

        }



        private void LiberararCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {
            textBairro.ReadOnly = false;
            textBairro.Focus();
            textCodigoBairro.ReadOnly = false;
            textNomeCidade.ReadOnly = false;
            btnBuscaMunici.Enabled = true;
            comboBoxUf.Enabled = true;

        }

        private void SairFormCadastroBairro(object sender, EventArgs e)
        {

            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
