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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void BTNsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//Instanciando a tela de Cadastrar CLientes e dizendo que o form pai dela é este form(Funcionario)
        private void BTNcadastrar_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario objCadFunc = new CadastrarFuncionario();
            objCadFunc.MdiParent = this;

//desabilito os botoes da classe pai, e se no form filho for clicado em cancelar volto a habilitar os botoes da classe pai
            DesablitarBotoes();

            objCadFunc.BTNcancelar.Click += new EventHandler(this.HabilitaBotoes);
//se a janela janela CadCli estiver aberta vai exibir a mensagem, se não estiver abrirá normalmente
            if (objCadFunc.BTNcancelar.Visible == false)
            {
                objCadFunc.Show();
            }
            else
            {
                MessageBox.Show("O formulario esta aberto acom a gravação dos dados em andamento. " +
                    "Feche este formulario para abrir outro!", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void DesablitarBotoes()
        {           
            BTNcadastrar.Enabled = false;
            BTNconsultar.Enabled = false;
            BTNvoltar.Enabled = false;
            BTNsair.Enabled = false;
        }

        public void HabilitaBotoes(object sender, EventArgs e)

        {
            BTNcadastrar.Enabled = true;
            BTNconsultar.Enabled = true;
            BTNvoltar.Enabled = true;
            BTNsair.Enabled = true;
        }

        private void BTNaltExc_Click(object sender, EventArgs e)
        {   }
//mesmos comandos
        private void BTNconsultar_Click(object sender, EventArgs e)
        {
            ConsultarFuncionario objConsFunc= new ConsultarFuncionario();
            objConsFunc.MdiParent = this;

            DesablitarBotoes();

            objConsFunc.BTNvoltar.Click += new EventHandler(this.HabilitaBotoes);

            if (objConsFunc.Visible == false)
            {
                objConsFunc.Show();
            }
            else
            {
                MessageBox.Show("Formulario já está aberto", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }
    }
}

