namespace ServiTech.Caixa
{
    partial class Pdv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pdv));
            header = new Panel();
            labelDataHora = new Label();
            label1InfoOperador = new Label();
            pictureBoxLogo = new PictureBox();
            panel2 = new Panel();
            content = new Panel();
            textBox1 = new TextBox();
            labelTituloCaixa = new Label();
            btnAbrirGaveta = new Button();
            footer = new Panel();
            btnSair = new Button();
            btnFecharCaixa = new Button();
            btnSangria = new Button();
            btnNovaVenda = new Button();
            btnConsultaProduto = new Button();
            btnCancelarVenda = new Button();
            btnDesconto = new Button();
            btnFinalizaVenda = new Button();
            labelTituloStatusCaixa = new Label();
            textTotal = new TextBox();
            label7 = new Label();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            textReadTotalPreco = new TextBox();
            label4 = new Label();
            textReadPrecoProduto = new TextBox();
            label3 = new Label();
            textReadQuantProduto = new TextBox();
            label2 = new Label();
            textReadCodProduto = new TextBox();
            painelGridProdutos = new Panel();
            textReadCupom = new TextBox();
            gridProdutos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Quant = new DataGridViewTextBoxColumn();
            ValorUni = new DataGridViewTextBoxColumn();
            PreçoTotal = new DataGridViewTextBoxColumn();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            content.SuspendLayout();
            footer.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            painelGridProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdutos).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(0, 66, 100);
            header.BorderStyle = BorderStyle.FixedSingle;
            header.Controls.Add(labelDataHora);
            header.Controls.Add(label1InfoOperador);
            header.Controls.Add(pictureBoxLogo);
            header.Dock = DockStyle.Top;
            header.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            header.ForeColor = Color.White;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1547, 66);
            header.TabIndex = 0;
            // 
            // labelDataHora
            // 
            labelDataHora.BackColor = Color.Transparent;
            labelDataHora.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDataHora.ForeColor = Color.White;
            labelDataHora.Location = new Point(1385, 2);
            labelDataHora.Name = "labelDataHora";
            labelDataHora.Size = new Size(161, 62);
            labelDataHora.TabIndex = 7;
            labelDataHora.Text = "data";
            labelDataHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1InfoOperador
            // 
            label1InfoOperador.AccessibleRole = AccessibleRole.OutlineButton;
            label1InfoOperador.BackColor = Color.Transparent;
            label1InfoOperador.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1InfoOperador.ForeColor = Color.White;
            label1InfoOperador.Image = Properties.Resources.operador_de_telefone;
            label1InfoOperador.ImageAlign = ContentAlignment.MiddleLeft;
            label1InfoOperador.Location = new Point(721, 2);
            label1InfoOperador.Name = "label1InfoOperador";
            label1InfoOperador.Size = new Size(119, 62);
            label1InfoOperador.TabIndex = 3;
            label1InfoOperador.Text = "Operador:";
            label1InfoOperador.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Left;
            pictureBoxLogo.Image = Properties.Resources.imagemlogo;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(97, 64);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 66, 100);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(0, 785);
            panel2.Name = "panel2";
            panel2.Size = new Size(1547, 40);
            panel2.TabIndex = 1;
            // 
            // content
            // 
            content.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            content.BackColor = Color.White;
            content.Controls.Add(textBox1);
            content.Controls.Add(labelTituloCaixa);
            content.Controls.Add(btnAbrirGaveta);
            content.Controls.Add(footer);
            content.Controls.Add(labelTituloStatusCaixa);
            content.Controls.Add(textTotal);
            content.Controls.Add(label7);
            content.Controls.Add(panel4);
            content.Controls.Add(label5);
            content.Controls.Add(textReadTotalPreco);
            content.Controls.Add(label4);
            content.Controls.Add(textReadPrecoProduto);
            content.Controls.Add(label3);
            content.Controls.Add(textReadQuantProduto);
            content.Controls.Add(label2);
            content.Controls.Add(textReadCodProduto);
            content.Controls.Add(painelGridProdutos);
            content.Location = new Point(0, 66);
            content.Name = "content";
            content.Size = new Size(1547, 759);
            content.TabIndex = 2;
            content.Resize += panel3_Resize;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 66, 100);
            textBox1.Dock = DockStyle.Top;
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1547, 72);
            textBox1.TabIndex = 15;
            textBox1.Text = " 1 -Uni Café Santa Clara";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyPress += textReadTotalPreco_KeyPress;
            // 
            // labelTituloCaixa
            // 
            labelTituloCaixa.BackColor = Color.FromArgb(0, 66, 100);
            labelTituloCaixa.BorderStyle = BorderStyle.Fixed3D;
            labelTituloCaixa.Font = new Font("Segoe UI", 26.25F);
            labelTituloCaixa.ForeColor = Color.White;
            labelTituloCaixa.Location = new Point(1, 631);
            labelTituloCaixa.Name = "labelTituloCaixa";
            labelTituloCaixa.Size = new Size(709, 52);
            labelTituloCaixa.TabIndex = 14;
            labelTituloCaixa.Text = "Caixa 01";
            labelTituloCaixa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAbrirGaveta
            // 
            btnAbrirGaveta.BackColor = Color.Transparent;
            btnAbrirGaveta.FlatAppearance.BorderSize = 0;
            btnAbrirGaveta.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAbrirGaveta.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnAbrirGaveta.FlatStyle = FlatStyle.Flat;
            btnAbrirGaveta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbrirGaveta.ForeColor = Color.FromArgb(0, 66, 100);
            btnAbrirGaveta.Image = Properties.Resources.maquina__2_;
            btnAbrirGaveta.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirGaveta.Location = new Point(1363, 95);
            btnAbrirGaveta.Name = "btnAbrirGaveta";
            btnAbrirGaveta.Size = new Size(172, 39);
            btnAbrirGaveta.TabIndex = 5;
            btnAbrirGaveta.TabStop = false;
            btnAbrirGaveta.Text = "Abrir Gaveta F12";
            btnAbrirGaveta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAbrirGaveta.UseVisualStyleBackColor = false;
            // 
            // footer
            // 
            footer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            footer.BackColor = Color.FromArgb(0, 66, 100);
            footer.BorderStyle = BorderStyle.Fixed3D;
            footer.Controls.Add(btnSair);
            footer.Controls.Add(btnFecharCaixa);
            footer.Controls.Add(btnSangria);
            footer.Controls.Add(btnNovaVenda);
            footer.Controls.Add(btnConsultaProduto);
            footer.Controls.Add(btnCancelarVenda);
            footer.Controls.Add(btnDesconto);
            footer.Controls.Add(btnFinalizaVenda);
            footer.Location = new Point(3, 682);
            footer.Name = "footer";
            footer.Size = new Size(1540, 77);
            footer.TabIndex = 13;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.Dock = DockStyle.Right;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9.75F);
            btnSair.ForeColor = Color.White;
            btnSair.Image = Properties.Resources.sair1;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(1439, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(97, 73);
            btnSair.TabIndex = 9;
            btnSair.TabStop = false;
            btnSair.Text = "Sair Esc";
            btnSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += SairPdv_Click;
            // 
            // btnFecharCaixa
            // 
            btnFecharCaixa.BackColor = Color.Transparent;
            btnFecharCaixa.FlatAppearance.BorderSize = 0;
            btnFecharCaixa.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFecharCaixa.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnFecharCaixa.FlatStyle = FlatStyle.Flat;
            btnFecharCaixa.Font = new Font("Segoe UI", 9.75F);
            btnFecharCaixa.ForeColor = Color.White;
            btnFecharCaixa.Image = Properties.Resources.feichamento;
            btnFecharCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnFecharCaixa.Location = new Point(845, 0);
            btnFecharCaixa.Name = "btnFecharCaixa";
            btnFecharCaixa.Size = new Size(187, 73);
            btnFecharCaixa.TabIndex = 8;
            btnFecharCaixa.TabStop = false;
            btnFecharCaixa.Text = "Fechamento do Caixa F7";
            btnFecharCaixa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFecharCaixa.UseVisualStyleBackColor = false;
            // 
            // btnSangria
            // 
            btnSangria.BackColor = Color.Transparent;
            btnSangria.FlatAppearance.BorderSize = 0;
            btnSangria.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSangria.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnSangria.FlatStyle = FlatStyle.Flat;
            btnSangria.Font = new Font("Segoe UI", 9.75F);
            btnSangria.ForeColor = Color.White;
            btnSangria.Image = Properties.Resources.retirada_de_dinheiro;
            btnSangria.ImageAlign = ContentAlignment.MiddleLeft;
            btnSangria.Location = new Point(736, 0);
            btnSangria.Name = "btnSangria";
            btnSangria.Size = new Size(103, 73);
            btnSangria.TabIndex = 7;
            btnSangria.TabStop = false;
            btnSangria.Text = "Sangria F6";
            btnSangria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSangria.UseVisualStyleBackColor = false;
            // 
            // btnNovaVenda
            // 
            btnNovaVenda.BackColor = Color.Transparent;
            btnNovaVenda.FlatAppearance.BorderSize = 0;
            btnNovaVenda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNovaVenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnNovaVenda.FlatStyle = FlatStyle.Flat;
            btnNovaVenda.Font = new Font("Segoe UI", 9.75F);
            btnNovaVenda.ForeColor = Color.White;
            btnNovaVenda.Image = Properties.Resources.carrinho_de_compras1;
            btnNovaVenda.Location = new Point(1, -2);
            btnNovaVenda.Name = "btnNovaVenda";
            btnNovaVenda.Size = new Size(139, 72);
            btnNovaVenda.TabIndex = 4;
            btnNovaVenda.TabStop = false;
            btnNovaVenda.Text = "Nova Venda F1";
            btnNovaVenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovaVenda.UseVisualStyleBackColor = false;
            // 
            // btnConsultaProduto
            // 
            btnConsultaProduto.BackColor = Color.Transparent;
            btnConsultaProduto.FlatAppearance.BorderSize = 0;
            btnConsultaProduto.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnConsultaProduto.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnConsultaProduto.FlatStyle = FlatStyle.Flat;
            btnConsultaProduto.Font = new Font("Segoe UI", 9.75F);
            btnConsultaProduto.ForeColor = Color.White;
            btnConsultaProduto.Image = Properties.Resources.prod;
            btnConsultaProduto.Location = new Point(146, -2);
            btnConsultaProduto.Name = "btnConsultaProduto";
            btnConsultaProduto.Size = new Size(164, 72);
            btnConsultaProduto.TabIndex = 3;
            btnConsultaProduto.TabStop = false;
            btnConsultaProduto.Text = "Consultar Produto F2";
            btnConsultaProduto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultaProduto.UseVisualStyleBackColor = false;
            // 
            // btnCancelarVenda
            // 
            btnCancelarVenda.BackColor = Color.Transparent;
            btnCancelarVenda.FlatAppearance.BorderSize = 0;
            btnCancelarVenda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCancelarVenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnCancelarVenda.FlatStyle = FlatStyle.Flat;
            btnCancelarVenda.Font = new Font("Segoe UI", 9.75F);
            btnCancelarVenda.ForeColor = Color.White;
            btnCancelarVenda.Image = Properties.Resources.cancelar1;
            btnCancelarVenda.Location = new Point(316, -2);
            btnCancelarVenda.Name = "btnCancelarVenda";
            btnCancelarVenda.Size = new Size(150, 72);
            btnCancelarVenda.TabIndex = 2;
            btnCancelarVenda.TabStop = false;
            btnCancelarVenda.Text = "Cancelar Venda F3";
            btnCancelarVenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelarVenda.UseVisualStyleBackColor = false;
            // 
            // btnDesconto
            // 
            btnDesconto.BackColor = Color.Transparent;
            btnDesconto.FlatAppearance.BorderSize = 0;
            btnDesconto.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDesconto.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnDesconto.FlatStyle = FlatStyle.Flat;
            btnDesconto.Font = new Font("Segoe UI", 9.75F);
            btnDesconto.ForeColor = Color.White;
            btnDesconto.Image = Properties.Resources.desconto;
            btnDesconto.Location = new Point(472, -2);
            btnDesconto.Name = "btnDesconto";
            btnDesconto.Size = new Size(134, 72);
            btnDesconto.TabIndex = 1;
            btnDesconto.TabStop = false;
            btnDesconto.Text = "Desc/Acres F4";
            btnDesconto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDesconto.UseVisualStyleBackColor = false;
            // 
            // btnFinalizaVenda
            // 
            btnFinalizaVenda.BackColor = Color.Transparent;
            btnFinalizaVenda.FlatAppearance.BorderSize = 0;
            btnFinalizaVenda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFinalizaVenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 128, 128, 128);
            btnFinalizaVenda.FlatStyle = FlatStyle.Flat;
            btnFinalizaVenda.Font = new Font("Segoe UI", 9.75F);
            btnFinalizaVenda.ForeColor = Color.White;
            btnFinalizaVenda.Image = Properties.Resources.pagar;
            btnFinalizaVenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizaVenda.Location = new Point(602, -2);
            btnFinalizaVenda.Name = "btnFinalizaVenda";
            btnFinalizaVenda.Size = new Size(128, 72);
            btnFinalizaVenda.TabIndex = 0;
            btnFinalizaVenda.TabStop = false;
            btnFinalizaVenda.Text = "Pagamento F5";
            btnFinalizaVenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFinalizaVenda.UseVisualStyleBackColor = false;
            // 
            // labelTituloStatusCaixa
            // 
            labelTituloStatusCaixa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTituloStatusCaixa.BackColor = Color.FromArgb(0, 66, 100);
            labelTituloStatusCaixa.BorderStyle = BorderStyle.Fixed3D;
            labelTituloStatusCaixa.Font = new Font("Segoe UI", 26.25F);
            labelTituloStatusCaixa.ForeColor = Color.White;
            labelTituloStatusCaixa.Location = new Point(707, 631);
            labelTituloStatusCaixa.Name = "labelTituloStatusCaixa";
            labelTituloStatusCaixa.Size = new Size(834, 52);
            labelTituloStatusCaixa.TabIndex = 12;
            labelTituloStatusCaixa.Text = "CAIXA LIVRE";
            labelTituloStatusCaixa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textTotal
            // 
            textTotal.BackColor = Color.FromArgb(0, 66, 100);
            textTotal.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textTotal.ForeColor = Color.White;
            textTotal.Location = new Point(1109, 549);
            textTotal.Multiline = true;
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(432, 77);
            textTotal.TabIndex = 11;
            textTotal.Text = "0,00";
            textTotal.TextAlign = HorizontalAlignment.Center;
            textTotal.TextChanged += MskararCampoMoeda_Changed;
            textTotal.KeyPress += textTotal_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 66, 100);
            label7.Location = new Point(1109, 506);
            label7.Name = "label7";
            label7.Size = new Size(195, 40);
            label7.TabIndex = 10;
            label7.Text = "Total a Pagar";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(1109, 140);
            panel4.Name = "panel4";
            panel4.Size = new Size(426, 359);
            panel4.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.marca;
            pictureBox1.Location = new Point(0, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(426, 313);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(0, 66, 100);
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(426, 46);
            label6.TabIndex = 1;
            label6.Text = "Imagem do Produto";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 66, 100);
            label5.Location = new Point(850, 448);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 8;
            label5.Text = "Preço Total";
            // 
            // textReadTotalPreco
            // 
            textReadTotalPreco.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textReadTotalPreco.Location = new Point(733, 485);
            textReadTotalPreco.Multiline = true;
            textReadTotalPreco.Name = "textReadTotalPreco";
            textReadTotalPreco.PlaceholderText = "0,00";
            textReadTotalPreco.Size = new Size(350, 40);
            textReadTotalPreco.TabIndex = 7;
            textReadTotalPreco.TextAlign = HorizontalAlignment.Center;
            textReadTotalPreco.TextChanged += MskararCampoMoeda_Changed;
            textReadTotalPreco.KeyPress += textReadTotalPreco_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 66, 100);
            label4.Location = new Point(840, 344);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 6;
            label4.Text = "Preço Unitário";
            // 
            // textReadPrecoProduto
            // 
            textReadPrecoProduto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textReadPrecoProduto.Location = new Point(733, 384);
            textReadPrecoProduto.Multiline = true;
            textReadPrecoProduto.Name = "textReadPrecoProduto";
            textReadPrecoProduto.PlaceholderText = "0,00";
            textReadPrecoProduto.Size = new Size(350, 40);
            textReadPrecoProduto.TabIndex = 5;
            textReadPrecoProduto.TextAlign = HorizontalAlignment.Center;
            textReadPrecoProduto.TextChanged += MskararCampoMoeda_Changed;
            textReadPrecoProduto.KeyPress += textReadTotalPreco_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 66, 100);
            label3.Location = new Point(850, 240);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 4;
            label3.Text = "Quantidade";
            // 
            // textReadQuantProduto
            // 
            textReadQuantProduto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textReadQuantProduto.Location = new Point(733, 278);
            textReadQuantProduto.Multiline = true;
            textReadQuantProduto.Name = "textReadQuantProduto";
            textReadQuantProduto.PlaceholderText = "1";
            textReadQuantProduto.Size = new Size(350, 40);
            textReadQuantProduto.TabIndex = 3;
            textReadQuantProduto.TextAlign = HorizontalAlignment.Center;
            textReadQuantProduto.KeyPress += textReadTotalPreco_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 66, 100);
            label2.Location = new Point(760, 140);
            label2.Name = "label2";
            label2.Size = new Size(301, 25);
            label2.TabIndex = 2;
            label2.Text = "Cód de Barra/Descr/Cód Interno";
            // 
            // textReadCodProduto
            // 
            textReadCodProduto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textReadCodProduto.Location = new Point(733, 174);
            textReadCodProduto.Multiline = true;
            textReadCodProduto.Name = "textReadCodProduto";
            textReadCodProduto.PlaceholderText = "0000";
            textReadCodProduto.Size = new Size(350, 40);
            textReadCodProduto.TabIndex = 1;
            textReadCodProduto.TextAlign = HorizontalAlignment.Center;
            textReadCodProduto.Enter += textReadCodProduto_TextChanged;
            // 
            // painelGridProdutos
            // 
            painelGridProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            painelGridProdutos.BackColor = Color.White;
            painelGridProdutos.BorderStyle = BorderStyle.FixedSingle;
            painelGridProdutos.Controls.Add(textReadCupom);
            painelGridProdutos.Controls.Add(gridProdutos);
            painelGridProdutos.Location = new Point(3, 70);
            painelGridProdutos.Name = "painelGridProdutos";
            painelGridProdutos.Size = new Size(707, 561);
            painelGridProdutos.TabIndex = 0;
            // 
            // textReadCupom
            // 
            textReadCupom.Dock = DockStyle.Top;
            textReadCupom.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textReadCupom.ForeColor = Color.FromArgb(0, 66, 100);
            textReadCupom.Location = new Point(0, 0);
            textReadCupom.Name = "textReadCupom";
            textReadCupom.Size = new Size(705, 39);
            textReadCupom.TabIndex = 2;
            textReadCupom.Text = "Cupom";
            textReadCupom.TextAlign = HorizontalAlignment.Center;
            textReadCupom.UseWaitCursor = true;
            textReadCupom.KeyPress += textTotal_KeyPress;
            // 
            // gridProdutos
            // 
            gridProdutos.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            gridProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridProdutos.BackgroundColor = Color.LightGray;
            gridProdutos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 66, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridProdutos.ColumnHeadersHeight = 35;
            gridProdutos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descricao, Quant, ValorUni, PreçoTotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 66, 100);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            gridProdutos.EnableHeadersVisualStyles = false;
            gridProdutos.GridColor = Color.LightGray;
            gridProdutos.Location = new Point(2, 39);
            gridProdutos.Name = "gridProdutos";
            gridProdutos.ReadOnly = true;
            gridProdutos.RowHeadersVisible = false;
            gridProdutos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridProdutos.Size = new Size(703, 516);
            gridProdutos.TabIndex = 0;
            gridProdutos.Paint += CarregarMarcaDgua_Paint;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 80;
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 300;
            // 
            // Quant
            // 
            Quant.HeaderText = "Quant.";
            Quant.Name = "Quant";
            Quant.ReadOnly = true;
            Quant.Width = 80;
            // 
            // ValorUni
            // 
            ValorUni.HeaderText = "Valor Unit.";
            ValorUni.Name = "ValorUni";
            ValorUni.ReadOnly = true;
            ValorUni.Width = 120;
            // 
            // PreçoTotal
            // 
            PreçoTotal.HeaderText = "Preço Total";
            PreçoTotal.Name = "PreçoTotal";
            PreçoTotal.ReadOnly = true;
            PreçoTotal.Width = 120;
            // 
            // Pdv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 825);
            Controls.Add(content);
            Controls.Add(panel2);
            Controls.Add(header);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Pdv";
            KeyDown += CapturaTecla;
            header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            content.ResumeLayout(false);
            content.PerformLayout();
            footer.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            painelGridProdutos.ResumeLayout(false);
            painelGridProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Panel panel2;
        private Panel content;
        private Panel painelGridProdutos;
        private DataGridView gridProdutos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Quant;
        private DataGridViewTextBoxColumn ValorUni;
        private DataGridViewTextBoxColumn PreçoTotal;
        private Label label2;
        private TextBox textReadCodProduto;
        private Label label5;
        private TextBox textReadTotalPreco;
        private Label label4;
        private TextBox textReadPrecoProduto;
        private Label label3;
        private TextBox textReadQuantProduto;
        private Panel panel4;
        private Label label6;
        private PictureBox pictureBox1;
        private Label labelTituloStatusCaixa;
        private TextBox textTotal;
        private Label label7;
        private Panel footer;
        private PictureBox pictureBoxLogo;
        private TextBox textReadCupom;
        private Button btnConsultaProduto;
        private Button btnCancelarVenda;
        private Button btnDesconto;
        private Button btnFinalizaVenda;
        private Button btnNovaVenda;
        private Button btnAbrirGaveta;
        private Label label1InfoOperador;
        private Label labelDataHora;
        private Button btnSangria;
        private Button btnFecharCaixa;
        private Button btnSair;
        private Label labelTituloCaixa;
        private TextBox textBox1;
    }
}