using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle;
using Negocio;

namespace Visao
{
    public partial class Principal : Form
    {
        private Especialista user;

        public Principal()
        {
            InitializeComponent();
            EfetuarLogin();
            timer.Enabled = true;
        }
        //Função relógio
        private void timer_Tick(object sender, EventArgs e)
        {
            LblRelogio.Text = DateTime.Now.ToString();
        }

        private void EfetuarLogin()
        {
            Login form = new Login();

            if(!(form.ShowDialog() == DialogResult.Yes))
            {
            this.Close();
            }
            
            user = (Especialista)form.Tag;

            //Permissao de dados
            if (user.Tipopermissao == "1") //LIMITADO
            {
                DashConsultaCadastro novo = new DashConsultaCadastro();
                panelConteudo.Controls.Add(novo);
                novo.Tag = user;
                novo.Show();

                ButtonMenuAgenda.Visible = false;
                btnEspecialista.Visible = false;
                ButtonMenuPacientes.Visible = false;
                
            }
            if (user.Tipopermissao == "2") // RESTRITO
            {
                DashAgendamento novo = new DashAgendamento();
                panelConteudo.Controls.Add(novo);
                novo.Tag = user;
                novo.Show();

                btnEspecialista.Visible = false;
                ButtonMenuConsulta.Visible = false;
                btnMenuRelatórios.Visible = false;

            }
            else
            {
                // TOTAL

                DashAgendamento novo = new DashAgendamento();
                panelConteudo.Controls.Add(novo);
                novo.Tag = user;
                novo.Show();
            
            }
        }

        //Botão do topo para fechar a tela principal
        private void buttonTopoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
       
        }

        //Metódo do Botão Menu Responsivo, no qual faz a animação de deslizar o painel do menu.

        private void ButtonMenuResponsivo_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 50)
            {
                //Expandir
                //1. Expande o painel, with = 260
                //2. mostra logo

                panelMenu.Visible = false;
                panelMenu.Width = 260;
                PanelMenuAnimator2.ShowSync(panelMenu);
                LogoAnimator.ShowSync(PtbLogo);
            }
            else
            {
                //Minimizar
                //Usando Framework Bunifu UI Animação
                //1. mostra a Logotipo
                //2. Delizar o Painel, with = 50

                LogoAnimator.HideSync(PtbLogo);
                panelMenu.Visible = false;
                panelMenu.Width = 50;
                PanelMenuAnimator.ShowSync(panelMenu);
            }

            
        }

        // Botão do menu para fechar a tela principal
        private void ButtonMenuEncerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Botão do menu pacientes
        private void ButtonMenuPacientes_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            DashPaciente novo = new DashPaciente();
            panelConteudo.Controls.Add(novo);
            novo.Show();
        }

        private void ButtonMenuConsultas_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            DashAgendamento novo = new DashAgendamento();
            novo.Tag = user;
            panelConteudo.Controls.Add(novo);
            novo.Show();

            
        }


        private void ButtonMenuLaudos_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            DashConsultaCadastro novo = new DashConsultaCadastro();
            novo.Tag = user;
            panelConteudo.Controls.Add(novo);
            novo.Show();
        }

        private void btnMédico_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            DashEspecialista novo = new DashEspecialista();
            panelConteudo.Controls.Add(novo);
            novo.Show();
        }

        private void panelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            DashPaciente novo = new DashPaciente();
            panelConteudo.Controls.Add(novo);
            novo.Show();
        }

        private void btnMenuRelatórios_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            DashRelatórios novo = new DashRelatórios();
            panelConteudo.Controls.Add(novo);
            novo.Show();
        }




       
    }
}
