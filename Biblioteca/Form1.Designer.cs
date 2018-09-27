namespace Biblioteca
{
    partial class Biblioteca
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biblioteca));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTNlivros = new System.Windows.Forms.ToolStripLabel();
            this.BTNclientes = new System.Windows.Forms.ToolStripLabel();
            this.BTNFunc = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BTNsair = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNlivros,
            this.BTNclientes,
            this.BTNFunc});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(847, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTNlivros
            // 
            this.BTNlivros.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BTNlivros.Name = "BTNlivros";
            this.BTNlivros.Size = new System.Drawing.Size(45, 22);
            this.BTNlivros.Text = "Livros";
            this.BTNlivros.Click += new System.EventHandler(this.BTNlivros_Click);
            // 
            // BTNclientes
            // 
            this.BTNclientes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTNclientes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BTNclientes.Name = "BTNclientes";
            this.BTNclientes.Size = new System.Drawing.Size(57, 22);
            this.BTNclientes.Text = "Clientes";
            this.BTNclientes.Click += new System.EventHandler(this.BTNclientes_Click);
            // 
            // BTNFunc
            // 
            this.BTNFunc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BTNFunc.Name = "BTNFunc";
            this.BTNFunc.Size = new System.Drawing.Size(86, 22);
            this.BTNFunc.Text = "Funcionarios";
            this.BTNFunc.Click += new System.EventHandler(this.BTNFunc_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNsair});
            this.toolStrip2.Location = new System.Drawing.Point(0, 476);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(847, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BTNsair
            // 
            this.BTNsair.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BTNsair.Name = "BTNsair";
            this.BTNsair.Size = new System.Drawing.Size(31, 22);
            this.BTNsair.Text = "Sair";
            this.BTNsair.Click += new System.EventHandler(this.BTNsair_Click);
            // 
            // Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Biblioteca.Properties.Resources.old_books_facebook_cover_timeline_banner_for_fb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 501);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Biblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Biblioteca_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel BTNclientes;
        private System.Windows.Forms.ToolStripLabel BTNFunc;
        private System.Windows.Forms.ToolStripLabel BTNlivros;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel BTNsair;
    }
}

