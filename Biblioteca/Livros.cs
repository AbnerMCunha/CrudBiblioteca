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
    public partial class Livros : Form
    {
        public Livros()
        {
            InitializeComponent();
        }

        private void BTNcadastrar_Click(object sender, EventArgs e)
        {

        }

        private void DesablitarBotoes()
        {
            BTNaltExc.Enabled = false;
            BTNcadastrar.Enabled = false;
            BTNconsultar.Enabled = false;
            BTNvoltar.Enabled = false;
            BTNsair.Enabled = false;
        }

        public void HabilitaBotoes(object sender, EventArgs e)

        {
            this.Close();
            BTNaltExc.Enabled = true;
            BTNcadastrar.Enabled = true;
            BTNconsultar.Enabled = true;
            BTNvoltar.Enabled = true;
            BTNsair.Enabled = true;
        }

        private void BTNvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BTNcadastrar_Click_1(object sender, EventArgs e)
        {
//Instanciando a tela de Cadastrar CLientes e dizendo que o form pai dela é este form(Livros)
            CadastrarLivros objCadLivros = new CadastrarLivros();
            objCadLivros.MdiParent = this;

//desabilito os botoes da classe pai, e se no form filho for clicado em cancelar volto a habilitar os botoes da classe pai
            DesablitarBotoes();
            objCadLivros.BTNcancelar.Click += new EventHandler(this.HabilitaBotoes);

//se a janela janela CadCli estiver aberta vai exibir a mensagem, se não estiver abrirá normalmente
            if (objCadLivros.BTNcancelar.Visible == false)
            {
                objCadLivros.Show();
            }
            else
            {
                MessageBox.Show("O formulario esta aberto acom a gravação dos dados em andamento. " +
                    "Feche este formulario para abrir outro!", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        

        private void BTNaltExc_Click(object sender, EventArgs e)
        {
            AlterarExcluirLivros objAltExcLivros = new AlterarExcluirLivros();
            objAltExcLivros.MdiParent = this;

            DesablitarBotoes();

            objAltExcLivros.BTNvoltar.Click += new EventHandler(this.HabilitaBotoes);

            if (objAltExcLivros.Visible == false)
            {
                objAltExcLivros.Show();
            }
            else
            {
                MessageBox.Show("Formulario já está aberto", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //mesmos comandos
        private void BTNconsultar_Click(object sender, EventArgs e)
        {
            ConsultarLivros objConsLivros= new ConsultarLivros();
            objConsLivros.MdiParent = this;

            DesablitarBotoes();

            objConsLivros.BTNvoltar.Click += new EventHandler(this.HabilitaBotoes);

            if (objConsLivros.Visible == false)
            {
                objConsLivros.Show();
            }
            else
            {
                MessageBox.Show("Formulario já está aberto", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Livros_Load(object sender, EventArgs e)
        {

        }
    }
}
