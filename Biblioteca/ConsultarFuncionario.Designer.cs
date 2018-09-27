namespace Biblioteca
{
    partial class ConsultarFuncionario
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
            this.RBnome = new System.Windows.Forms.RadioButton();
            this.BTNconsultar = new System.Windows.Forms.Button();
            this.LVdados = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.GPBopcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LVdados)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNvoltar
            // 
            this.BTNvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNvoltar.Name = "BTNvoltar";
            this.BTNvoltar.Size = new System.Drawing.Size(43, 22);
            this.BTNvoltar.Text = "Voltar";
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
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // GPBopcoes
            // 
            this.GPBopcoes.Controls.Add(this.RBnome);
            this.GPBopcoes.Location = new System.Drawing.Point(22, 12);
            this.GPBopcoes.Name = "GPBopcoes";
            this.GPBopcoes.Size = new System.Drawing.Size(158, 54);
            this.GPBopcoes.TabIndex = 22;
            this.GPBopcoes.TabStop = false;
            this.GPBopcoes.Text = "Filtro";
            // 
            // RBnome
            // 
            this.RBnome.AutoSize = true;
            this.RBnome.Checked = true;
            this.RBnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBnome.Location = new System.Drawing.Point(6, 19);
            this.RBnome.Name = "RBnome";
            this.RBnome.Size = new System.Drawing.Size(130, 20);
            this.RBnome.TabIndex = 0;
            this.RBnome.TabStop = true;
            this.RBnome.Text = "Ordem Alfabetica";
            this.RBnome.UseVisualStyleBackColor = true;
            // 
            // BTNconsultar
            // 
            this.BTNconsultar.BackColor = System.Drawing.Color.PowderBlue;
            this.BTNconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNconsultar.Location = new System.Drawing.Point(429, 17);
            this.BTNconsultar.Name = "BTNconsultar";
            this.BTNconsultar.Size = new System.Drawing.Size(103, 34);
            this.BTNconsultar.TabIndex = 23;
            this.BTNconsultar.Text = "Consultar";
            this.BTNconsultar.UseVisualStyleBackColor = false;
            this.BTNconsultar.Click += new System.EventHandler(this.BTNconsultar_Click);
            // 
            // LVdados
            // 
            this.LVdados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LVdados.Location = new System.Drawing.Point(12, 81);
            this.LVdados.Name = "LVdados";
            this.LVdados.Size = new System.Drawing.Size(520, 236);
            this.LVdados.TabIndex = 1;
            this.LVdados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LVdados_CellContentClick);
            // 
            // ConsultarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(544, 361);
            this.Controls.Add(this.LVdados);
            this.Controls.Add(this.GPBopcoes);
            this.Controls.Add(this.BTNconsultar);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ConsultarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarFuncionario";
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
        private System.Windows.Forms.RadioButton RBnome;
        private System.Windows.Forms.Button BTNconsultar;
        private System.Windows.Forms.DataGridView LVdados;
    }
}