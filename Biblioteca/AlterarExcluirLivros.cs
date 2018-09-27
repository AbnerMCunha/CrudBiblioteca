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
    public partial class AlterarExcluirLivros : Form
    {
        public AlterarExcluirLivros()
        {
            InitializeComponent();
        }

        private void AlterarExcluirLivros_Load(object sender, EventArgs e)
        {         }
        
        //atribuindo qual a conexão com o Bd para a string sqlCon 
        SqlConnection sqlCon = new SqlConnection(Conect.sqlCon);


        //armazenando a consulta no dataAdapter, e utilizando no where like para que apareça tudo que conter o que tiver TXT e nos arquivos da consulta 
        //instancionando dataTable para criar a "planilha"
        //falando para completar com as informções que foram achadas na pesquisa para dentro da organização da dataTable
        //jogando para o dataGridView a fonte de dados que há em dataTable
        private void Pesquisar()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT* from Livros where Nome_Livro like '%" + TXTpesquisar.Text + "%'", sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DG.DataSource = dt;
        }

       //dando o comando para que pegue os valores que estão nos campos de textos citados, e joga-los para o banco de dados
        private void Atualizar()
        {
            SqlCommand comand = new SqlCommand("UPDATE Livros set Nome_Livro ='" + TXTnomeLivro.Text + 
                "',Autor_Livro='" + TXTautor.Text +"',Editora_Livro='" + TXTeditora.Text + 
                "',Genero_Livro='" + TXTgenero.Text + "',Ano_Livro='" + TXTano.Text +
                "',Paginas_Livro='" + TXTpaginas.Text + "' where Id_Livro =" + cod.Text+ "", sqlCon);
            sqlCon.Open();
            comand.ExecuteNonQuery();
            MessageBox.Show("Dados Alterados com Sucesso!");
            sqlCon.Close();

        }

        //ao clicar em uma celula da planilha da consulta os dados desta linha serão jogados para os campos de texto abaixo do DataGrid para que se possa editar e deletar
       //jogando o codigo para um label invisivel ao usuario
        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTnomeLivro.Text = DG.Rows[e.RowIndex].Cells[1].Value.ToString();
            TXTautor.Text = DG.Rows[e.RowIndex].Cells[2].Value.ToString();
            TXTgenero.Text = DG.Rows[e.RowIndex].Cells[4].Value.ToString();
            TXTeditora.Text = DG.Rows[e.RowIndex].Cells[5].Value.ToString();
            TXTano.Text = DG.Rows[e.RowIndex].Cells[3].Value.ToString();
            TXTpaginas.Text = DG.Rows[e.RowIndex].Cells[6].Value.ToString();
           TXTstatus.Text= DG.Rows[e.RowIndex].Cells[7].Value.ToString();

            cod.Text = DG.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        //fará pesquisa assim que o usuario teclar algo no campo de pesquisa
        private void TXTpesquisar_KeyUp_1(object sender, KeyEventArgs e)
        {
            Pesquisar();
        }

        private void TXTpesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        //chamando os metodos Atualizar para editar e pesquisando para mostrar que foi alterado
        private void BTNalterar_Click_1(object sender, EventArgs e)
        {
            Atualizar();
            Pesquisar();
        }

        private void DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cod_Click(object sender, EventArgs e)
        {
            
        }
        //passando o comando para variavel comand para deletar de Livros onde o Id for igual a label codigo
        //aparecerá na tela perguntando se o usuario realmente deseja excluir o livro, se sim fará a deleção, se não voltara para o formulario
        private void BTNdeletar_Click(object sender, EventArgs e)
        {
            SqlCommand comand = new SqlCommand("DELETE FROM Livros where Id_Livro =" + cod.Text + "", sqlCon);
            sqlCon.Open();
            if (MessageBox.Show("Tem certeza que deseja deletar este dado?", "Mensagem do Sistema",MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                comand.ExecuteNonQuery();
                MessageBox.Show("Dados deletados com Sucesso!");
            }
            sqlCon.Close();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void TXTgenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTeditora_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlterarExcluirLivros_Load_1(object sender, EventArgs e)
        {

        }

        private void BTNvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXTpesquisar_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
