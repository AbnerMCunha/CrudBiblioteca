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
    public partial class ConsultarLivros : Form
    {
        public ConsultarLivros() { InitializeComponent(); }

        private void ConsultarLivros_Load(object sender, EventArgs e) { }

        private void BTNconsultar_Click(object sender, EventArgs e)
        {

            Consultar();
        }

        //Instanciando a classe de conect e passando como paramentro a string de conxão 
        SqlConnection sqlCon = new SqlConnection(Conect.sqlCon);
        

        //se o RadioButton[RB] de nome estiver marcado fara uma pesquisa ordenada por nome pesquisando todos os Livros
            //na pesquisa estou jogando o comando para o SqlDataAdapter depois instanciando um DataTable que funcionara como uma planilha 
            //preencho o dataTable com os valores encontrados na pesquisa e jogo eles no DataGridView
          //se tiver selecinado RBstatus habilita os outros dois RBdisponivel e indisponivel
        // mesmo comando para pesquisa apenas mudando que aparecera somente os livros que estão disponiveis caso selecionado ou os indisponiveis
        private void Consultar()
        {
            if (RBnomeLivro.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT* from Livros order by Nome_livro", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                LVdados.DataSource = dt;
            }
            else if(RBstatus.Checked && RBdisponivel.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT* from Livros WHERE Status_Livro= 'A' order by Nome_Livro", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                LVdados.DataSource = dt;
            }
            else if (RBstatus.Checked && RBindisponivel.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT* from Livros WHERE Status_Livro ='I' order by Nome_Livro", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                LVdados.DataSource = dt;
            }
        }

        //se tiver status selecionado, habilita os RBs disponivel indisponivel
        //se não ficarão desabilitados
        private void RBstatus_CheckedChanged(object sender, EventArgs e)
        {
            if (RBstatus.Checked)
            {
                RBdisponivel.Enabled = true;
                RBindisponivel.Enabled = true;
            }
            else
            {
                RBdisponivel.Enabled = false;
                RBindisponivel.Enabled = false;
            }         

        }

        private void BTNvoltar_Click(object sender, EventArgs e)
        {

        }

        private void LVdados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

