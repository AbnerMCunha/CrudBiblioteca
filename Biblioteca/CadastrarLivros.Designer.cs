namespace Biblioteca
{
    partial class CadastrarLivros
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
            this.RBindisponivel = new System.Windows.Forms.RadioButton();
            this.RBdisponivel = new System.Windows.Forms.RadioButton();
            this.TXTautor = new System.Windows.Forms.TextBox();
            this.TXTano = new System.Windows.Forms.TextBox();
            this.TXTnomeLivro = new System.Windows.Forms.TextBox();
            this.EPerro = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Label();
            this.LBnomeLivro = new System.Windows.Forms.Label();
            this.BTNvoltar = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BTNcancelar = new System.Windows.Forms.ToolStripLabel();
            this.BTNgravar = new System.Windows.Forms.ToolStripLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TXTpag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTgenero = new System.Windows.Forms.TextBox();
            this.TTXeditora = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EPerro)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RBindisponivel
            // 
            this.RBindisponivel.AutoSize = true;
            this.RBindisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBindisponivel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RBindisponivel.Location = new System.Drawing.Point(273, 225);
            this.RBindisponivel.Name = "RBindisponivel";
            this.RBindisponivel.Size = new System.Drawing.Size(98, 20);
            this.RBindisponivel.TabIndex = 31;
            this.RBindisponivel.Text = "Indisopnível";
            this.RBindisponivel.UseVisualStyleBackColor = true;
            // 
            // RBdisponivel
            // 
            this.RBdisponivel.AutoSize = true;
            this.RBdisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBdisponivel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RBdisponivel.Location = new System.Drawing.Point(156, 225);
            this.RBdisponivel.Name = "RBdisponivel";
            this.RBdisponivel.Size = new System.Drawing.Size(90, 20);
            this.RBdisponivel.TabIndex = 30;
            this.RBdisponivel.Text = "Disponível";
            this.RBdisponivel.UseVisualStyleBackColor = true;
            // 
            // TXTautor
            // 
            this.TXTautor.Location = new System.Drawing.Point(156, 85);
            this.TXTautor.Name = "TXTautor";
            this.TXTautor.Size = new System.Drawing.Size(257, 20);
            this.TXTautor.TabIndex = 28;
            // 
            // TXTano
            // 
            this.TXTano.Location = new System.Drawing.Point(156, 116);
            this.TXTano.Name = "TXTano";
            this.TXTano.Size = new System.Drawing.Size(76, 20);
            this.TXTano.TabIndex = 27;
            this.TXTano.TextChanged += new System.EventHandler(this.TXTano_TextChanged);
            // 
            // TXTnomeLivro
            // 
            this.TXTnomeLivro.Location = new System.Drawing.Point(156, 53);
            this.TXTnomeLivro.Name = "TXTnomeLivro";
            this.TXTnomeLivro.Size = new System.Drawing.Size(257, 20);
            this.TXTnomeLivro.TabIndex = 26;
            // 
            // EPerro
            // 
            this.EPerro.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.EPerro.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(36, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(36, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Editora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(36, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ano:";
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Autor.Location = new System.Drawing.Point(36, 92);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(42, 16);
            this.Autor.TabIndex = 21;
            this.Autor.Text = "Autor:";
            // 
            // LBnomeLivro
            // 
            this.LBnomeLivro.AutoSize = true;
            this.LBnomeLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBnomeLivro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBnomeLivro.Location = new System.Drawing.Point(36, 60);
            this.LBnomeLivro.Name = "LBnomeLivro";
            this.LBnomeLivro.Size = new System.Drawing.Size(80, 16);
            this.LBnomeLivro.TabIndex = 20;
            this.LBnomeLivro.Text = "Nome Livro:";
            // 
            // BTNvoltar
            // 
            this.BTNvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNvoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNvoltar.Name = "BTNvoltar";
            this.BTNvoltar.Size = new System.Drawing.Size(43, 22);
            this.BTNvoltar.Text = "Voltar";
            this.BTNvoltar.Click += new System.EventHandler(this.BTNvoltar_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNvoltar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 290);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(484, 25);
            this.toolStrip2.TabIndex = 19;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BTNcancelar
            // 
            this.BTNcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNcancelar.Name = "BTNcancelar";
            this.BTNcancelar.Size = new System.Drawing.Size(120, 22);
            this.BTNcancelar.Text = "Cancelar Cadastro";
            // 
            // BTNgravar
            // 
            this.BTNgravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNgravar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNgravar.Name = "BTNgravar";
            this.BTNgravar.Size = new System.Drawing.Size(93, 22);
            this.BTNgravar.Text = "Gravar Dados";
            this.BTNgravar.Click += new System.EventHandler(this.BTNgravar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(36, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Genero:";
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
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TXTpag
            // 
            this.TXTpag.Location = new System.Drawing.Point(337, 116);
            this.TXTpag.Name = "TXTpag";
            this.TXTpag.Size = new System.Drawing.Size(76, 20);
            this.TXTpag.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(270, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Paginas:";
            // 
            // TXTgenero
            // 
            this.TXTgenero.Location = new System.Drawing.Point(156, 152);
            this.TXTgenero.Name = "TXTgenero";
            this.TXTgenero.Size = new System.Drawing.Size(257, 20);
            this.TXTgenero.TabIndex = 35;
            // 
            // TTXeditora
            // 
            this.TTXeditora.Location = new System.Drawing.Point(156, 186);
            this.TTXeditora.Name = "TTXeditora";
            this.TTXeditora.Size = new System.Drawing.Size(257, 20);
            this.TTXeditora.TabIndex = 36;
            // 
            // CadastrarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(484, 315);
            this.Controls.Add(this.TTXeditora);
            this.Controls.Add(this.TXTgenero);
            this.Controls.Add(this.TXTpag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBindisponivel);
            this.Controls.Add(this.RBdisponivel);
            this.Controls.Add(this.TXTautor);
            this.Controls.Add(this.TXTano);
            this.Controls.Add(this.TXTnomeLivro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.LBnomeLivro);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CadastrarLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarLivros";
            this.Load += new System.EventHandler(this.CadastrarLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EPerro)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RBindisponivel;
        private System.Windows.Forms.RadioButton RBdisponivel;
        private System.Windows.Forms.TextBox TXTautor;
        private System.Windows.Forms.TextBox TXTano;
        private System.Windows.Forms.TextBox TXTnomeLivro;
        private System.Windows.Forms.ErrorProvider EPerro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.Label LBnomeLivro;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel BTNvoltar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel BTNgravar;
        public System.Windows.Forms.ToolStripLabel BTNcancelar;
        private System.Windows.Forms.TextBox TTXeditora;
        private System.Windows.Forms.TextBox TXTgenero;
        private System.Windows.Forms.TextBox TXTpag;
        private System.Windows.Forms.Label label1;
    }
}