namespace Biblioteca
{
    partial class ConsultarClientes
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
            this.BTNvoltar = new System.Windows.Forms.ToolStripLabel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.GPBopcoes = new System.Windows.Forms.GroupBox();
            this.RBstatus = new System.Windows.Forms.RadioButton();
            this.RBnome = new System.Windows.Forms.RadioButton();
            this.RBdisponivel = new System.Windows.Forms.RadioButton();
            this.BTNconsultar = new System.Windows.Forms.Button();
            this.RBindisponivel = new System.Windows.Forms.RadioButton();
            this.LVdados = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.GPBopcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LVdados)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNvoltar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 342);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(544, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTNvoltar
            // 
            this.BTNvoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNvoltar.Name = "BTNvoltar";
            this.BTNvoltar.Size = new System.Drawing.Size(45, 22);
            this.BTNvoltar.Text = "Voltar";
            this.BTNvoltar.Click += new System.EventHandler(this.BTNvoltar_Click);
            // 
            // GPBopcoes
            // 
            this.GPBopcoes.Controls.Add(this.RBstatus);
            this.GPBopcoes.Controls.Add(this.RBnome);
            this.GPBopcoes.Location = new System.Drawing.Point(12, 12);
            this.GPBopcoes.Name = "GPBopcoes";
            this.GPBopcoes.Size = new System.Drawing.Size(181, 87);
            this.GPBopcoes.TabIndex = 22;
            this.GPBopcoes.TabStop = false;
            this.GPBopcoes.Text = "Filtro";
            // 
            // RBstatus
            // 
            this.RBstatus.AutoSize = true;
            this.RBstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBstatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RBstatus.Location = new System.Drawing.Point(6, 55);
            this.RBstatus.Name = "RBstatus";
            this.RBstatus.Size = new System.Drawing.Size(66, 21);
            this.RBstatus.TabIndex = 2;
            this.RBstatus.Text = "Status";
            this.RBstatus.UseVisualStyleBackColor = true;
            this.RBstatus.CheckedChanged += new System.EventHandler(this.RBstatus_CheckedChanged);
            // 
            // RBnome
            // 
            this.RBnome.AutoSize = true;
            this.RBnome.Checked = true;
            this.RBnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBnome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RBnome.Location = new System.Drawing.Point(6, 19);
            this.RBnome.Name = "RBnome";
            this.RBnome.Size = new System.Drawing.Size(135, 21);
            this.RBnome.TabIndex = 0;
            this.RBnome.TabStop = true;
            this.RBnome.Text = "Ordem Alfabetica";
            this.RBnome.UseVisualStyleBackColor = true;
            // 
            // RBdisponivel
            // 
            this.RBdisponivel.AutoSize = true;
            this.RBdisponivel.Checked = true;
            this.RBdisponivel.Enabled = false;
            this.RBdisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBdisponivel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RBdisponivel.Location = new System.Drawing.Point(216, 44);
            this.RBdisponivel.Name = "RBdisponivel";
            this.RBdisponivel.Size = new System.Drawing.Size(91, 21);
            this.RBdisponivel.TabIndex = 24;
            this.RBdisponivel.TabStop = true;
            this.RBdisponivel.Text = "Disponivel";
            this.RBdisponivel.UseVisualStyleBackColor = true;
            // 
            // BTNconsultar
            // 
            this.BTNconsultar.BackColor = System.Drawing.Color.PowderBlue;
            this.BTNconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNconsultar.Location = new System.Drawing.Point(429, 21);
            this.BTNconsultar.Name = "BTNconsultar";
            this.BTNconsultar.Size = new System.Drawing.Size(103, 37);
            this.BTNconsultar.TabIndex = 23;
            this.BTNconsultar.Text = "Consultar";
            this.BTNconsultar.UseVisualStyleBackColor = false;
            this.BTNconsultar.Click += new System.EventHandler(this.BTNconsultar_Click_1);
            // 
            // RBindisponivel
            // 
            this.RBindisponivel.AutoSize = true;
            this.RBindisponivel.Enabled = false;
            this.RBindisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBindisponivel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RBindisponivel.Location = new System.Drawing.Point(216, 21);
            this.RBindisponivel.Name = "RBindisponivel";
            this.RBindisponivel.Size = new System.Drawing.Size(100, 21);
            this.RBindisponivel.TabIndex = 25;
            this.RBindisponivel.Text = "Indisponivel";
            this.RBindisponivel.UseVisualStyleBackColor = true;
            // 
            // LVdados
            // 
            this.LVdados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LVdados.Location = new System.Drawing.Point(12, 119);
            this.LVdados.Name = "LVdados";
            this.LVdados.Size = new System.Drawing.Size(520, 210);
            this.LVdados.TabIndex = 3;
            this.LVdados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LVdados_CellContentClick);
            // 
            // ConsultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(544, 367);
            this.Controls.Add(this.LVdados);
            this.Controls.Add(this.GPBopcoes);
            this.Controls.Add(this.RBdisponivel);
            this.Controls.Add(this.BTNconsultar);
            this.Controls.Add(this.RBindisponivel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ConsultarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Clientes";
            this.Load += new System.EventHandler(this.ConsultarClientes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.GPBopcoes.ResumeLayout(false);
            this.GPBopcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LVdados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel BTNvoltar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox GPBopcoes;
        private System.Windows.Forms.RadioButton RBstatus;
        private System.Windows.Forms.RadioButton RBnome;
        private System.Windows.Forms.RadioButton RBdisponivel;
        private System.Windows.Forms.Button BTNconsultar;
        private System.Windows.Forms.RadioButton RBindisponivel;
        private System.Windows.Forms.DataGridView LVdados;
    }
}