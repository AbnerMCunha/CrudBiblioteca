using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Biblioteca
{
    public partial class CadastrarLivros : Form
    {
        public CadastrarLivros()
        {
            InitializeComponent();
        }

        private void BTNgravar_Click(object sender, EventArgs e)
        {
            Gravar();

        }

        private void Gravar()
        { 
                bool camposValidados = false;

                try
            {                
                //Instanciando a classe de conexão e passando como paramentro a string que esta na classe Connect
                SqlConnection objConexao = new SqlConnection(Conect.sqlCon);

                //passando a intrução SQL em uma string e definindo quais valores serão armazenados e determinando seu lugar
                string strConn = @"INSERT INTO Livros (Nome_Livro, Autor_Livro, Ano_Livro, Genero_Livro," +
                    "Editora_Livro, Paginas_Livro,Status_Livro) " +
                    "VALUES (@NomeLivro, @Autor, @Ano, @Genero, @Editora,@Paginas,@Status)";

                //Instanciando o obj SqlCommand para dar um comando no banco de dados passando como parametro a string de Intrução e definindo a conexão com BD
                SqlCommand objCommand = new SqlCommand(strConn, objConexao);


                //se o campo estiver diferente de nulo e vazio ira adcionar o valor do texto no parametro definido, afetando o banco de dados; validando que que os campos estão validados              
                //se o campo estiver de nulo e vazio ficará marcado para que o usuario corrija 
                if (!String.IsNullOrEmpty(TXTnomeLivro.Text))
                    {
                        objCommand.Parameters.AddWithValue("@NomeLivro", TXTnomeLivro.Text);
                        camposValidados = true;
                    }
                    else
                    {
                        EPerro.SetError(TXTnomeLivro, "O campo Nome do Livro é obrigatório!");
                        camposValidados = false;
                    }

                    //Autor
                    if (!String.IsNullOrEmpty(TXTautor.Text))
                    {
                        objCommand.Parameters.AddWithValue("@Autor", TXTautor.Text);
                        camposValidados = true;
                    }
                    else
                    {
                        EPerro.SetError(TXTautor, "O campo Autor é obrigatório!");
                        camposValidados = false;
                    }

                    //Ano
                    if (!String.IsNullOrEmpty(TXTano.Text))
                    {
                        objCommand.Parameters.AddWithValue("@Ano", int.Parse(TXTano.Text));
                        camposValidados = true;
                    }
                    else
                    {
                        EPerro.SetError(TXTano, "O campo Ano é obrigatório!");
                        camposValidados = false;
                    }

                    //Paginas
                    if (!String.IsNullOrEmpty(TXTpag.Text))
                    {
                        objCommand.Parameters.AddWithValue("@Paginas", int.Parse(TXTpag.Text));
                        camposValidados = true;
                    }


                    //Genero
                    if (!String.IsNullOrEmpty(TXTano.Text))
                    {
                        objCommand.Parameters.AddWithValue("@Genero", TXTgenero.Text);
                        camposValidados = true;
                    }
                    else
                    {
                        EPerro.SetError(TXTgenero, "O campo Genero é obrigatório!");
                        camposValidados = false;
                    }

                    //Editora
                    if (!String.IsNullOrEmpty(TTXeditora.Text))
                    {
                        objCommand.Parameters.AddWithValue("@Editora", TTXeditora.Text);
                        camposValidados = true;
                    }
                    else
                    {
                        EPerro.SetError(TTXeditora, "O campo Editora é obrigatório!");
                        camposValidados = false;
                    }

                    //Status
                    if (RBdisponivel.Checked)
                    {
                        objCommand.Parameters.AddWithValue("@Status", "A");
                        camposValidados = true;
                    }
                    else
                    {
                        objCommand.Parameters.AddWithValue("@Status", "I");
                        camposValidados = true;
                    }


                //se os campos obrigatorios estiverem validados abrira conxao com o BD executar os comandos de insert, fecho a conexao sinalizo p/ o usuario que foi realizado
                //limpo os campos e coloco o cursor no campo do Nome 
                //se não estiverem validados falo pro usuario preenche-los
                if (camposValidados)
                    {
                        objConexao.Open();
                        objCommand.ExecuteNonQuery();
                        objConexao.Close();
                        MessageBox.Show("Registro inserido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        TXTnomeLivro.Focus();
                        BTNvoltar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Ops, ocorreram erros!\n\nPreencha os campos e tente novamente",
                        "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            //mostro qual foi o erro ao usuario
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        //limpo os dados dos campos
        private void LimparCampos()
            {
                TXTnomeLivro.Text = "";
                TXTautor.Text = "";
                TXTano.Text = "";
                TXTpag.Text = "";
                TXTgenero.Text = "";
                TTXeditora.Text = "";
                }

        private void CadastrarLivros_Load(object sender, EventArgs e)
        {

        }

        private void TXTano_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
