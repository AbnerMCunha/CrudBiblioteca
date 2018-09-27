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
    public partial class ConsultarClientes : Form
    {
        public ConsultarClientes()
        {
            InitializeComponent();
        }

        private void ConsultarClientes_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        
        //Instanciando a classe de conect e passando como paramentro a string de conxão 
        SqlConnection sqlCon = new SqlConnection(Conect.sqlCon);


     //se o RadioButton[RB] de nome estiver marcado fara uma pesquisa ordenada por nome pesquisando todos os clientes
        //nessa pesquisa estou jogando o comando para o SqlDataAdapter depois instanciando um DataTable que funcionara como uma planilha 
        //preencho o dataTable com os valores encontrados na pesquisa e jogo eles no DataGridView
     //se tiver selecinado RBstatus habilita os outros dois RBdisponivel e indisponivel
        // mesmo comando para pesquisa apenas mudando que aparecera somente os clientes que estão disponiveis caso selecionado ou os indisponiveis
        private void Consultar()
            {
                if (RBnome.Checked)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT* from Clientes order by Nome_Cliente", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    LVdados.DataSource = dt;
                }
                else if (RBstatus.Checked && RBdisponivel.Checked)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT* from Clientes WHERE Status_Cliente='A' order by Nome_Cliente", sqlCon);
                    DataTable dt = new DataTable();                 
                    da.Fill(dt);
                    LVdados.DataSource = dt;
                }
                else if (RBstatus.Checked && RBindisponivel.Checked)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT* from Clientes WHERE Status_Cliente='I' order by Nome_Cliente", sqlCon);
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
        //cahamando o metodo consultar
        private void BTNconsultar_Click_1(object sender, EventArgs e)
        {
            Consultar();
        }

        private void BTNvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LVdados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
