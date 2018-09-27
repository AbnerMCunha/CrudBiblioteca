namespace Biblioteca
{
    partial class CadastrarClientes
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTNgravar = new System.Windows.Forms.ToolStripLabel();
            this.BTNcancelar = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BTNvoltar = new System.Windows.Forms.ToolStripLabel();
            this.LBnome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTnome = new System.Windows.Forms.TextBox();
            this.TXTcidade = new System.Windows.Forms.TextBox();
            this.TXTend = new System.Windows.Forms.TextBox();
            this.MTBtelefone = new System.Windows.Forms.MaskedTextBox();
            this.RBdisponivel = new System.Windows.Forms.RadioButton();
            this.RBindisponivel = new System.Windows.Forms.RadioButton();
            this.EPerro = new System.Windows.Forms.ErrorProvider(this.components);
            this.CBBestado = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPerro)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNgravar,
            this.BTNcancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(484, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTNgravar
            // 
            this.BTNgravar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BTNgravar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNgravar.Name = "BTNgravar";
            this.BTNgravar.Size = new System.Drawing.Size(93, 22);
            this.BTNgravar.Text = "Gravar Dados";
            this.BTNgravar.Click += new System.EventHandler(this.BTNgravar_Click);
            // 
            // BTNcancelar
            // 
            this.BTNcancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BTNcancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNcancelar.Name = "BTNcancelar";
            this.BTNcancelar.Size = new System.Drawing.Size(120, 22);
            this.BTNcancelar.Text = "Cancelar Cadastro";
            this.BTNcancelar.Click += new System.EventHandler(this.BTNcancelar_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNvoltar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 285);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(484, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BTNvoltar
            // 
            this.BTNvoltar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BTNvoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNvoltar.Name = "BTNvoltar";
            this.BTNvoltar.Size = new System.Drawing.Size(45, 22);
            this.BTNvoltar.Text = "Voltar";
            this.BTNvoltar.Click += new System.EventHandler(this.BTNvoltar_Click);
            // 
            // LBnome
            // 
            this.LBnome.AutoSize = true;
            this.LBnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBnome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBnome.Location = new System.Drawing.Point(42, 55);
            this.LBnome.Name = "LBnome";
            this.LBnome.Size = new System.Drawing.Size(112, 17);
            this.LBnome.TabIndex = 2;
            this.LBnome.Text = "Nome Completo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(42, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(42, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(42, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(42, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(42, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefone:";
            // 
            // TXTnome
            // 
            this.TXTnome.Location = new System.Drawing.Point(167, 55);
            this.TXTnome.Name = "TXTnome";
            this.TXTnome.Size = new System.Drawing.Size(257, 20);
            this.TXTnome.TabIndex = 10;
            // 
            // TXTcidade
            // 
            this.TXTcidade.Location = new System.Drawing.Point(167, 118);
            this.TXTcidade.Name = "TXTcidade";
            this.TXTcidade.Size = new System.Drawing.Size(257, 20);
            this.TXTcidade.TabIndex = 12;
            // 
            // TXTend
            // 
            this.TXTend.Location = new System.Drawing.Point(167, 87);
            this.TXTend.Name = "TXTend";
            this.TXTend.Size = new System.Drawing.Size(257, 20);
            this.TXTend.TabIndex = 11;
            // 
            // MTBtelefone
            // 
            this.MTBtelefone.Location = new System.Drawing.Point(167, 188);
            this.MTBtelefone.Mask = "(99) 00000-0000";
            this.MTBtelefone.Name = "MTBtelefone";
            this.MTBtelefone.Size = new System.Drawing.Size(151, 20);
            this.MTBtelefone.TabIndex = 14;
            // 
            // RBdisponivel
            // 
            this.RBdisponivel.AutoSize = true;
            this.RBdisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBdisponivel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RBdisponivel.Location = new System.Drawing.Point(162, 220);
            this.RBdisponivel.Name = "RBdisponivel";
            this.RBdisponivel.Size = new System.Drawing.Size(91, 21);
            this.RBdisponivel.TabIndex = 14;
            this.RBdisponivel.Text = "Disponível";
            this.RBdisponivel.UseVisualStyleBackColor = true;
            // 
            // RBindisponivel
            // 
            this.RBindisponivel.AutoSize = true;
            this.RBindisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBindisponivel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RBindisponivel.Location = new System.Drawing.Point(279, 220);
            this.RBindisponivel.Name = "RBindisponivel";
            this.RBindisponivel.Size = new System.Drawing.Size(100, 21);
            this.RBindisponivel.TabIndex = 14;
            this.RBindisponivel.Text = "Indisponível";
            this.RBindisponivel.UseVisualStyleBackColor = true;
            // 
            // EPerro
            // 
            this.EPerro.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.EPerro.ContainerControl = this;
            // 
            // CBBestado
            // 
            this.CBBestado.FormattingEnabled = true;
            this.CBBestado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.CBBestado.Location = new System.Drawing.Point(167, 149);
            this.CBBestado.Name = "CBBestado";
            this.CBBestado.Size = new System.Drawing.Size(76, 21);
            this.CBBestado.TabIndex = 13;
            this.CBBestado.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // CadastrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(484, 310);
            this.Controls.Add(this.CBBestado);
            this.Controls.Add(this.RBindisponivel);
            this.Controls.Add(this.RBdisponivel);
            this.Controls.Add(this.MTBtelefone);
            this.Controls.Add(this.TXTend);
            this.Controls.Add(this.TXTcidade);
            this.Controls.Add(this.TXTnome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBnome);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CadastrarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Clientes";
            this.Load += new System.EventHandler(this.CadastrarClientes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPerro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel BTNvoltar;
        public System.Windows.Forms.ToolStripLabel BTNgravar;
        public System.Windows.Forms.ToolStripLabel BTNcancelar;
        private System.Windows.Forms.Label LBnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTnome;
        private System.Windows.Forms.TextBox TXTcidade;
        private System.Windows.Forms.TextBox TXTend;
        private System.Windows.Forms.MaskedTextBox MTBtelefone;
        private System.Windows.Forms.RadioButton RBdisponivel;
        private System.Windows.Forms.RadioButton RBindisponivel;
        private System.Windows.Forms.ErrorProvider EPerro;
        private System.Windows.Forms.ComboBox CBBestado;
    }
}