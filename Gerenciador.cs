
using ServiTech.Caixa;
using ServiTech.Forms.Cadastros;
using ServiTech.Forms.Cadastros.Tributaria;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace ServiTech
{
    public partial class Gerenciador : Form
    {

        private readonly System.Windows.Forms.Timer timer;
        public Gerenciador()
        {
            InitializeComponent();

            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = 100;
            this.timer.Tick += Time_Tick;
            this.timer.Start();


        }
        private void FormCadastroCliente_Click(object sender, EventArgs e)
        {

            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.ShowDialog();
        }

        private void FormCadastrarPais_Click(object sender, EventArgs e)
        {

            CadastrarPais cadastrarPais = new CadastrarPais();
            cadastrarPais.ShowDialog();

        }

        private void FormCadastrarCidade_Click(object sender, EventArgs e)
        {

            CadastrarCidade cadastrarCidade = new CadastrarCidade();
            cadastrarCidade.ShowDialog();

        }

        private void FormCadastrarBairro_Click(object sender, EventArgs e)
        {


            CadastrarBairro cadastrarBairro = new CadastrarBairro();
            cadastrarBairro.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastrarCargo_Click(object sender, EventArgs e)
        {

            CadastrarCargo cadastrarCargo = new CadastrarCargo();
            cadastrarCargo.ShowDialog();
        }

        private void FormCadastrarServico_Click(object sender, EventArgs e)
        {

            CadastrarServico cadastrarServico = new CadastrarServico();
            cadastrarServico.ShowDialog();
        }



        private void FormCadastrarCategoria_Click(object sender, EventArgs e)
        {

            CadastrarCategoriaServico cadastrarCategoria = new CadastrarCategoriaServico();
            cadastrarCategoria.ShowDialog();
        }



        private void FormsCadastrarFormaPagamento_Click(object sender, EventArgs e)
        {

            CadastrarFormaPagamento cadastrarFormaPagamento = new CadastrarFormaPagamento();
            cadastrarFormaPagamento.ShowDialog();

        }


        private void Time_Tick(object sender, EventArgs e)
        {
            labelDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void FormsCadastarFornecedor_Click(object sender, EventArgs e)
        {

            CadastrarFornecedor cadastrarFornecedor = new CadastrarFornecedor();
            cadastrarFornecedor.ShowDialog();
        }

        private void FormCadastrarServicos_Click(object sender, EventArgs e)
        {

            CadastrarServico cadastrarServico = new CadastrarServico();
            cadastrarServico.ShowDialog();
        }

        private void FormCadastroUnidadeMedida_Click(object sender, EventArgs e)
        {
            CadastrarUnidadeMedida cadastrarUnidadeMedida = new CadastrarUnidadeMedida();
            cadastrarUnidadeMedida.ShowDialog();

        }



        private void FormCadastrarBaucaoCaixa_Clcik(object sender, EventArgs e)
        {

            CadastrarBalcao cadastrarBalcao = new CadastrarBalcao();
            cadastrarBalcao.ShowDialog();
        }

        private void FormCadastrarProduto_Click(object sender, EventArgs e)
        {

            CadastrarProduto cadastrarProduto = new CadastrarProduto();
            cadastrarProduto.ShowDialog();
        }

        private void FormCadastrarGrupo_Click(object sender, EventArgs e)
        {

            CadastrarGrupo cadastrarGrupo = new CadastrarGrupo();
            cadastrarGrupo.ShowDialog();
        }

        private void FormCadastrarSubGrupo_Click(object sender, EventArgs e)
        {

            CadastrarSubGrupo cadastrarSubGrupo = new CadastrarSubGrupo();
            cadastrarSubGrupo.ShowDialog();
        }

        private void FormCadastrarCategoriaFormaPagamento_Click(object sender, EventArgs e)
        {

            CadastrarCategoriaPagamento cadastrarCategoriaPagamento = new CadastrarCategoriaPagamento();
            cadastrarCategoriaPagamento.ShowDialog();
        }



        private void FormCadastrarCfop_Click(object sender, EventArgs e)
        {

            CadastrarCFOP cadastrarCOFP = new CadastrarCFOP();
            cadastrarCOFP.ShowDialog();
        }

        private void FormCadastrarCstCsosn_Click(object sender, EventArgs e)
        {

            CadastrarCSTCSOSN cadastrarCSTCSOSN = new CadastrarCSTCSOSN();
            cadastrarCSTCSOSN.ShowDialog();
        }

        private void FormCadastrarOrigemMercadoria_Click(object sender, EventArgs e)
        {

            CadastrarOrigemMercadoria cadastrarOrigemMercadoria = new CadastrarOrigemMercadoria();

            cadastrarOrigemMercadoria.ShowDialog();
        }

        private void FormCadastroFuncionario_Click(object sender, EventArgs e)
        {

            CadastrarFuncionario cadastrarFuncionario = new CadastrarFuncionario();
            cadastrarFuncionario.ShowDialog();
        }

     

        private void CapturaTeclasAtalho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                Pdv pdv = new Pdv();
                pdv.WindowState = FormWindowState.Maximized;
                pdv.ShowDialog();
            }

        }
    }
}
