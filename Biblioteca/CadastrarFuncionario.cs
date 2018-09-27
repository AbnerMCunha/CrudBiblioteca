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
    public partial class CadastrarFuncionario : Form
    {
        public CadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {

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
                string strConn = @"INSERT INTO Funcionarios (Nome_Funcionario, Endereco_Funcionario, Cidade_Funcionario, Estado_Funcionario,
                Telefone_Funcionario, Cargo_Funcionario,Data_Admissao_Funcionario,Data_Demissao_Funcionario ) " +
                "VALUES (@Nome, @Endereco, @Cidade, @Estado, @Telefone,@Cargo,@Admissao,@Demissao)";

//Instanciando o obj SqlCommand para dar um comando no banco de dados passando como parametro a string de Intrução e definindo a conexão com BD
                SqlCommand objCommand = new SqlCommand(strConn, objConexao);


//se o campo estiver diferente de nulo e vazio ira adcionar o valor do texto no parametro definido, afetando o banco de dados; validando que que os campos estão validados              
//se o campo estiver de nulo e vazio ficará marcado para que o usuario corrija 
                //Nome
                if (!String.IsNullOrEmpty(TXTnome.Text))
                {
                    objCommand.Parameters.AddWithValue("@Nome", TXTnome.Text);
                    camposValidados = true;
                }
                else
                {
                    EPerro.SetError(TXTnome, "O campo Nome é obrigatório!");
                    camposValidados = false;
                }

                //Endereço
                if (!String.IsNullOrEmpty(TXTend.Text))
                {
                    objCommand.Parameters.AddWithValue("@Endereco", TXTend.Text);
                    camposValidados = true;
                }
                else
                {
                    EPerro.SetError(TXTend, "O campo Endereço é obrigatório!");
                    camposValidados = false;
                }

                //Cidade
                if (!String.IsNullOrEmpty(TXTcidade.Text))
                {
                    objCommand.Parameters.AddWithValue("@Cidade", TXTcidade.Text);
                    camposValidados = true;
                }
                else
                {
                    EPerro.SetError(TXTcidade, "O campo Cidade é obrigatório!");
                    camposValidados = false;
                }

                //Telefone
                if (!String.IsNullOrEmpty(MTBtelefone.Text))
                {
                    objCommand.Parameters.AddWithValue("@Telefone", MTBtelefone.Text);
                    camposValidados = true;
                }

                //Estado
                if (CBBestado.SelectedIndex > -1)
                {
                    objCommand.Parameters.AddWithValue("@Estado", CBBestado.SelectedItem);
                    camposValidados = true;
                }
                else
                {
                    EPerro.SetError(CBBestado, "O campo Estado é obrigatório!");
                    camposValidados = false;
                }

                //Cargo
                if (!String.IsNullOrEmpty(TXTcidade.Text))
                {
                    objCommand.Parameters.AddWithValue("@Cargo", TXTcargo.Text);
                    camposValidados = true;
                }
                else
                {
                    EPerro.SetError(TXTcargo, "O campo Cargo é obrigatório!");
                    camposValidados = false;
                }

                //Data demissao
                if (!String.IsNullOrEmpty(MTBdemissao.Text))
                {
                    objCommand.Parameters.AddWithValue("@Demissao",Convert.ToDateTime(MTBdemissao.Text));
                    camposValidados = true;
                }

                //Data Admissao
                if (!String.IsNullOrEmpty(MTBadmissao.Text))
                {
                    objCommand.Parameters.AddWithValue("@Admissao", Convert.ToDateTime(MTBadmissao.Text));
                    camposValidados = true;
                }
                else
                {
                    EPerro.SetError(MTBadmissao, "O campo DATA DE ADMISSAO é obrigatório");
                    camposValidados = false;
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
                    TXTnome.Focus();
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
            TXTnome.Text = "";
            TXTcidade.Text = "";
            TXTend.Text = "";
            CBBestado.Text = "";
            MTBadmissao.Text = "";
            MTBdemissao.Text = "";
            TXTcargo.Text = "";
            MTBtelefone.Text = "";
        }

        private void BTNvoltar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
