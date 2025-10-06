namespace ServiTech.Forms.Cadastros
{
    partial class CadastrarBalcaoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarBalcaoCaixa));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            textCod = new TextBox();
            label4 = new Label();
            textNome = new TextBox();
            label10 = new Label();
            panel1 = new Panel();
            btnNovo = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            btnBuscaBairro = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(741, 194);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(733, 166);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastrar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscaBairro);
            groupBox1.Controls.Add(textCod);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textNome);
            groupBox1.Controls.Add(label10);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(727, 75);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            // 
            // textCod
            // 
            textCod.Location = new Point(5, 38);
            textCod.Name = "textCod";
            textCod.ReadOnly = true;
            textCod.Size = new Size(86, 23);
            textCod.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 50;
            label4.Text = "Codigo";
            // 
            // textNome
            // 
            textNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textNome.Location = new Point(97, 39);
            textNome.Name = "textNome";
            textNome.ReadOnly = true;
            textNome.Size = new Size(586, 23);
            textNome.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F);
            label10.ForeColor = Color.FromArgb(44, 62, 80);
            label10.Location = new Point(97, 20);
            label10.Name = "label10";
            label10.Size = new Size(140, 16);
            label10.TabIndex = 41;
            label10.Text = "Nome do Caixa/Balcão";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnCancelar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 52);
            panel1.TabIndex = 44;
            // 
            // btnNovo
            // 
            btnNovo.Image = Properties.Resources.crio;
            btnNovo.Location = new Point(11, 7);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(78, 40);
            btnNovo.TabIndex = 18;
            btnNovo.Text = "Incluir F4";
            btnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnGravar
            // 
            btnGravar.Image = Properties.Resources.salvar;
            btnGravar.Location = new Point(95, 7);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(80, 40);
            btnGravar.TabIndex = 16;
            btnGravar.Text = "Gravar F5";
            btnGravar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(181, 7);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 40);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar F6";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBuscaBairro
            // 
            btnBuscaBairro.BackColor = Color.Transparent;
            btnBuscaBairro.Enabled = false;
            btnBuscaBairro.FlatAppearance.BorderSize = 0;
            btnBuscaBairro.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBuscaBairro.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBuscaBairro.FlatStyle = FlatStyle.Flat;
            btnBuscaBairro.Image = Properties.Resources.lupa;
            btnBuscaBairro.Location = new Point(689, 39);
            btnBuscaBairro.Name = "btnBuscaBairro";
            btnBuscaBairro.Size = new Size(26, 23);
            btnBuscaBairro.TabIndex = 160;
            btnBuscaBairro.UseVisualStyleBackColor = false;
            // 
            // CadastrarBalcaoCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 194);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastrarBalcaoCaixa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Caixa/Balcão";
            KeyDown += CadastrarBalcao_KeyDown;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel1;
        private Button btnNovo;
        private Button btnGravar;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private TextBox textNome;
        private Label label10;
        private TextBox textCod;
        private Label label4;
        private Button btnBuscaBairro;
    }
}