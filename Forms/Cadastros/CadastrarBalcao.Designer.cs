namespace ServiTech.Forms.Cadastros
{
    partial class CadastrarBalcao
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            btnNovo = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            textNomeCargo = new TextBox();
            label10 = new Label();
            textCodigoCargo = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(810, 352);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(textNomeCargo);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(textCodigoCargo);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(802, 324);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastrar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(btnCancelar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 269);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 52);
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
            // textNomeCargo
            // 
            textNomeCargo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textNomeCargo.Location = new Point(78, 34);
            textNomeCargo.Name = "textNomeCargo";
            textNomeCargo.ReadOnly = true;
            textNomeCargo.Size = new Size(705, 23);
            textNomeCargo.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F);
            label10.ForeColor = Color.FromArgb(44, 62, 80);
            label10.Location = new Point(78, 14);
            label10.Name = "label10";
            label10.Size = new Size(65, 16);
            label10.TabIndex = 37;
            label10.Text = "Descriçao";
            // 
            // textCodigoCargo
            // 
            textCodigoCargo.Location = new Point(8, 34);
            textCodigoCargo.Name = "textCodigoCargo";
            textCodigoCargo.ReadOnly = true;
            textCodigoCargo.Size = new Size(64, 23);
            textCodigoCargo.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(8, 14);
            label1.Name = "label1";
            label1.Size = new Size(47, 16);
            label1.TabIndex = 35;
            label1.Text = "Codigo";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(802, 324);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // CadastrarBalcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 352);
            Controls.Add(tabControl1);
            KeyPreview = true;
            Name = "CadastrarBalcao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Caixa/Balcão";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textNomeCargo;
        private Label label10;
        private TextBox textCodigoCargo;
        private Label label1;
        private Panel panel1;
        private Button btnNovo;
        private Button btnGravar;
        private Button btnCancelar;
        private TabPage tabPage2;
    }
}