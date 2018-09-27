using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class CadastrarClientes : Form
    {
        public CadastrarClientes()
        {
            InitializeComponent();
        }

        private void BTNcancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                string strConn = @"INSERT INTO Clientes (Nome_Cliente, Endereco_Cliente, Cidade_Cliente, Estado_Cliente," +
                "Telefone_Cliente, Status_Cliente) VALUES (@Nome, @Endereco, @Cidade, @Estado, @Telefone, @Status)";

                //Instanciando o obj SqlCommand para dar um comando no banco de dados passando como parametro a string de Intrução e definindo a conexão com BD
                SqlCommand objCommand = new SqlCommand(strConn, objConexao);              
   
                //Nome
                if (!String.IsNullOrEmpty(TXTnome.Text)){
                    objCommand.Parameters.AddWithValue("@Nome", TXTnome.Text);
                    camposValidados = true;
                }
                else{
                    EPerro.SetError(TXTnome, "O campo Nome é obrigatório!");
                    camposValidados = false;
                }

                //Endereço
                if (!String.IsNullOrEmpty(TXTend.Text)){
                    objCommand.Parameters.AddWithValue("@Endereco", TXTend.Text);
                    camposValidados = true;
                }
                else{
                    EPerro.SetError(TXTend, "O campo Endereço é obrigatório!");
                    camposValidados = false;
                }

                //Cidade
                if (!String.IsNullOrEmpty(TXTcidade.Text)){
                    objCommand.Parameters.AddWithValue("@Cidade", TXTcidade.Text);
                    camposValidados = true;
                }
                else
                {
                    EPerro.SetError(TXTcidade, "O campo Cidade é obrigatório!");
                    camposValidados = false;
                }

                //Status
                if (RBdisponivel.Checked){
                    objCommand.Parameters.AddWithValue("@Status", "A");
                    camposValidados = true;
                }
                else
                {
                    objCommand.Parameters.AddWithValue("@Status", "I");
                    camposValidados = true;
                }

                //Telefone
                if (!String.IsNullOrEmpty(MTBtelefone.Text)){
                    objCommand.Parameters.AddWithValue("@Telefone", MTBtelefone.Text);
                    camposValidados = true;
                }

                //Estado
                if (CBBestado.SelectedIndex > -1){
                    objCommand.Parameters.AddWithValue("@Estado", CBBestado.SelectedItem);
                    camposValidados = true;
                }
                else
                {
                    EPerro.SetError(CBBestado, "O campo Estado é obrigatório!");
                    camposValidados = false;
                }

                //se os campos obrigatorios estiverem validados abrira conxao com o BD executar os comandos de insert, fecho a conexao sinalizo p/ o usuario que foi realizado
                //limpo os campos e coloco o cursor no campo do Nome 
                //se não estiverem validados falo pro usuario preenche-los
                if (camposValidados){    
                    objConexao.Open();           
                    objCommand.ExecuteNonQuery();
                    objConexao.Close();
                    MessageBox.Show("Registro inserido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);      
                    LimparCampos();
                    TXTnome.Focus();
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
        //limpo os dados dos 
        private void LimparCampos() {
            TXTnome.Text = "";
            TXTcidade.Text = "";
            TXTend.Text = "";
            CBBestado.Text = "";
            MTBtelefone.Text = "";
       }

        private void CadastrarClientes_Load(object sender, EventArgs e)
        {

        }

        private void BTNvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
