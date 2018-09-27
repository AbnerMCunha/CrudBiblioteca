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
    public partial class ConsultarFuncionario : Form
    {
        public ConsultarFuncionario()
        {
            InitializeComponent();
        }

        private void RBstatus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BTNconsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        //definindo a conexão, pessando como parametro a string que esta em Conect
        SqlConnection sqlCon = new SqlConnection(Conect.sqlCon);


        //armazenando a consulta no dataAdapter
        //instancionando dataTable para criar a "planilha"
        //falando para completar com as informções que foram achadas na pesquisa para dentro da organização da dataTable
        //jogando para o dataGridView a fonte de dados que há em dataTable
        private void Consultar()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT* from Funcionarios order by Nome_Funcionario", sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            LVdados.DataSource = dt;
        }

        private void LVdados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
