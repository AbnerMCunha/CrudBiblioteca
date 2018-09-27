using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibrarySystem
{
    public partial class frmAlterarLivros : Form
    {
        public frmAlterarLivros()
        {
            InitializeComponent();
        }

        #region Variáveis Públicas

        public int codigo, ano, paginas;
        public string nome, autor, genero, editora, status;

        #endregion

        #region Botões / Eventos

        private void frmAlterarLivros_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void tsbtnGravar_Click(object sender, EventArgs e)
        {
            AlterarDados();
        }

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            CancelarAlteracoes();
        }

        #endregion

        #region Métodos

        private void AlterarDados()
        {
            bool camposValidados = false;

            try
            {
                SqlConnection objConexao = new SqlConnection(@"Data Source=WELLINGTON-PC\SQLEXPRESS;
                                            Initial Catalog=LibrarySystem;Integrated Security=True");

                string strConn = @"UPDATE Livros SET Nome_Livro = @Nome, Autor_Livro = @Autor, " +
                "Ano_Livro = @Ano, Genero_Livro = @Genero, Editora_Livro = @Editora, " +
                "Paginas_Livro = @Paginas, Status_Livro = @Status WHERE Id_Livro = " + codigo;

                SqlCommand objCommand = new SqlCommand(strConn, objConexao);

                #region Validações dos Campos

                if (!String.IsNullOrEmpty(txtNomeLivro.Text))
                {
                    objCommand.Parameters.AddWithValue("@Nome", txtNomeLivro.Text);

                    camposValidados = true;
                }
                else
                {
                    epErro.SetError(txtNomeLivro, "O campo Nome é obrigatório!");

                    camposValidados = false;
                }

                if (!String.IsNullOrEmpty(txtAutor.Text))
                {
                    objCommand.Parameters.AddWithValue("@Autor", txtAutor.Text);

                    camposValidados = true;
                }
                else
                {
                    epErro.SetError(txtAutor, "O campo Autor é obrigatório!");

                    camposValidados = false;
                }

                if (!String.IsNullOrEmpty(txtAno.Text))
                {
                    objCommand.Parameters.AddWithValue("@Ano", txtAno.Text);

                    camposValidados = true;
                }
                else
                {
                    epErro.SetError(txtAno, "O campo Ano é obrigatório!");

                    camposValidados = false;
                }

                if (!String.IsNullOrEmpty(txtGenero.Text))
                {
                    objCommand.Parameters.AddWithValue("@Genero", txtGenero.Text);

                    camposValidados = true;
                }
                else
                {
                    epErro.SetError(txtGenero, "O campo Gênero é obrigatório!");

                    camposValidados = false;
                }

                if (!String.IsNullOrEmpty(txtEditora.Text))
                {
                    objCommand.Parameters.AddWithValue("@Editora", txtEditora.Text);

                    camposValidados = true;
                }
                else
                {
                    epErro.SetError(txtEditora, "O campo Editora é obrigatório!");

                    camposValidados = false;
                }

                if (!String.IsNullOrEmpty(txtPaginas.Text))
                {
                    objCommand.Parameters.AddWithValue("@Paginas", txtPaginas.Text);

                    camposValidados = true;
                }

                if (rbtDisponivel.Checked == true)
                {
                    objCommand.Parameters.AddWithValue("@Status", "D");

                    camposValidados = true;
                }
                else
                {
                    objCommand.Parameters.AddWithValue("@Status", "I");

                    camposValidados = true;
                }

                #endregion

                if (camposValidados)
                {
                    objConexao.Open();

                    objCommand.ExecuteNonQuery();

                    objConexao.Close();

                    MessageBox.Show("Registro alterado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelarAlteracoes()
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar as alterações e voltar?", "Mensagem do Sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimparCampos();
                this.Close();
            }
        }

        private void CarregarDados()
        {
            try
            {
                txtNomeLivro.Text = nome;
                txtAutor.Text = autor;
                txtAno.Text = ano.ToString();
                txtGenero.Text = genero;
                txtEditora.Text = editora;
                txtPaginas.Text = paginas.ToString();

                if (status == "D")
                {
                    rbtDisponivel.Checked = true;
                }
                else
                {
                    rbtIndisponivel.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimparCampos()
        {
            try
            {
                txtNomeLivro.Text = string.Empty;
                txtAutor.Text = string.Empty;
                txtAno.Text = string.Empty;
                txtGenero.Text = string.Empty;
                txtEditora.Text = string.Empty;
                txtPaginas.Text = string.Empty;
                rbtDisponivel.Checked = false;
                rbtIndisponivel.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion        
    }
}
