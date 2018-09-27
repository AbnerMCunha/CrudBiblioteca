using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Biblioteca : Form
    {
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void BTNclientes_Click(object sender, EventArgs e)
        {
            Clientes abaClientes = new Clientes();
            abaClientes.ShowDialog();
        }

        private void BTNsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja reamente sair do Sistema?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BTNlivros_Click(object sender, EventArgs e)
        {
            Livros abaLivros = new Livros();
            abaLivros.ShowDialog();
        }

        private void BTNFunc_Click(object sender, EventArgs e)
        {
            Funcionario abaFunc = new Funcionario();
            abaFunc.ShowDialog();
        }

        private void Biblioteca_Load(object sender, EventArgs e)
        {

        }

      

        
    }
}
