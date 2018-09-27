namespace Biblioteca
{
    partial class Livros
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTNaltExc = new System.Windows.Forms.ToolStripLabel();
            this.BTNcadastrar = new System.Windows.Forms.ToolStripLabel();
            this.BTNconsultar = new System.Windows.Forms.ToolStripLabel();
            this.BTNvoltar = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BTNsair = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNaltExc,
            this.BTNcadastrar,
            this.BTNconsultar,
            this.BTNvoltar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(943, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTNaltExc
            // 
            this.BTNaltExc.Name = "BTNaltExc";
            this.BTNaltExc.Size = new System.Drawing.Size(84, 22);
            this.BTNaltExc.Text = "Alterar/Excluir ";
            this.BTNaltExc.Click += new System.EventHandler(this.BTNaltExc_Click);
            // 
            // BTNcadastrar
            // 
            this.BTNcadastrar.Name = "BTNcadastrar";
            this.BTNcadastrar.Size = new System.Drawing.Size(57, 22);
            this.BTNcadastrar.Text = "Cadastrar";
            this.BTNcadastrar.Click += new System.EventHandler(this.BTNcadastrar_Click_1);
            // 
            // BTNconsultar
            // 
            this.BTNconsultar.Name = "BTNconsultar";
            this.BTNconsultar.Size = new System.Drawing.Size(58, 22);
            this.BTNconsultar.Text = "Consultar";
            this.BTNconsultar.Click += new System.EventHandler(this.BTNconsultar_Click);
            // 
            // BTNvoltar
            // 
            this.BTNvoltar.Name = "BTNvoltar";
            this.BTNvoltar.Size = new System.Drawing.Size(37, 22);
            this.BTNvoltar.Text = "Voltar";
            this.BTNvoltar.Click += new System.EventHandler(this.BTNvoltar_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNsair});
            this.toolStrip2.Location = new System.Drawing.Point(0, 620);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(943, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BTNsair
            // 
            this.BTNsair.Name = "BTNsair";
            this.BTNsair.Size = new System.Drawing.Size(26, 22);
            this.BTNsair.Text = "Sair";
            this.BTNsair.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 645);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "Livros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livros";
            this.Load += new System.EventHandler(this.Livros_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel BTNaltExc;
        public System.Windows.Forms.ToolStripLabel BTNcadastrar;
        public System.Windows.Forms.ToolStripLabel BTNconsultar;
        public System.Windows.Forms.ToolStripLabel BTNvoltar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel BTNsair;
    }
}