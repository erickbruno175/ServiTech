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
    public partial class CadastrarServico : Form
    {
        public CadastrarServico()
        {
            InitializeComponent();
        }

      

        private void CadastrarPais_Load(object sender, EventArgs e)
        {
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Items.Add("Por Nome ");
            comboFiltros.Items.Add("Por Codigo");
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
            checkBoxTodos.Location = new Point(this.groupBox2.Width - checkBoxTodos.Width - 9, checkBoxTodos.Location.Y);

        }

        private void LiberarCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {
            textNomeServico.ReadOnly = false;
            textNomeServico.Focus();
            textCategoriaServico.ReadOnly = false;
            textPrecoServico.ReadOnly = false;
            btnBuscaCategoria.Enabled = false;
            radioButtonAtivoNao.Enabled = true;
            radioButtonAtivoSim.Enabled = true;
            textDescricao.ReadOnly = false;

            btnBuscaCategoria.Enabled = true;
        }

        private void LiberarCamposParaNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {
                textNomeServico.ReadOnly = false;
                textNomeServico.Focus();
                textCategoriaServico.ReadOnly = false;
                textPrecoServico.ReadOnly = false;
                btnBuscaCategoria.Enabled = false;
                radioButtonAtivoNao.Enabled = true;
                radioButtonAtivoSim.Enabled = true;
                textDescricao.ReadOnly = false;
                btnBuscaCategoria.Enabled = true;


            }

            if (e.KeyCode == Keys.F1)
            {
                PesquisaCategoriasServiços pesquisaCategorias = new PesquisaCategoriasServiços();

                pesquisaCategorias.ShowDialog();
            }
        }



        private void AbriFormPesquisaCategoria_Click(object sender, EventArgs e)
        {
            PesquisaCategoriasServiços pesquisaCategorias = new PesquisaCategoriasServiços();

            pesquisaCategorias.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
