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
    public partial class frmAlterarExcluirLivros : Form
    {
        public frmAlterarExcluirLivros()
        {
            InitializeComponent();
        }

        #region Variáveis Públicas

        int codigo, ano, paginas;
        string nome, autor, genero, editora, status;

        #endregion

        #region Botões / Eventos

        private void dgvDados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Se a célula que o usuário clicou for a do botão Editar atribuo para as variáveis
            //publicas o valor de cada célula do Grid, referente ao respectivo registro
            if (dgvDados.CurrentCell.Value.ToString() == "Editar")
            {
                //Passo o ID do registro que será útil em meu UPDATE no outro form
                codigo = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].FormattedValue);
                nome = dgvDados.CurrentRow.Cells[1].FormattedValue.ToString();
                autor = dgvDados.CurrentRow.Cells[2].FormattedValue.ToString();
                ano = Convert.ToInt32(dgvDados.CurrentRow.Cells[3].FormattedValue);
                genero = dgvDados.CurrentRow.Cells[4].FormattedValue.ToString();
                editora = dgvDados.CurrentRow.Cells[5].FormattedValue.ToString();
                paginas = Convert.ToInt32(dgvDados.CurrentRow.Cells[6].FormattedValue);
                status = dgvDados.CurrentRow.Cells[7].FormattedValue.ToString();

                //Chamo o método Editar, passando as variáveis como parâmetros
                EditarRegistro(codigo, nome, autor, ano, genero, editora, paginas, status);
            }
            
            //Se a célula que o usuário clicou for a do botão Excluir chamo o método Excluir, passando como parâmetro 
            //a linha selecionada + a primeira célula, que contém meu ID com o valor formatado, convertido para Int32
            if (dgvDados.CurrentCell.Value.ToString() == "Excluir")
            {
                ExcluirRegistro(Convert.ToInt32(dgvDados.CurrentRow.Cells[0].FormattedValue));
            }
        }

        private void frmAlterarExcluirLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsLibrarySystem.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.FillByDisponivel(this.dsLibrarySystem.Livros);
        }

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Métodos

        private void EditarRegistro(int codigo, string nome, string autor, int ano, string genero,
                                    string editora, int paginas, string status)
        {
            //Instancio o frmAlterar e atribuo ao valor de suas variáveis o valor das variáveis
            //pertencentes a assinatura deste método e abro o form, por meio do método ShowDialog
            frmAlterarLivros objFrmAlterar = new frmAlterarLivros();
            objFrmAlterar.codigo = codigo;
            objFrmAlterar.nome = nome;
            objFrmAlterar.autor = autor;
            objFrmAlterar.ano = ano;
            objFrmAlterar.genero = genero;
            objFrmAlterar.editora = editora;
            objFrmAlterar.paginas = paginas;
            objFrmAlterar.status = status;

            objFrmAlterar.ShowDialog();
        }

        private void ExcluirRegistro(int codigo)
        {
            //Se o usuário confirmar a exclusão, crio a conexão com o banco e excluo o respectivo registro
            if (MessageBox.Show("Tem certeza que deseja excluir o registro?", "Mensagem do Sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection objConexao = new SqlConnection(@"Data Source=WELLINGTON-PC\SQLEXPRESS;
                                            Initial Catalog=LibrarySystem;Integrated Security=True");

                    string strConn = @"DELETE FROM Livros WHERE ID_LIVRO = @Codigo";

                    SqlCommand objCommand = new SqlCommand(strConn, objConexao);

                    objCommand.Parameters.AddWithValue("@Codigo", codigo);

                    objConexao.Open();

                    objCommand.ExecuteNonQuery();

                    objConexao.Close();

                    MessageBox.Show("Registro excluído com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.livrosTableAdapter.FillBy(dsLibrarySystem.Livros);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion
    }
}
