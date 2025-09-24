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
    public partial class CadastrarUnidadeMedida : Form
    {
        public CadastrarUnidadeMedida()
        {
            InitializeComponent();
        }

      

        private void LiberarCamposParaCadastro_Click(object sender, EventArgs e)
        {

            textDescricao.ReadOnly = false;
            textDescricao.Focus();

        }

        private void LiberarCampoParaCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            textDescricao.ReadOnly = false;
            textDescricao.Focus();

        }

        private void groupBox2_Resize(object sender, EventArgs e)
        {
            checkBoxTodos.Location = new Point(groupBox2.Width - checkBoxTodos.Width - 9, checkBoxTodos.Location.Y);
            btnPesquisar.Location = new Point(groupBox2.Width - btnPesquisar.Width - 9, btnPesquisar.Location.Y);
        }

        private void CadastrarUnidadeMedida_Load(object sender, EventArgs e)
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
    }
}
