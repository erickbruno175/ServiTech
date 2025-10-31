
using ServiTech.Caixa;
using ServiTech.DbConection;
using ServiTech.Forms.Cadastros;
using ServiTech.Forms.Cadastros.Tributaria;
using ServiTech.Os;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace ServiTech
{
    public partial class Gerenciador : Form
    {

        private readonly System.Windows.Forms.Timer timer;
        private readonly DbConection.DbConectionPdv db;
        public Gerenciador(DbConectionPdv db)
        {
            InitializeComponent();

            this.db = db;
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

            CadastrarPais cadastrarPais = new CadastrarPais(db);
            cadastrarPais.ShowDialog();

        }

        private void FormCadastrarCidade_Click(object sender, EventArgs e)
        {
            CadastrarCidade cadastrarCidade = new CadastrarCidade(db);
            cadastrarCidade.ShowDialog();

        }

        private void FormCadastrarBairro_Click(object sender, EventArgs e)
        {


            CadastrarBairro cadastrarBairro = new CadastrarBairro(db);
            cadastrarBairro.ShowDialog();
        }



        private void FormCadastrarCargo_Click(object sender, EventArgs e)
        {

            CadastrarCargo cadastrarCargo = new CadastrarCargo(db);
            cadastrarCargo.ShowDialog();
        }

        private void FormCadastrarServico_Click(object sender, EventArgs e)
        {

            CadastrarServico cadastrarServico = new CadastrarServico(db);
            cadastrarServico.ShowDialog();
        }






        private void FormsCadastrarFormaPagamento_Click(object sender, EventArgs e)
        {


            CadastrarFormaPagamento cadastrarFormaPagamento = new CadastrarFormaPagamento(db);
            cadastrarFormaPagamento.ShowDialog();

        }


        private void Time_Tick(object sender, EventArgs e)
        {
            labelDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void FormsCadastarFornecedor_Click(object sender, EventArgs e)
        {

            CadastrarFornecedor cadastrarFornecedor = new CadastrarFornecedor(db);
            cadastrarFornecedor.ShowDialog();
        }

       

        private void FormCadastroUnidadeMedida_Click(object sender, EventArgs e)
        {
            CadastrarUnidadeMedida cadastrarUnidadeMedida = new CadastrarUnidadeMedida(db);
            cadastrarUnidadeMedida.ShowDialog();

        }



        private void FormCadastrarBaucaoCaixa_Clcik(object sender, EventArgs e)
        {

            CadastrarBalcaoCaixa cadastrarBalcao = new CadastrarBalcaoCaixa();
            cadastrarBalcao.ShowDialog();
        }

        private void FormCadastrarProduto_Click(object sender, EventArgs e)
        {


            CadastrarProduto cadastrarProduto = new CadastrarProduto(db);
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
            if (e.KeyCode == Keys.F7)
            {
                Pdv pdv = new Pdv();
                pdv.WindowState = FormWindowState.Maximized;
                pdv.ShowDialog();
            }

            else if (e.KeyCode == Keys.F8)
            {

                FecharAplicacao_Click(sender, e);
            }

        }

        private void FormCondicaoPagamento_Click(object sender, EventArgs e)
        {
            CadastrarCondicaoPagamento cadastrarCondicaoPagamento = new CadastrarCondicaoPagamento(db);
            cadastrarCondicaoPagamento.ShowDialog();
        }



        private void FormCadastroSeguimento(object sender, EventArgs e)
        {

            CadastrarAtividadeEconomica cadastrarSeguimento = new CadastrarAtividadeEconomica(db);
            cadastrarSeguimento.ShowDialog();

        }

        private void FecharAplicacao_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmente sair do sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void FormCadastroMarca_Click(object sender, EventArgs e)
        {

            CadastrarMarca cadastrarMarca = new CadastrarMarca();
            cadastrarMarca.ShowDialog();
        }

        private void FormCadastroTrasnportadora(object sender, EventArgs e)
        {


            CadastrarTransportadora cadastrarTransportadora = new CadastrarTransportadora(db);
            cadastrarTransportadora.ShowDialog();

        }



        private void criarUmaNovaOrdemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrdemServico ordemServico = new FormOrdemServico();
            ordemServico.ShowDialog();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarProduto cadastrarProduto = new CadastrarProduto(db);
            cadastrarProduto.ShowDialog();

        }

        private void nCMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarNCM cadastrarNCM = new CadastrarNCM(db);
            cadastrarNCM.ShowDialog();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarServico cadastrarServiço = new CadastrarServico(db);
            cadastrarServiço.ShowDialog();
        }
    }
}
