using Microsoft.EntityFrameworkCore;
using ServiTech.Enum;
using ServiTech.Enumeradores;
using ServiTech.Forms.Cadastros.Tributaria;
using ServiTech.Model;
using ServiTech.Util;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace ServiTech.Forms.Cadastros
{
    public partial class CadastrarProduto : Form
    {
        private readonly DbConection.DbConectionPdv conectionPdv;
        private byte[] fotoProduto;
        public CadastrarProduto(DbConection.DbConectionPdv dbConectionPdv)
        {
            InitializeComponent();
            this.conectionPdv = dbConectionPdv;


        }



        private void MskararCampoMoeda_Changed(object sender, EventArgs e)
        {


            TextBox textBox = sender as TextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string newText = new string(textBox.Text.Where(c => char.IsDigit(c)).ToArray());// Remove todos os caracteres que não são dígitos
                textBox.Text = newText;// Atualiza o texto da TextBox
                textBox.SelectionStart = textBox.Text.Length; // Coloca o cursor no final do texto
            }


            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string texto = textBox.Text.Replace("R$", "")
                                   .Replace(".", "")
                                   .Replace(",", "")
                                   .Trim();
                if (decimal.TryParse(texto, out decimal valor)) // tenta converter o texto para decimal
                {
                    textBox.TextChanged -= MskararCampoMoeda_Changed; // evita loop
                    textBox.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), "{0:C2}", valor / 100);// formata para moeda BRL
                    textBox.SelectionStart = textBox.Text.Length; // cursor no fim
                    textBox.TextChanged += MskararCampoMoeda_Changed; // reativa o evento
                }
            }

        }


        private void LiberaCamposParaCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                foreach (TabPage page in tabControl1.TabPages)
                {
                    HabilitarControles(page.Controls);
                }
            }
            else if (e.KeyCode == Keys.F12)

            {
                if (textCodBarraAlternativo.ReadOnly == true)

                {
                    MessageBox.Show("Para gerar O código de barras, primeiro habilite os campos com F4", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                textCodBarraAlternativo.Text = GerarCodigoBarra.GerarEAN13();



            }
        }

        private void HabilitarControles(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                switch (control)
                {
                    case TextBox textBox:
                        textBox.ReadOnly = false;
                        textBox.Clear();
                        break;

                    case ComboBox comboBox:
                        comboBox.Enabled = true;
                        break;

                    case Button button:
                        button.Enabled = true;
                        break;

                    case NumericUpDown numericUpDown:
                        numericUpDown.ReadOnly = false;
                        numericUpDown.Value = 0;

                        break;

                    case CheckBox checkBox:
                        checkBox.Enabled = true;
                        break;

                    case MaskedTextBox maskedTextBox:
                        maskedTextBox.ReadOnly = false;
                        maskedTextBox.Clear();
                        break;


                    case GroupBox groupBox:
                        // chamada recursiva para liberar os controles internos
                        HabilitarControles(groupBox.Controls);
                        break;
                }
            }

            // campos que SEMPRE ficam bloqueados
            textCodInterno.ReadOnly = true;
            textPrecoVenda.ReadOnly = true;
            textCod.ReadOnly = true;
            textLucro.ReadOnly = true;
            textNomeProd.Focus();


        }

        private void textMargemCalc_Leave(object sender, EventArgs e)
        {
            // Tenta ler o valor da margem
            bool margemOk = decimal.TryParse(
                textMargemCalc.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim(),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out decimal margem);

            // Tenta ler o valor de custo
            bool custoOk = decimal.TryParse(
                textPrecoCusto.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim(),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out decimal valorCusto);

            if (margemOk && custoOk)
            {
                decimal valorVendaCalculada = valorCusto + (valorCusto * (margem / 100));
                textPrecoVenda.Text = valorVendaCalculada.ToString("N2");
                textLucro.Text = (valorVendaCalculada - valorCusto).ToString("N2");
            }
            else
            {
                textPrecoVenda.Text = "0,00";
            }
        }

        private void CadastrarProduto_Load(object sender, EventArgs e)
        {
            comboFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltros.Items.Clear();

            // 🔎 Filtros principais
            comboFiltros.Items.Add("Por Nome");
            comboFiltros.Items.Add("Por Código Interno");
            comboFiltros.Items.Add("Por Código de Barras");
            comboFiltros.Items.Add("Por Código de Barras Alternativo");
           
            comboFiltros.SelectedIndex = 0;

            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelo.Items.Add("Inicia Com");
            comboModelo.Items.Add("Termina Com");
            comboModelo.Items.Add("Contem");
            comboModelo.SelectedIndex = 0;
            CarregarProdutosGrid();
            CarregarComboBox();
            CarregarCombox();
            CarregarGrupos();


        }


        private void CarregarProdutosGrid()
        {
            var produtos = conectionPdv.Produto
                .Select(p => new
                {
                    // === DADOS BÁSICOS ===
                    p.Id,
                    p.CodigoInterno,
                    p.CodigoBarraEAN,
                    p.CodigoBarraAlternativo,
                    p.CodigoBalanca,
                    p.ProdutoBalanca,
                    p.Nome,
                    p.UnidadeMedidaEntrada,
                    p.UnidadeMedidaSaida,
                    p.TipoProduto,
                    p.Ativo,
                    p.PermitidoDesconto,
                    p.Cor,
                    p.Tamanho,
                    p.Observacao,
                    p.DataCadastro,
                    p.DataAtualizacao,
                    p.DataValidade,
                    p.UltimaCompra,

                    // === RELACIONAMENTOS ===
                    FornecedorNome = p.Fornecedor != null ? p.Fornecedor.RazaoSocial : null,
                    GrupoNome = p.Grupo != null ? p.Grupo.Nome : null,
                    SubGrupoNome = p.SubGrupo != null ? p.SubGrupo.Nome : null,
                    MarcaNome = p.Marca != null ? p.Marca.Nome : null,
                    OrigemMercadoriaCodigo = p.OrigemMercadoria != null ? p.OrigemMercadoria.Codigo : null,
                    CFOPCodigo = p.CFOP != null ? p.CFOP.Codigo : null,
                    NCMCodigo = p.Ncm != null ? p.Ncm.Codigo : null,
                    CSTCSOSNCodigo = p.CSTCSOSN != null ? p.CSTCSOSN.Codigo : null,


                    // === FINANCEIRO ===
                    p.PrecoCusto,
                    p.PrecoVenda,
                    p.Margem,
                    p.Lucro,

                    // === FISCAL ===
                    p.ICMS,
                    p.PIS,
                    p.COFINS,
                    p.IPI,

                    // === ESTOQUE ===
                    p.PontoReposicao,
                    p.QuantidadeMaxima,
                    p.QuantidadeEstoque,


                })
                .ToList();

            dataGridProdutos.DataSource = produtos;





            // ==== ESTILO DO CABEÇALHO ====
            dataGridProdutos.EnableHeadersVisualStyles = false;
            dataGridProdutos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 66, 100);
            dataGridProdutos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridProdutos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            dataGridProdutos.ColumnHeadersHeight = 32;

            // ==== ESTILO DAS LINHAS ====
            dataGridProdutos.DefaultCellStyle.BackColor = Color.White;
            dataGridProdutos.DefaultCellStyle.ForeColor = Color.Black;
            dataGridProdutos.DefaultCellStyle.Font = new Font("Segoe UI", 8F);
            dataGridProdutos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 135);
            dataGridProdutos.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridProdutos.RowHeadersVisible = false;
            dataGridProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProdutos.GridColor = Color.FromArgb(220, 220, 220);
            dataGridProdutos.BorderStyle = BorderStyle.FixedSingle;
            dataGridProdutos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridProdutos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dataGridProdutos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            // ==== CABEÇALHOS E LARGURAS ====

            // --- DADOS BÁSICOS ---
            dataGridProdutos.Columns["Id"].HeaderText = "Código";
            dataGridProdutos.Columns["Id"].Width = 60;

            dataGridProdutos.Columns["CodigoInterno"].HeaderText = "Cód. Interno";
            dataGridProdutos.Columns["CodigoInterno"].Width = 250;

            dataGridProdutos.Columns["CodigoBarraEAN"].HeaderText = "Cód. de Barras EAN";
            dataGridProdutos.Columns["CodigoBarraEAN"].Width = 250;

            dataGridProdutos.Columns["CodigoBarraAlternativo"].HeaderText = "Cód. Barras Alternativo";
            dataGridProdutos.Columns["CodigoBarraAlternativo"].Width = 350;

            dataGridProdutos.Columns["CodigoBalanca"].HeaderText = "Cód. Balança";
            dataGridProdutos.Columns["CodigoBalanca"].Width = 200;

            dataGridProdutos.Columns["Nome"].HeaderText = "Nome do Produto";
            dataGridProdutos.Columns["Nome"].Width = 350;

            dataGridProdutos.Columns["UnidadeMedidaEntrada"].HeaderText = "Und. Entrada";
            dataGridProdutos.Columns["UnidadeMedidaEntrada"].Width = 200;

            dataGridProdutos.Columns["UnidadeMedidaSaida"].HeaderText = "Und. Saída";
            dataGridProdutos.Columns["UnidadeMedidaSaida"].Width = 250;

            dataGridProdutos.Columns["TipoProduto"].HeaderText = "Tipo de Produto";
            dataGridProdutos.Columns["TipoProduto"].Width = 250;

            dataGridProdutos.Columns["Ativo"].HeaderText = "Ativo";
            dataGridProdutos.Columns["Ativo"].Width = 60;

            dataGridProdutos.Columns["PermitidoDesconto"].HeaderText = "Permite Desconto";
            dataGridProdutos.Columns["PermitidoDesconto"].Width = 250;

            dataGridProdutos.Columns["Cor"].HeaderText = "Cor";
            dataGridProdutos.Columns["Cor"].Width = 80;

            dataGridProdutos.Columns["Tamanho"].HeaderText = "Tamanho";
            dataGridProdutos.Columns["Tamanho"].Width = 80;

            dataGridProdutos.Columns["Observacao"].HeaderText = "Observação";
            dataGridProdutos.Columns["Observacao"].Width = 180;

            dataGridProdutos.Columns["DataCadastro"].HeaderText = "Cadastro";
            dataGridProdutos.Columns["DataCadastro"].Width = 100;

            dataGridProdutos.Columns["DataAtualizacao"].HeaderText = "Atualização";
            dataGridProdutos.Columns["DataAtualizacao"].Width = 100;

            dataGridProdutos.Columns["DataValidade"].HeaderText = "Validade";
            dataGridProdutos.Columns["DataValidade"].Width = 200;

            dataGridProdutos.Columns["UltimaCompra"].HeaderText = "Última Compra";
            dataGridProdutos.Columns["UltimaCompra"].Width = 250;

            // --- RELACIONAMENTOS ---
            dataGridProdutos.Columns["FornecedorNome"].HeaderText = "Fornecedor";
            dataGridProdutos.Columns["FornecedorNome"].Width = 200;

            dataGridProdutos.Columns["GrupoNome"].HeaderText = "Grupo";
            dataGridProdutos.Columns["GrupoNome"].Width = 200;

            dataGridProdutos.Columns["SubGrupoNome"].HeaderText = "Subgrupo";
            dataGridProdutos.Columns["SubGrupoNome"].Width = 200;

            dataGridProdutos.Columns["MarcaNome"].HeaderText = "Marca";
            dataGridProdutos.Columns["MarcaNome"].Width = 200;

            dataGridProdutos.Columns["OrigemMercadoriaCodigo"].HeaderText = "Cód. Origem";
            dataGridProdutos.Columns["OrigemMercadoriaCodigo"].Width = 150;

            dataGridProdutos.Columns["CFOPCodigo"].HeaderText = "CFOP";
            dataGridProdutos.Columns["CFOPCodigo"].Width = 120;

            dataGridProdutos.Columns["NCMCodigo"].HeaderText = "NCM";
            dataGridProdutos.Columns["NCMCodigo"].Width = 120;

            dataGridProdutos.Columns["CSTCSOSNCodigo"].HeaderText = "CST/CSOSN";
            dataGridProdutos.Columns["CSTCSOSNCodigo"].Width = 150;

            // --- FINANCEIRO ---
            dataGridProdutos.Columns["PrecoCusto"].HeaderText = "Preço de Custo";
            dataGridProdutos.Columns["PrecoCusto"].Width = 200;

            dataGridProdutos.Columns["PrecoVenda"].HeaderText = "Preço de Venda";
            dataGridProdutos.Columns["PrecoVenda"].Width = 200;

            dataGridProdutos.Columns["Margem"].HeaderText = "Margem (%)";
            dataGridProdutos.Columns["Margem"].Width = 200;

            dataGridProdutos.Columns["Lucro"].HeaderText = "Lucro (R$)";
            dataGridProdutos.Columns["Lucro"].Width = 250;

           

            // --- FISCAL ---
            dataGridProdutos.Columns["ICMS"].HeaderText = "ICMS (%)";
            dataGridProdutos.Columns["ICMS"].Width = 250;

            dataGridProdutos.Columns["PIS"].HeaderText = "PIS (%)";
            dataGridProdutos.Columns["PIS"].Width = 250;

            dataGridProdutos.Columns["COFINS"].HeaderText = "COFINS (%)";
            dataGridProdutos.Columns["COFINS"].Width = 250;

            dataGridProdutos.Columns["IPI"].HeaderText = "IPI (%)";
            dataGridProdutos.Columns["IPI"].Width = 250;

            // --- ESTOQUE ---
            dataGridProdutos.Columns["PontoReposicao"].HeaderText = "Ponto de Reposição";
            dataGridProdutos.Columns["PontoReposicao"].Width = 200;



            dataGridProdutos.Columns["QuantidadeMaxima"].HeaderText = "Qtd. Máxima";
            dataGridProdutos.Columns["QuantidadeMaxima"].Width = 110;


            dataGridProdutos.Columns["QuantidadeEstoque"].HeaderText = "Qtd. em Estoque";
            dataGridProdutos.Columns["QuantidadeEstoque"].Width = 250;

            dataGridProdutos.Columns["ProdutoBalanca"].HeaderText = "Produto De Balança";
            dataGridProdutos.Columns["ProdutoBalanca"].Width = 200;

            // === ADICIONA COLUNA DE IMAGEM ===



            dataGridProdutos.GridColor = Color.FromArgb(220, 220, 220);
            dataGridProdutos.BorderStyle = BorderStyle.FixedSingle;
            dataGridProdutos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridProdutos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dataGridProdutos.AllowUserToResizeColumns = false;
            dataGridProdutos.AllowUserToResizeRows = false; 

        }



        private void CarregarCombox()
        {
            comboBoxCfop.DataSource = conectionPdv.CFOPs.ToList();
            comboBoxCfop.DisplayMember = "Descricao";
            comboBoxCfop.ValueMember = "Id";
            comboBoxCfop.SelectedIndex = 0;


            comboBoxCst.DataSource = conectionPdv.CSTCSOSNs.ToList();
            comboBoxCst.DisplayMember = "Descricao";
            comboBoxCst.ValueMember = "Id";
            comboBoxCst.SelectedIndex = 0;


            comboBoxOrigemProd.DataSource = conectionPdv.OrigemMercadorias.ToList();
            comboBoxOrigemProd.DisplayMember = "Descricao";
            comboBoxOrigemProd.ValueMember = "Id";
            comboBoxOrigemProd.SelectedIndex = 0;


            comboBoxNcm.DataSource = conectionPdv.Ncms.ToList();
            comboBoxNcm.DisplayMember = "Nome";
            comboBoxNcm.ValueMember = "Id";
            comboBoxNcm.SelectedIndex = 0;


            comboBoxMarcaFabricante.DataSource = conectionPdv.Marcas.ToList();
            comboBoxMarcaFabricante.DisplayMember = "Nome";
            comboBoxMarcaFabricante.ValueMember = "Id";
            comboBoxMarcaFabricante.SelectedIndex = 0;


            comboUnidadeMedidaEntrada.DataSource = conectionPdv.UnidadeMedidas.ToList();
            comboUnidadeMedidaEntrada.DisplayMember = "Nome";
            comboUnidadeMedidaEntrada.ValueMember = "Id";
            comboUnidadeMedidaEntrada.SelectedIndex = 0;




            comboUnidadeMedidaSaida.DataSource = conectionPdv.UnidadeMedidas.ToList();
            comboUnidadeMedidaSaida.DisplayMember = "Nome";
            comboUnidadeMedidaSaida.ValueMember = "Id";
            comboUnidadeMedidaSaida.SelectedIndex = 0;




        }


        public void CarregarGrupos()
        {

            comboGrupo.DataSource = conectionPdv.Grupos.ToList();
            comboGrupo.DisplayMember = "Nome";
            comboGrupo.ValueMember = "Id";
            comboGrupo.SelectedIndex = 0;
        }


        private void CarregarComboBox()
        {

            comboBoxTipoProduto.DataSource = System.Enum.GetValues(typeof(TipoProduto));
            comboBoxTamanho.DataSource = System.Enum.GetValues(typeof(TipoTamanho));
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }





        private void textIdFornecedor_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrWhiteSpace(textIdFornecedor.Text))
                {
                    textNomeFornecedor.Clear();
                    return;
                }

                int IdFornecedor = int.Parse(textIdFornecedor.Text);

                var fornecedorEncontrato = this.conectionPdv.Fornecedores.Find(IdFornecedor);
                if (fornecedorEncontrato != null)
                {
                    textNomeFornecedor.Text = fornecedorEncontrato.Nomefantasia;
                }
                else
                {
                    textNomeFornecedor.Clear();
                    textCod.Clear();
                    MessageBox.Show("Fornecedor não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGrupo.SelectedValue != null)
            {
                if (comboGrupo.SelectedValue is int idGrupo)
                {
                    comboSubGrupo.DataSource = conectionPdv.SubGrupos.Where(sg => sg.GrupoId == idGrupo).ToList();
                    comboSubGrupo.DisplayMember = "Nome";
                    comboSubGrupo.ValueMember = "Id";
                }
            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            GravarProduto();
        }


        private void GravarProduto()
        {
            try
            {
                //messagemError.Clear();

                if (string.IsNullOrWhiteSpace(textNomeProd.Text)
                    || string.IsNullOrWhiteSpace(textIdFornecedor.Text)
                    || string.IsNullOrWhiteSpace(comboBoxTipoProduto.Text)
                    || string.IsNullOrWhiteSpace(comboGrupo.Text)
                    || string.IsNullOrWhiteSpace(comboSubGrupo.Text)
                    || string.IsNullOrWhiteSpace(comboBoxMarcaFabricante.Text)
                    || string.IsNullOrWhiteSpace(comboUnidadeMedidaEntrada.Text)
                    || string.IsNullOrWhiteSpace(comboUnidadeMedidaSaida.Text)
                    || string.IsNullOrWhiteSpace(textMargemCalc.Text)
                    || string.IsNullOrWhiteSpace(textPrecoCusto.Text)
                    || string.IsNullOrWhiteSpace(textPontoReposicao.Text)
                    || string.IsNullOrWhiteSpace(textQuantMaxima.Text)
                    || string.IsNullOrWhiteSpace(comboBoxOrigemProd.Text)
                    || string.IsNullOrWhiteSpace(comboBoxCst.Text)
                    || string.IsNullOrWhiteSpace(comboBoxCfop.Text)
                    || string.IsNullOrWhiteSpace(comboBoxNcm.Text)
                    || string.IsNullOrWhiteSpace(textCodBarraEAN.Text))

                {
                    MessageBox.Show("Campos obrigatorios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                else
                {

                    if (string.IsNullOrWhiteSpace(textCod.Text))
                    {
                        // E UM NOVO REGISTRO CASO ID SEJA VAZIO

                        bool verifcaSeProdutoJaExiste = conectionPdv.Produto.Any(p => p.CodigoBarraEAN == textCodBarraEAN.Text);

                        if (verifcaSeProdutoJaExiste)
                        {
                            MessageBox.Show("Esse  produto ja existe ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            return;
                        }
                        else
                        {
                            if (pictureFotoProduto.Image != null)
                            {
                                using (Image imageRedimencionada = ProcessarImagemProduto.RedimensionarImagem(pictureFotoProduto.Image, 200, 200))
                                {
                                    fotoProduto = ProcessarImagemProduto.ConvertImageByte(imageRedimencionada);
                                }
                            }

                            var produto = new Produto
                            {
                                Nome = textNomeProd.Text,
                                CodigoBarraEAN = textCodBarraEAN.Text,
                                CodigoBarraAlternativo = textCodBarraAlternativo.Text,
                                Ativo = checkAtivo.Checked,
                                PermitidoDesconto = checkDescontoSim.Checked,
                                GrupoId = (int)comboGrupo.SelectedValue,
                                SubGrupoId = (int)comboSubGrupo.SelectedValue,
                                FornecedorId = int.Parse(textIdFornecedor.Text),
                                DataCadastro = DateTime.Now,
                                DataAtualizacao = DateTime.Now,
                                DataValidade = DateTime.TryParse(textDataValidade.Text, out DateTime dataVal) ? dataVal : (DateTime?)null,
                                Cor = textCor.Text,
                                CodigoBalanca = textCodigoBalanca.Text,
                                MarcaFabricanteId = (int)comboBoxMarcaFabricante.SelectedValue,
                                UnidadeMedidaEntrada = comboUnidadeMedidaEntrada.Text,
                                UnidadeMedidaSaida = comboUnidadeMedidaSaida.Text,
                                Tamanho = comboBoxTamanho.Text,
                                TipoProduto = comboBoxTipoProduto.Text,
                                Margem = decimal.Parse(textMargemCalc.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim(), CultureInfo.InvariantCulture),
                                Lucro = decimal.Parse(textLucro.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim(), CultureInfo.InvariantCulture),
                                PrecoVenda = decimal.Parse(textPrecoVenda.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim(), CultureInfo.InvariantCulture),
                                PrecoCusto = decimal.Parse(textPrecoCusto.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim(), CultureInfo.InvariantCulture),
                              

                                PontoReposicao = decimal.Parse(textPontoReposicao.Text.Replace("R$", "").Replace(".", "").Replace(",", "."), CultureInfo.InvariantCulture),

                                QuantidadeMaxima = decimal.Parse(textQuantMaxima.Text.Replace("R$", "").Replace(".", "").Replace(",", "."), CultureInfo.InvariantCulture),
                                Observacao = textObservacao.Text,
                                NcmId = (int)comboBoxNcm.SelectedValue,
                                OrigemMercadoriaId = (int)comboBoxOrigemProd.SelectedValue,
                                CfopId = (int)comboBoxCfop.SelectedValue,
                                CstId = (int)comboBoxCst.SelectedValue,
                                COFINS = string.IsNullOrWhiteSpace(textCOFINS.Text) ? 0m : decimal.Parse(textCOFINS.Text.Replace("R$", "").Replace(".", "").Replace(",", "."), CultureInfo.GetCultureInfo("pt-BR")),
                                PIS = string.IsNullOrWhiteSpace(textPIS.Text) ? 0m : decimal.Parse(textPIS.Text.Replace("R$", "").Replace(".", "").Replace(",", "."), CultureInfo.GetCultureInfo("pt-BR")),
                                ICMS = string.IsNullOrWhiteSpace(textICMS.Text) ? 0m : decimal.Parse(textICMS.Text.Replace("R$", "").Replace(".", "").Replace(",", "."), CultureInfo.GetCultureInfo("pt-BR")),
                                IPI = string.IsNullOrWhiteSpace(textIPI.Text) ? 0m : decimal.Parse(textIPI.Text.Replace("R$", "").Replace(".", "").Replace(",", "."), CultureInfo.GetCultureInfo("pt-BR")),
                                ProdutoBalanca = checkdProdBalança.Checked,
                                CodigoInterno = GeradorCodigoInterno.GerarCodigoInterno(conectionPdv),
                                FotoProduto = fotoProduto


                            };

                            conectionPdv.Add(produto);
                            conectionPdv.SaveChanges();
                            MessageBox.Show("Produto cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            textCodInterno.Text = produto.CodigoInterno.ToString();
                            textCod.Text = produto.Id.ToString();
                            CarregarProdutosGrid();
                            return;
                        }
                    }
                    else
                    {


                        if (int.TryParse(textCod.Text, out int id))
                        {
                            var produto = conectionPdv.Produto.Find(id);
                            if (produto != null)
                            {

                                if (pictureFotoProduto.Image != null)
                                {
                                    using (Image imageRedimencionada = ProcessarImagemProduto.RedimensionarImagem(pictureFotoProduto.Image, 200, 200))
                                    {
                                        fotoProduto = ProcessarImagemProduto.ConvertImageByte(imageRedimencionada);
                                    }
                                }
                                else
                                {
                                    fotoProduto = produto.FotoProduto ?? Array.Empty<byte>();
                                }

                                produto.FotoProduto = fotoProduto;
                                produto.Nome = textNomeProd.Text;
                                produto.CodigoBarraEAN = textCodBarraEAN.Text;
                                produto.CodigoBarraAlternativo = textCodBarraAlternativo.Text;
                                produto.Ativo = checkAtivo.Checked;
                                produto.PermitidoDesconto = checkDescontoSim.Checked;
                                produto.GrupoId = (int)comboGrupo.SelectedValue;
                                produto.SubGrupoId = (int)comboSubGrupo.SelectedValue;
                                produto.FornecedorId = int.Parse(textIdFornecedor.Text);
                                produto.DataCadastro = DateTime.Parse(textDataCadastro.Text);
                                produto.DataAtualizacao = DateTime.Now;
                                produto.DataValidade = DateTime.TryParse(textDataValidade.Text, out DateTime dataVal) ? dataVal : (DateTime?)null;
                                produto.Cor = textCor.Text;
                                produto.CodigoBalanca = textCodigoBalanca.Text;
                                produto.MarcaFabricanteId = (int)comboBoxMarcaFabricante.SelectedValue;
                                produto.UnidadeMedidaEntrada = comboUnidadeMedidaEntrada.Text;
                                produto.UnidadeMedidaSaida = comboUnidadeMedidaSaida.Text;
                                produto.TipoProduto = comboBoxTipoProduto.Text;
                                produto.Tamanho = comboBoxTamanho.Text;

                                produto.Margem = decimal.Parse(textMargemCalc.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim(), CultureInfo.InvariantCulture);
                                produto.Lucro = decimal.Parse(textLucro.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim(), CultureInfo.InvariantCulture);
                                produto.PrecoVenda = decimal.Parse(textPrecoVenda.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim(), CultureInfo.InvariantCulture);
                                produto.PrecoCusto = decimal.Parse(textPrecoCusto.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim(), CultureInfo.InvariantCulture);

                                produto.ProdutoBalanca = checkdProdBalança.Checked;

                                produto.PontoReposicao = decimal.Parse(textPontoReposicao.Text.Replace("R$", "").Replace(".", "").Replace(",", "."), CultureInfo.InvariantCulture);
                                produto.QuantidadeMaxima = decimal.Parse(textQuantMaxima.Text.Replace("R$", "").Replace(".", "").Replace(",", "."), CultureInfo.InvariantCulture);
                                produto.Observacao = textObservacao.Text;
                                produto.NcmId = (int)comboBoxNcm.SelectedValue;
                                produto.OrigemMercadoriaId = (int)comboBoxOrigemProd.SelectedValue;
                                produto.CfopId = (int)comboBoxCfop.SelectedValue;
                                produto.CstId = (int)comboBoxCst.SelectedValue;
                                produto.COFINS = string.IsNullOrWhiteSpace(textCOFINS.Text) ? 0m : decimal.Parse(textCOFINS.Text.Replace("R$", "").Replace(".", "").Replace(",", "."), CultureInfo.GetCultureInfo("pt-BR"));
                                produto.PIS = string.IsNullOrWhiteSpace(textPIS.Text) ? 0m : decimal.Parse(textPIS.Text.Replace("R$", "").Replace(".", "").Replace(",", "."), CultureInfo.GetCultureInfo("pt-BR"));
                                produto.ICMS = string.IsNullOrWhiteSpace(textICMS.Text) ? 0m : decimal.Parse(textICMS.Text.Replace("R$", "").Replace(".", "").Replace(",", "."), CultureInfo.GetCultureInfo("pt-BR"));
                                produto.IPI = string.IsNullOrWhiteSpace(textIPI.Text) ? 0m : decimal.Parse(textIPI.Text.Replace("R$", "").Replace(".", "").Replace(",", "."), CultureInfo.GetCultureInfo("pt-BR"));
                                produto.CodigoInterno = int.Parse(textCodInterno.Text);


                                conectionPdv.SaveChanges();
                                MessageBox.Show("Produto atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CarregarProdutosGrid();

                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção ocorreu um erro ao tentar salvar o produto" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {

            try
            {

                if (dataGridProdutos.Rows.Count > 0)
                {

                    // buscar a info pelo id
                    int produtoId = (int)dataGridProdutos.SelectedRows[0].Cells[0].Value;
                    Produto produtoCopiado = conectionPdv.Produto.Find(produtoId);
                    DuplicarProduto(produtoCopiado);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void DuplicarProduto(Produto produto)
        {
            try
            {
                Produto copiarProduto = new Produto
                {
                    // === DADOS BÁSICOS ===
                    Nome = produto.Nome,
                    CodigoInterno = GeradorCodigoInterno.GerarCodigoInterno(conectionPdv),
                    CodigoBarraEAN = produto.CodigoBarraEAN + "_Copia", // evita duplicar código único
                    CodigoBarraAlternativo = GerarCodigoBarra.GerarEAN13(),
                    CodigoBalanca = produto.CodigoBalanca,
                    UnidadeMedidaEntrada = produto.UnidadeMedidaEntrada,
                    UnidadeMedidaSaida = produto.UnidadeMedidaSaida,
                    TipoProduto = produto.TipoProduto,
                    Ativo = produto.Ativo,
                    PermitidoDesconto = produto.PermitidoDesconto,
                    Cor = produto.Cor,
                    Tamanho = produto.Tamanho,
                    Observacao = produto.Observacao,

                    // === RELACIONAMENTOS ===
                    MarcaFabricanteId = produto.MarcaFabricanteId,
                    GrupoId = produto.GrupoId,
                    SubGrupoId = produto.SubGrupoId,
                    FornecedorId = produto.FornecedorId,

                    // === FINANCEIRO ===
                    PrecoCusto = produto.PrecoCusto,
                    PrecoVenda = produto.PrecoVenda,
                    Margem = produto.Margem,
                    Lucro = produto.Lucro,
                    UltimaCompra = produto.UltimaCompra,
                    DataCadastro = DateTime.Now,
                    DataAtualizacao = DateTime.Now,
                    DataValidade = produto.DataValidade,

                    // === FISCAL ===
                    OrigemMercadoriaId = produto.OrigemMercadoriaId,
                    NcmId = produto.NcmId,
                    CfopId = produto.CfopId,
                    CstId = produto.CstId,

                    PIS = produto.PIS,
                    COFINS = produto.COFINS,
                    ICMS = produto.ICMS,
                    IPI = produto.IPI,

                    // === ESTOQUE ===
                    PontoReposicao = produto.PontoReposicao,
                    QuantidadeEstoque = 0, // novo produto começa com estoque zerado
                    QuantidadeMaxima = produto.QuantidadeMaxima,

                    // === FOTO PRODUTO ===
                    FotoProduto = produto.FotoProduto,
                    ProdutoBalanca = produto.ProdutoBalanca,
                };

                conectionPdv.Produto.Add(copiarProduto);
                conectionPdv.SaveChanges();

                MessageBox.Show("Produto duplicado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarProdutosGrid();
            }
            catch (Exception ex)
            {
                // Captura a exceção mais detalhada possível
                var erroDetalhado = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                MessageBox.Show($"Ocorreu um erro ao copiar o registro:\n\n{erroDetalhado}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Selecione a sua imagem";
            openFileDialog1.Filter = "Imagens|*.png;*.jpg;*.jpeg;*.bmp;*.gif;*.webp";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // adiocner a imagem 
                Image image = Image.FromFile(openFileDialog1.FileName);

                pictureFotoProduto.Image = image;
                pictureFotoProduto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnRemoverFoto_Click(object sender, EventArgs e)
        {
            pictureFotoProduto.Dispose();
            pictureFotoProduto.Image = null;
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabCadastro;
            foreach (TabPage page in tabControl1.TabPages)
            {
                HabilitarControles(page.Controls);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridProdutos.Rows.Count > 0)
                {
                    int produtoId = (int)dataGridProdutos.SelectedRows[0].Cells["Id"].Value;
                    Produto produtoEdicao = conectionPdv.Produto.Find(produtoId);
                    if (produtoEdicao != null)
                    {
                        this.AbaCadastroProduto(produtoEdicao);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbaCadastroProduto(Produto produto)
        {
            tabControl1.SelectedTab = tabCadastro;
            foreach (TabPage page in tabControl1.TabPages)
            {
                HabilitarControles(page.Controls);
            }

            if (produto.FotoProduto != null)
            {
                pictureFotoProduto.Image = ProcessarImagemProduto.ConvertFotoImage(produto.FotoProduto);
            }
            textCod.Text = produto.Id.ToString();
            textCodBarraAlternativo.Text = produto.CodigoBarraAlternativo;
            textCodBarraEAN.Text = produto.CodigoBarraEAN;
            textNomeProd.Text = produto.Nome;
            textIdFornecedor.Text = produto.FornecedorId.ToString();
            textCodInterno.Text = produto.CodigoInterno.ToString();
            textCodigoBalanca.Text = produto.CodigoBalanca;
            comboBoxCfop.SelectedValue = produto.CfopId;
            comboBoxCst.SelectedValue = produto.CstId;
            comboBoxCfop.SelectedValue = produto.CfopId;
            comboBoxNcm.SelectedValue = produto.NcmId;
            comboBoxOrigemProd.SelectedValue = produto.OrigemMercadoriaId;
            comboBoxMarcaFabricante.SelectedValue = produto.MarcaFabricanteId;
            comboBoxTamanho.Text = produto.Tamanho;
            comboBoxTipoProduto.Text = produto.TipoProduto;

            comboGrupo.SelectedValue = produto.GrupoId;
            comboSubGrupo.SelectedValue = produto.SubGrupoId;
            textDataCadastro.Text = produto.DataCadastro?.ToString("dd/MM/yyyy") ?? "";
            textDataAtualizacao.Text = produto.DataAtualizacao?.ToString("dd/MM/yyyy") ?? "";
            textDataValidade.Text = produto.DataValidade?.ToString("dd/MM/yyyy") ?? "";
            textCor.Text = produto.Cor;
            textMargemCalc.Text = produto.Margem.ToString("C", new System.Globalization.CultureInfo("pt-BR")) ?? "R$ 0,00";
            textPrecoCusto.Text = produto.PrecoCusto.ToString("C", new System.Globalization.CultureInfo("pt-BR")) ?? "R$ 0,00";
            textPrecoVenda.Text = produto.PrecoVenda.ToString("C", new System.Globalization.CultureInfo("pt-BR")) ?? "R$ 0,00";
            textLucro.Text = produto.Lucro.ToString("C", new System.Globalization.CultureInfo("pt-BR")) ?? "R$ 0,00";

            checkAtivo.Checked = produto.Ativo;
            checkDescontoSim.Checked = produto.PermitidoDesconto;
            textObservacao.Text = produto.Observacao;

            textQuantMaxima.Text = produto.QuantidadeMaxima.ToString("C", new System.Globalization.CultureInfo("pt-BR")) ?? "0,00";
            textQuatidade.Text = produto.QuantidadeEstoque.ToString("C", new System.Globalization.CultureInfo("pt-BR")) ?? "0,00";
            textPontoReposicao.Text = produto.PontoReposicao.ToString("C", new System.Globalization.CultureInfo("pt-BR")) ?? "0,00";


            textPIS.Text = produto.PIS.ToString("C", new System.Globalization.CultureInfo("pt-BR")) ?? "0,00";
            textCOFINS.Text = produto.COFINS.ToString("C", new System.Globalization.CultureInfo("pt-BR")) ?? "0,00";
            textICMS.Text = produto.ICMS.ToString("C", new System.Globalization.CultureInfo("pt-BR")) ?? "0,00";
            textIPI.Text = produto.IPI.ToString("C", new System.Globalization.CultureInfo("pt-BR")) ?? "0,00";
            checkdProdBalança.Checked = produto.ProdutoBalanca;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridProdutos.Rows.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja realmente remover esse registro? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        int produtoId = (int)dataGridProdutos.SelectedRows[0].Cells["Id"].Value;
                        var produtoParaExclusao = conectionPdv.Produto.Find(produtoId);
                        conectionPdv.Remove(produtoParaExclusao);
                        conectionPdv.SaveChanges();
                        MessageBox.Show("Produto deletado com sucesso  ", "Sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        CarregarProdutosGrid();
                        return;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir  o produto: " + ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            }
        }

        private void textDadosPesquisa_TextChanged(object sender, EventArgs e)
        {
            string filtro = comboFiltros?.SelectedItem?.ToString();
            string modelo = comboModelo?.SelectedItem?.ToString();
            string dadosBusca = textDadosPesquisa.Text.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(dadosBusca))
            {
                CarregarProdutosGrid();
                return;
            }

            IQueryable<Produto> query = conectionPdv.Produto
                .Include(p => p.Marca)
                .Include(p => p.Fornecedor)
                .AsQueryable();

            // === FILTROS DE PESQUISA ===
            switch (filtro)
            {
                case "Por Nome":
                    if (modelo == "Inicia Com")
                        query = query.Where(p => p.Nome.ToLower().StartsWith(dadosBusca));
                    else if (modelo == "Termina Com")
                        query = query.Where(p => p.Nome.ToLower().EndsWith(dadosBusca));
                    else if (modelo == "Contem")
                        query = query.Where(p => p.Nome.ToLower().Contains(dadosBusca));
                    break;

                case "Por Código Interno":
                    if (int.TryParse(dadosBusca, out int codigoInterno))
                        query = query.Where(p => p.CodigoInterno == codigoInterno);
                    else
                        query = Enumerable.Empty<Produto>().AsQueryable();
                    break;

                case "Por Código de Barras":
                    query = query.Where(p => p.CodigoBarraEAN != null && p.CodigoBarraEAN.ToLower().Contains(dadosBusca));
                    break;

                case "Por Código de Barras Alternativo":
                    query = query.Where(p => p.CodigoBarraAlternativo != null && p.CodigoBarraAlternativo.ToLower().Contains(dadosBusca));
                    break;

               
            }

            var resultado = query.ToList();
            dataGridProdutos.DataSource = resultado;
        }

    }
}



