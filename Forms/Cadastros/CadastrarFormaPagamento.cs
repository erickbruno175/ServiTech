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

        private void groupBox1_Resize(object sender, EventArgs e)
        {

            btnBuscaCategoriaPagamento.Location = new Point(groupBox1.Width - btnBuscaCategoriaPagamento.Width - 9, btnBuscaCategoriaPagamento.Location.Y);
        }

        private void BuscarCategoriaFormaPagamento_Click(object sender, EventArgs e)
        {


            PesquisaCategoriasPagamento pesquisaCategoriasPagamento = new PesquisaCategoriasPagamento();
            pesquisaCategoriasPagamento.ShowDialog();

        }

        private void LiberarCamposParaNovoCadastro_Click(object sender, EventArgs e)
        {

            textCategoria.ReadOnly = false;
            textDescricao.ReadOnly = false;
            textDescricao.Focus();
            radioAtivoNao.Enabled = true;
            radioAtivoSim.Enabled = true;

           
        }

        private void LiberarCamposParaCadastro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F4)
            {
                textCategoria.ReadOnly = false;
                textDescricao.ReadOnly = false;
                textDescricao.Focus();
                radioAtivoNao.Enabled = true;
                radioAtivoSim.Enabled = true;
            }
        }

        private void groupBox4_Resize(object sender, EventArgs e)
        {
            btnPesquisarDados.Location = new Point(groupBox4.Width - btnPesquisarDados.Width - 9, btnPesquisarDados.Location.Y);
            checkBoxTodos.Location = new Point(groupBox4.Width - checkBoxTodos.Width - 9, checkBoxTodos.Location.Y);

        }
    }
}
