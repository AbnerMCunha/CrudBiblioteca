namespace LibrarySystem
{
    partial class frmAlterarLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarLivros));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtnGravar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.rbtIndisponivel = new System.Windows.Forms.RadioButton();
            this.rbtDisponivel = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblNomeLivro = new System.Windows.Forms.Label();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.epErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnGravar,
            this.tsbtnCancelar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 197);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(517, 55);
            this.toolStrip2.TabIndex = 27;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbtnGravar
            // 
            this.tsbtnGravar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGravar.Image")));
            this.tsbtnGravar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGravar.Name = "tsbtnGravar";
            this.tsbtnGravar.Size = new System.Drawing.Size(151, 52);
            this.tsbtnGravar.Text = "Gravar Alterações";
            this.tsbtnGravar.Click += new System.EventHandler(this.tsbtnGravar_Click);
            // 
            // tsbtnCancelar
            // 
            this.tsbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancelar.Image")));
            this.tsbtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancelar.Name = "tsbtnCancelar";
            this.tsbtnCancelar.Size = new System.Drawing.Size(163, 52);
            this.tsbtnCancelar.Text = "Cancelar Alterações";
            this.tsbtnCancelar.Click += new System.EventHandler(this.tsbtnCancelar_Click);
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(157, 135);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(260, 20);
            this.txtEditora.TabIndex = 46;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(157, 103);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(260, 20);
            this.txtGenero.TabIndex = 45;
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPaginas.Location = new System.Drawing.Point(266, 72);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(151, 18);
            this.lblPaginas.TabIndex = 44;
            this.lblPaginas.Text = "Número de Páginas:";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(445, 72);
            this.txtPaginas.MaxLength = 4;
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(60, 20);
            this.txtPaginas.TabIndex = 43;
            // 
            // rbtIndisponivel
            // 
            this.rbtIndisponivel.AutoSize = true;
            this.rbtIndisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtIndisponivel.Location = new System.Drawing.Point(239, 169);
            this.rbtIndisponivel.Name = "rbtIndisponivel";
            this.rbtIndisponivel.Size = new System.Drawing.Size(83, 17);
            this.rbtIndisponivel.TabIndex = 41;
            this.rbtIndisponivel.Text = "Indisponível";
            this.rbtIndisponivel.UseVisualStyleBackColor = true;
            // 
            // rbtDisponivel
            // 
            this.rbtDisponivel.AutoSize = true;
            this.rbtDisponivel.Checked = true;
            this.rbtDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDisponivel.Location = new System.Drawing.Point(157, 169);
            this.rbtDisponivel.Name = "rbtDisponivel";
            this.rbtDisponivel.Size = new System.Drawing.Size(76, 17);
            this.rbtDisponivel.TabIndex = 42;
            this.rbtDisponivel.TabStop = true;
            this.rbtDisponivel.Text = "Disponível";
            this.rbtDisponivel.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F);
            this.lblStatus.Location = new System.Drawing.Point(12, 169);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 18);
            this.lblStatus.TabIndex = 38;
            this.lblStatus.Text = "Status:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEditora.Location = new System.Drawing.Point(12, 135);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(63, 18);
            this.lblEditora.TabIndex = 37;
            this.lblEditora.Text = "Editora:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Arial", 12F);
            this.lblGenero.Location = new System.Drawing.Point(13, 103);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 18);
            this.lblGenero.TabIndex = 40;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAno.Location = new System.Drawing.Point(13, 72);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(40, 18);
            this.lblAno.TabIndex = 39;
            this.lblAno.Text = "Ano:";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(157, 72);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(60, 20);
            this.txtAno.TabIndex = 36;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAutor.Location = new System.Drawing.Point(13, 41);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(49, 18);
            this.lblAutor.TabIndex = 35;
            this.lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(157, 41);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(348, 20);
            this.txtAutor.TabIndex = 34;
            // 
            // lblNomeLivro
            // 
            this.lblNomeLivro.AutoSize = true;
            this.lblNomeLivro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLivro.Location = new System.Drawing.Point(13, 10);
            this.lblNomeLivro.Name = "lblNomeLivro";
            this.lblNomeLivro.Size = new System.Drawing.Size(114, 18);
            this.lblNomeLivro.TabIndex = 33;
            this.lblNomeLivro.Text = "Nome do Livro:";
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(157, 9);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(348, 20);
            this.txtNomeLivro.TabIndex = 32;
            // 
            // epErro
            // 
            this.epErro.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epErro.ContainerControl = this;
            // 
            // frmAlterarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 252);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.rbtIndisponivel);
            this.Controls.Add(this.rbtDisponivel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblNomeLivro);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.toolStrip2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Livros";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAlterarLivros_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        public System.Windows.Forms.ToolStripButton tsbtnGravar;
        public System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.RadioButton rbtIndisponivel;
        private System.Windows.Forms.RadioButton rbtDisponivel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblNomeLivro;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.ErrorProvider epErro;
    }
}