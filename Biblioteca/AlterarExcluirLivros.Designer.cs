namespace Biblioteca
{
    partial class AlterarExcluirLivros
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNvoltar = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TXTautor = new System.Windows.Forms.TextBox();
            this.cod = new System.Windows.Forms.Label();
            this.LBLmensagem = new System.Windows.Forms.Label();
            this.TXTpesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTnomeLivro = new System.Windows.Forms.TextBox();
            this.TXTgenero = new System.Windows.Forms.TextBox();
            this.TXTeditora = new System.Windows.Forms.TextBox();
            this.TXTano = new System.Windows.Forms.TextBox();
            this.TXTpaginas = new System.Windows.Forms.TextBox();
            this.TXTtitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNalterar = new System.Windows.Forms.Button();
            this.TXTstatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DG = new System.Windows.Forms.DataGridView();
            this.BTNdeletar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // BTNvoltar
            // 
            this.BTNvoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNvoltar.Name = "BTNvoltar";
            this.BTNvoltar.Size = new System.Drawing.Size(43, 22);
            this.BTNvoltar.Text = "Voltar";
            this.BTNvoltar.Click += new System.EventHandler(this.BTNvoltar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNvoltar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 456);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(650, 25);
            this.toolStrip1.TabIndex = 52;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TXTautor
            // 
            this.TXTautor.Location = new System.Drawing.Point(100, 322);
            this.TXTautor.Name = "TXTautor";
            this.TXTautor.Size = new System.Drawing.Size(178, 20);
            this.TXTautor.TabIndex = 57;
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.BackColor = System.Drawing.Color.Transparent;
            this.cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cod.Location = new System.Drawing.Point(525, 52);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(33, 17);
            this.cod.TabIndex = 70;
            this.cod.Text = "Cod";
            this.cod.Click += new System.EventHandler(this.Cod_Click);
            // 
            // LBLmensagem
            // 
            this.LBLmensagem.AutoSize = true;
            this.LBLmensagem.BackColor = System.Drawing.Color.Transparent;
            this.LBLmensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLmensagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLmensagem.Location = new System.Drawing.Point(75, 9);
            this.LBLmensagem.Name = "LBLmensagem";
            this.LBLmensagem.Size = new System.Drawing.Size(488, 20);
            this.LBLmensagem.TabIndex = 50;
            this.LBLmensagem.Text = "Selecione o registro e clique bos botões para Alterar/Excluir";
            // 
            // TXTpesquisar
            // 
            this.TXTpesquisar.Location = new System.Drawing.Point(187, 51);
            this.TXTpesquisar.Name = "TXTpesquisar";
            this.TXTpesquisar.Size = new System.Drawing.Size(302, 20);
            this.TXTpesquisar.TabIndex = 53;
            this.TXTpesquisar.TextChanged += new System.EventHandler(this.TXTpesquisar_TextChanged_1);
            this.TXTpesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXTpesquisar_KeyUp_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(101, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nome Livro:";
            // 
            // TXTnomeLivro
            // 
            this.TXTnomeLivro.Location = new System.Drawing.Point(100, 287);
            this.TXTnomeLivro.Name = "TXTnomeLivro";
            this.TXTnomeLivro.Size = new System.Drawing.Size(178, 20);
            this.TXTnomeLivro.TabIndex = 55;
            // 
            // TXTgenero
            // 
            this.TXTgenero.Location = new System.Drawing.Point(375, 288);
            this.TXTgenero.Name = "TXTgenero";
            this.TXTgenero.Size = new System.Drawing.Size(127, 20);
            this.TXTgenero.TabIndex = 56;
            this.TXTgenero.TextChanged += new System.EventHandler(this.TXTgenero_TextChanged);
            // 
            // TXTeditora
            // 
            this.TXTeditora.Location = new System.Drawing.Point(375, 323);
            this.TXTeditora.Name = "TXTeditora";
            this.TXTeditora.Size = new System.Drawing.Size(127, 20);
            this.TXTeditora.TabIndex = 58;
            this.TXTeditora.TextChanged += new System.EventHandler(this.TXTeditora_TextChanged);
            // 
            // TXTano
            // 
            this.TXTano.Location = new System.Drawing.Point(569, 319);
            this.TXTano.Name = "TXTano";
            this.TXTano.Size = new System.Drawing.Size(61, 20);
            this.TXTano.TabIndex = 59;
            // 
            // TXTpaginas
            // 
            this.TXTpaginas.Location = new System.Drawing.Point(585, 287);
            this.TXTpaginas.Name = "TXTpaginas";
            this.TXTpaginas.Size = new System.Drawing.Size(45, 20);
            this.TXTpaginas.TabIndex = 60;
            // 
            // TXTtitulo
            // 
            this.TXTtitulo.AutoSize = true;
            this.TXTtitulo.BackColor = System.Drawing.Color.Transparent;
            this.TXTtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTtitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXTtitulo.Location = new System.Drawing.Point(10, 287);
            this.TXTtitulo.Name = "TXTtitulo";
            this.TXTtitulo.Size = new System.Drawing.Size(84, 17);
            this.TXTtitulo.TabIndex = 61;
            this.TXTtitulo.Text = "Nome Livro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(48, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(526, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "Ano:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(300, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 64;
            this.label7.Text = "Genero:";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(300, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Editora:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(516, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "Paginas:";
            // 
            // BTNalterar
            // 
            this.BTNalterar.BackColor = System.Drawing.Color.PowderBlue;
            this.BTNalterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNalterar.Location = new System.Drawing.Point(120, 400);
            this.BTNalterar.Name = "BTNalterar";
            this.BTNalterar.Size = new System.Drawing.Size(137, 23);
            this.BTNalterar.TabIndex = 67;
            this.BTNalterar.Text = "Alterar";
            this.BTNalterar.UseVisualStyleBackColor = false;
            this.BTNalterar.Click += new System.EventHandler(this.BTNalterar_Click_1);
            // 
            // TXTstatus
            // 
            this.TXTstatus.Location = new System.Drawing.Point(540, 358);
            this.TXTstatus.Name = "TXTstatus";
            this.TXTstatus.Size = new System.Drawing.Size(85, 20);
            this.TXTstatus.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(482, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Status:";
            // 
            // DG
            // 
            this.DG.AllowUserToOrderColumns = true;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(12, 77);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(623, 181);
            this.DG.TabIndex = 71;
            this.DG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellClick);
            this.DG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellContentClick);
            // 
            // BTNdeletar
            // 
            this.BTNdeletar.BackColor = System.Drawing.Color.PowderBlue;
            this.BTNdeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdeletar.Location = new System.Drawing.Point(365, 400);
            this.BTNdeletar.Name = "BTNdeletar";
            this.BTNdeletar.Size = new System.Drawing.Size(137, 23);
            this.BTNdeletar.TabIndex = 72;
            this.BTNdeletar.Text = "Deletar";
            this.BTNdeletar.UseVisualStyleBackColor = false;
            this.BTNdeletar.Click += new System.EventHandler(this.BTNdeletar_Click);
            // 
            // AlterarExcluirLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(650, 481);
            this.Controls.Add(this.BTNdeletar);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTstatus);
            this.Controls.Add(this.BTNalterar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTtitulo);
            this.Controls.Add(this.TXTpaginas);
            this.Controls.Add(this.TXTano);
            this.Controls.Add(this.TXTeditora);
            this.Controls.Add(this.TXTgenero);
            this.Controls.Add(this.TXTnomeLivro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTpesquisar);
            this.Controls.Add(this.LBLmensagem);
            this.Controls.Add(this.TXTautor);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AlterarExcluirLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar - Exluir LIVROS";
            this.Load += new System.EventHandler(this.AlterarExcluirLivros_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public System.Windows.Forms.ToolStripLabel BTNvoltar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox TXTautor;
        private System.Windows.Forms.Label cod;
        private System.Windows.Forms.Label LBLmensagem;
        private System.Windows.Forms.TextBox TXTpesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTnomeLivro;
        private System.Windows.Forms.TextBox TXTgenero;
        private System.Windows.Forms.TextBox TXTeditora;
        private System.Windows.Forms.TextBox TXTano;
        private System.Windows.Forms.TextBox TXTpaginas;
        private System.Windows.Forms.Label TXTtitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTNalterar;
        private System.Windows.Forms.TextBox TXTstatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.Button BTNdeletar;
    }
}