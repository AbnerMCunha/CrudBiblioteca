namespace Biblioteca
{
    partial class ConsultarLivros
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
            this.BTNvoltar = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.GPBopcoes = new System.Windows.Forms.GroupBox();
            this.RBstatus = new System.Windows.Forms.RadioButton();
            this.RBnomeLivro = new System.Windows.Forms.RadioButton();
            this.RBdisponivel = new System.Windows.Forms.RadioButton();
            this.BTNconsultar = new System.Windows.Forms.Button();
            this.RBindisponivel = new System.Windows.Forms.RadioButton();
            this.LVdados = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.GPBopcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LVdados)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNvoltar
            // 
            this.BTNvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNvoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNvoltar.Name = "BTNvoltar";
            this.BTNvoltar.Size = new System.Drawing.Size(43, 22);
            this.BTNvoltar.Text = "Voltar";
            this.BTNvoltar.Click += new System.EventHandler(this.BTNvoltar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNvoltar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 336);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(544, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // GPBopcoes
            // 
            this.GPBopcoes.Controls.Add(this.RBstatus);
            this.GPBopcoes.Controls.Add(this.RBnomeLivro);
            this.GPBopcoes.Location = new System.Drawing.Point(12, 6);
            this.GPBopcoes.Name = "GPBopcoes";
            this.GPBopcoes.Size = new System.Drawing.Size(169, 87);
            this.GPBopcoes.TabIndex = 17;
            this.GPBopcoes.TabStop = false;
            this.GPBopcoes.Text = "Filtro";
            // 
            // RBstatus
            // 
            this.RBstatus.AutoSize = true;
            this.RBstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBstatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RBstatus.Location = new System.Drawing.Point(6, 55);
            this.RBstatus.Name = "RBstatus";
            this.RBstatus.Size = new System.Drawing.Size(63, 20);
            this.RBstatus.TabIndex = 2;
            this.RBstatus.Text = "Status";
            this.RBstatus.UseVisualStyleBackColor = true;
            this.RBstatus.CheckedChanged += new System.EventHandler(this.RBstatus_CheckedChanged);
            // 
            // RBnomeLivro
            // 
            this.RBnomeLivro.AutoSize = true;
            this.RBnomeLivro.Checked = true;
            this.RBnomeLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBnomeLivro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RBnomeLivro.Location = new System.Drawing.Point(6, 19);
            this.RBnomeLivro.Name = "RBnomeLivro";
            this.RBnomeLivro.Size = new System.Drawing.Size(130, 20);
            this.RBnomeLivro.TabIndex = 0;
            this.RBnomeLivro.TabStop = true;
            this.RBnomeLivro.Text = "Ordem Alfabetica";
            this.RBnomeLivro.UseVisualStyleBackColor = true;
            // 
            // RBdisponivel
            // 
            this.RBdisponivel.AutoSize = true;
            this.RBdisponivel.Checked = true;
            this.RBdisponivel.Enabled = false;
            this.RBdisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBdisponivel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RBdisponivel.Location = new System.Drawing.Point(204, 38);
            this.RBdisponivel.Name = "RBdisponivel";
            this.RBdisponivel.Size = new System.Drawing.Size(90, 20);
            this.RBdisponivel.TabIndex = 20;
            this.RBdisponivel.TabStop = true;
            this.RBdisponivel.Text = "Disponivel";
            this.RBdisponivel.UseVisualStyleBackColor = true;
            // 
            // BTNconsultar
            // 
            this.BTNconsultar.BackColor = System.Drawing.Color.PowderBlue;
            this.BTNconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNconsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNconsultar.Location = new System.Drawing.Point(420, 17);
            this.BTNconsultar.Name = "BTNconsultar";
            this.BTNconsultar.Size = new System.Drawing.Size(103, 37);
            this.BTNconsultar.TabIndex = 19;
            this.BTNconsultar.Text = "Consultar";
            this.BTNconsultar.UseVisualStyleBackColor = false;
            this.BTNconsultar.Click += new System.EventHandler(this.BTNconsultar_Click);
            // 
            // RBindisponivel
            // 
            this.RBindisponivel.AutoSize = true;
            this.RBindisponivel.Enabled = false;
            this.RBindisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBindisponivel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RBindisponivel.Location = new System.Drawing.Point(204, 15);
            this.RBindisponivel.Name = "RBindisponivel";
            this.RBindisponivel.Size = new System.Drawing.Size(98, 20);
            this.RBindisponivel.TabIndex = 21;
            this.RBindisponivel.Text = "Indisponivel";
            this.RBindisponivel.UseVisualStyleBackColor = true;
            // 
            // LVdados
            // 
            this.LVdados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LVdados.Location = new System.Drawing.Point(12, 110);
            this.LVdados.Name = "LVdados";
            this.LVdados.Size = new System.Drawing.Size(520, 208);
            this.LVdados.TabIndex = 22;
            this.LVdados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LVdados_CellContentClick);
            // 
            // ConsultarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(544, 361);
            this.Controls.Add(this.LVdados);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.GPBopcoes);
            this.Controls.Add(this.RBdisponivel);
            this.Controls.Add(this.BTNconsultar);
            this.Controls.Add(this.RBindisponivel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ConsultarLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarLivros";
            this.Load += new System.EventHandler(this.ConsultarLivros_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GPBopcoes.ResumeLayout(false);
            this.GPBopcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LVdados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolStripLabel BTNvoltar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox GPBopcoes;
        private System.Windows.Forms.RadioButton RBstatus;
        private System.Windows.Forms.RadioButton RBnomeLivro;
        private System.Windows.Forms.RadioButton RBdisponivel;
        private System.Windows.Forms.Button BTNconsultar;
        private System.Windows.Forms.RadioButton RBindisponivel;
        private System.Windows.Forms.DataGridView LVdados;
    }
}