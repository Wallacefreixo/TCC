using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Controle;

namespace Visao
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //botão fechar tela de login
        private void ButtonCloseLogin_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //botão de fazer logar
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Especialista user = null;
        try
        {
              EspecialistaCtrl dados = new EspecialistaCtrl();
              user =  dados.BuscarDadosLogin(BmtUsuario.Text, BmtSenha.Text);
           
              if (user != null)
              {
                  this.Tag = user;
                  this.DialogResult = DialogResult.Yes;
                  this.Close();
              }
             else
             {
                  lblMsg.Text = "Usuario ou senha inválidos!";
             }
           }
          catch (Exception ex)
          {
            MessageBox.Show("ERRO: " + ex.Message);
          }
        }

        private void apagaMensagem(object sender, EventArgs e)
        {
            lblMsg.Text = "";
        }

       
    }
}
