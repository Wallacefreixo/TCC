using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle;
using Negocio;
using System.Data.SqlServerCe;
using Dados;

namespace Visao
{
    public partial class DashAgendamentoCadastro : UserControl
    {
        private Especialista user;

        public DashAgendamentoCadastro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelconsultacadastro2.Controls.Clear();
            DashAgendamento novo = new DashAgendamento();
            panelconsultacadastro2.Controls.Add(novo);
            this.user = (Especialista)this.Tag;
            novo.Show();

        }

        private void ButtonSalvarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaCtrl controle = new ConsultaCtrl();

                Consulta consulta = CarregarConsultaDoForm();

                controle.InserirConsulta(consulta);

                limpaFormulario();

                MessageBox.Show("Consulta cadastrada com sucesso!!");

                panelconsultacadastro2.Controls.Clear();
                DashAgendamento novo = new DashAgendamento();
                panelconsultacadastro2.Controls.Add(novo);
                novo.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }
        private Consulta CarregarConsultaDoForm()
        {
            //recebe os dados do formulario e joga em uma váriavel da istância medico

            Consulta c = new Consulta();
            try
            {
                c.Idpaciente = int.Parse(BmtIdPaciente.Text);
                c.Idmedico = int.Parse(BmtIdMedico.Text);
                c.Motivo = BmtMotivo.Text;
                c.Horario = MtbHorario.Text;
                c.Data = MtbData.Text;
                c.Status = CmbStatus.SelectedIndex.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            return c;

        }
     


        private void limpaFormulario()
        {
            BmtIdPaciente.Text = "";
            BmtIdMedico.Text = "";
            BmtMotivo.Text = "";
            MtbHorario.Text = "";
            MtbData.Text = "";
            CmbStatus.SelectedItem = null;
            mtbHoraInicial.Text = "";
            MtbHorafim.Text = "";
            CkbSegunda.Checked = false;
            CkbTerca.Checked = false;
            CkbQuarta.Checked = false;
            CkbQuinta.Checked = false;
            CkbSexta.Checked = false;
            CkbSabado.Checked = false;
            CkbDomingo.Checked = false;
            cmbFiltrarCategoriaMedica.SelectedItem = null;
            cbmFiltrar.SelectedItem = null;
            txtPesquisar.Text = "";
            LtbMedicResp.Items.Clear();
           


        }

        private void cbmFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmFiltrar.Text == "Nome Completo")
            {
                txtPesquisar.Mask = "";
                txtPesquisar.Text = "";

            }
            if (cbmFiltrar.Text == "CPF")
            {
                txtPesquisar.Mask = "000.000.000-00";
                txtPesquisar.Text = "";
            }
            if (cbmFiltrar.Text == "")
            {
                txtPesquisar.Mask = "";
                txtPesquisar.Text = "";
                BmtIdPaciente.Text = "";
            }
            if (cbmFiltrar.Text == "RG")
            {
                txtPesquisar.Mask = "00.000.000-0";
                txtPesquisar.Text = "";
            }
            if (cbmFiltrar.Text == "ID")
            {
                txtPesquisar.Mask = "";
                txtPesquisar.Text = "";
            }

        }

        private void btnbuscarPaciente_Click(object sender, EventArgs e)
        {
            if (cbmFiltrar.Text == "Nome Completo")
            {
                 try
                 {
                           //variável recebe o objeto cliente retornado pelo método 
                           Paciente paciente = ObterPacientePorNome(txtPesquisar.Text);

                           //passo os valores para os textbox 

                           MessageBox.Show("Paciente encontrado com nome: " + paciente.NomeCompleto.ToString());
                           BmtIdPaciente.Text = paciente.Id.ToString();


                  }
                  catch (Exception ex)
                  {
                         MessageBox.Show("ERRO: " + ex.Message);
                  }
            
            }
            if (cbmFiltrar.Text == "CPF")
            {
                try
                {
                    //variável recebe o objeto cliente retornado pelo método 
                    Paciente paciente = ObterPacientePorCpf(txtPesquisar.Text);


                    //passo os valores para os textbox 

                    MessageBox.Show("Paciente encontrado com nome: " + paciente.NomeCompleto.ToString());
                    BmtIdPaciente.Text = paciente.Id.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message);
                }

            }
            if (cbmFiltrar.Text == "RG")
            {
                try
                {
                    //variável recebe o objeto cliente retornado pelo método 
                    Paciente paciente = ObterPacientePorRg(txtPesquisar.Text);

                    //passo os valores para os textbox 

                    MessageBox.Show("Paciente encontrado com nome: " + paciente.NomeCompleto.ToString());
                    BmtIdPaciente.Text = paciente.Id.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message);
                }

            }
            if (cbmFiltrar.Text == "ID")
            {
                try
                {
                    //variável recebe o objeto cliente retornado pelo método 
                    Paciente paciente = ObterPacientePorId(txtPesquisar.Text);

                    //passo os valores para os textbox 
                    MessageBox.Show("Paciente encontrado com nome: "+paciente.NomeCompleto.ToString());
                    BmtIdPaciente.Text = paciente.Id.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message);
                }
            }

        }
        private Paciente ObterPacientePorRg(string rg)
        {
            //objeto paciente que será retornado pelo método 
            Paciente paciente = new Paciente();

            //instância da conexão 
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

            //string com o comando a ser executado 
            string sql = "SELECT * from Paciente WHERE Rg = @Rg";

            //instância do comando recebendo como parâmetro 
            //a string com o comando e a conexão 
            SqlCeCommand cmd = new SqlCeCommand(sql, conn);

            //informo o parâmetro do comando 
            cmd.Parameters.AddWithValue("@Rg", rg);

            //abro conexão 
            conn.Open();

            //instância do leitor 
            SqlCeDataReader leitor = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (leitor.Read())
            {
                //passo os valores para o objeto paciente
                //que será retornado 
                paciente.NomeCompleto = leitor["Nome"].ToString();
                paciente.Id = Convert.ToInt32(leitor["Id"].ToString());
            }

            //fecha conexão 
            conn.Close();

            //Retorno o objeto paciente cujo o  
            //nome é igual ao informado no parâmetro 
            return paciente;
        
        }
        private Paciente ObterPacientePorId(string id)
        {

            //objeto paciente que será retornado pelo método 
            Paciente paciente = new Paciente();

            //instância da conexão 
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

            //string com o comando a ser executado 
            string sql = "SELECT * from Paciente WHERE Id = @Id";

            //instância do comando recebendo como parâmetro 
            //a string com o comando e a conexão 
            SqlCeCommand cmd = new SqlCeCommand(sql, conn);

            //informo o parâmetro do comando 
            cmd.Parameters.AddWithValue("@Id", id);

            //abro conexão 
            conn.Open();

            //instância do leitor 
            SqlCeDataReader leitor = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (leitor.Read())
            {
                //passo os valores para o objeto paciente
                //que será retornado 
                paciente.NomeCompleto = leitor["Nome"].ToString();
                paciente.Id = Convert.ToInt32(leitor["Id"].ToString());
            }

            //fecha conexão 
            conn.Close();

            //Retorno o objeto paciente cujo o  
            //nome é igual ao informado no parâmetro 
            return paciente;
        }

        private Paciente ObterPacientePorNome(string nome)
        {
            //objeto paciente que será retornado pelo método 
            Paciente paciente = new Paciente();

            //instância da conexão 
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

            //string com o comando a ser executado 
            string sql = "SELECT * from Paciente WHERE Nome = @Nome";

            //instância do comando recebendo como parâmetro 
            //a string com o comando e a conexão 
            SqlCeCommand cmd = new SqlCeCommand(sql, conn);

            //informo o parâmetro do comando 
            cmd.Parameters.AddWithValue("@Nome", nome);

            //abro conexão 
            conn.Open();

            //instância do leitor 
            SqlCeDataReader leitor = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (leitor.Read())
            {
                //passo os valores para o objeto paciente
                //que será retornado 
                paciente.NomeCompleto = leitor["Nome"].ToString();
                paciente.Id = Convert.ToInt32(leitor["Id"].ToString());
            }

            //fecha conexão 
            conn.Close();

            //Retorno o objeto paciente cujo o  
            //nome é igual ao informado no parâmetro 
            return paciente;
        }
        private Paciente ObterPacientePorCpf(string cpf)
        {
            //objeto paciente que será retornado pelo método 
            Paciente paciente = new Paciente();

            //instância da conexão 
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

            //string com o comando a ser executado 
            string sql = "SELECT * from Paciente WHERE Cpf = @Cpf";

            //instância do comando recebendo como parâmetro 
            //a string com o comando e a conexão 
            SqlCeCommand cmd = new SqlCeCommand(sql, conn);

            //informo o parâmetro do comando 
            cmd.Parameters.AddWithValue("@Cpf", cpf);

            //abro conexão 
            conn.Open();

            //instância do leitor 
            SqlCeDataReader leitor = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (leitor.Read())
            {
                //passo os valores para o objeto paciente
                //que será retornado 

                paciente.NomeCompleto = leitor["Nome"].ToString();
                paciente.Id = Convert.ToInt32(leitor["Id"].ToString());
            }

            //fecha conexão 
            conn.Close();

            //Retorno o objeto paciente cujo o  
            //nome é igual ao informado no parâmetro 
            return paciente;
        }

        private void panelconsultacadastro2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPesquisar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        

        private void LtbMedicResp_MouseClick(object sender, MouseEventArgs e)
        {    
                //variável recebe o objeto medico retornado pelo método 
                Especialista especialista = ObterEspecialistaPorCategoria(LtbMedicResp.SelectedItem.ToString());

                //passo os valores para os textbox
                BmtIdMedico.Text = especialista.Id.ToString();
                CkbSegunda.Checked = especialista.Atendimentosegunda;
                CkbTerca.Checked = especialista.Atendimentoterca;
                CkbQuarta.Checked = especialista.Atendimentoquarta;
                CkbQuinta.Checked = especialista.Atendimentoquinta;
                CkbSexta.Checked = especialista.Atendimentosexta;
                CkbSabado.Checked = especialista.Atendimentosabado;
                CkbDomingo.Checked = especialista.Atendimentodomingo;
                mtbHoraInicial.Text = especialista.Horaatendimentoini;
                MtbHorafim.Text = especialista.Horaatendimentofim;

      
        }
        private Especialista ObterEspecialistaPorCategoria(string nome)
        {

            //objeto medico que será retornado pelo método 
            Especialista especialista = new Especialista();

            //instância da conexão 
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

            //string com o comando a ser executado 
            string sql = "SELECT * from Especialista WHERE Nome = @Nome";

            //instância do comando recebendo como parâmetro 
            //a string com o comando e a conexão 
            SqlCeCommand cmd = new SqlCeCommand(sql, conn);

            //informo o parâmetro do comando 
            cmd.Parameters.AddWithValue("@Nome", nome);

            //abro conexão 
            conn.Open();

            //instância do leitor 
            SqlCeDataReader leitor = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (leitor.Read())
            {
                //passo os valores para o objeto paciente
                //que será retornado 
                especialista.Id = Convert.ToInt32(leitor["Id"].ToString());
                especialista.Atendimentosegunda = Convert.ToBoolean(leitor["AtendimentoSegunda"].ToString());
                especialista.Atendimentoterca = Convert.ToBoolean(leitor["Atendimentoterca"].ToString());
                especialista.Atendimentoquarta = Convert.ToBoolean(leitor["AtendimentoQuarta"].ToString());
                especialista.Atendimentoquinta = Convert.ToBoolean(leitor["AtendimentoQuinta"].ToString());
                especialista.Atendimentosexta = Convert.ToBoolean(leitor["AtendimentoSexta"].ToString());
                especialista.Atendimentosabado = Convert.ToBoolean(leitor["AtendimentoSabado"].ToString());
                especialista.Atendimentodomingo = Convert.ToBoolean(leitor["AtendimentoDomingo"].ToString());
                especialista.Horaatendimentoini = leitor["HoraAtendimentoIni"].ToString();
                especialista.Horaatendimentofim = leitor["HoraAtendimentoFim"].ToString();
            }

            //fecha conexão 
            conn.Close();

            //Retorno o objeto paciente cujo o  
            //nome é igual ao informado no parâmetro 
            return especialista;
        }
 
        private void cmbFiltrarCategoriaMedica_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbFiltrarCategoriaMedica.Text == "Acupunturista")
            {

                //instância da conexão 
                SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

                //string com o comando a ser executado 
                string sql = "SELECT Nome from Especialista WHERE (Status = 0) AND (Especialidade1 = 0)";

                //instância do comando recebendo como parâmetro 
                //a string com o comando e a conexão 
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //abro conexão 
                conn.Open();

                //instância do leitor 
                SqlCeDataReader leitor = cmd.ExecuteReader();

                LtbMedicResp.Items.Clear();
                //enquanto leitor lê 
                while (leitor.Read())
                {
                    //para cada iteração adiciono o nome 
                    //ao listbox 
                    LtbMedicResp.Items.Add(leitor["Nome"].ToString());
                }

                //fecha conexão 
                conn.Close();

            }
            if (cmbFiltrarCategoriaMedica.Text == "Cardiologista")
            {

                //instância da conexão 
                SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

                //string com o comando a ser executado 
                string sql = "SELECT Nome from Especialista WHERE (Status = 0) AND (Especialidade1 = 1)";

                //instância do comando recebendo como parâmetro 
                //a string com o comando e a conexão 
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //abro conexão 
                conn.Open();

                //instância do leitor 
                SqlCeDataReader leitor = cmd.ExecuteReader();


                LtbMedicResp.Items.Clear();
                //enquanto leitor lê 
                while (leitor.Read())
                {
                    //para cada iteração adiciono o nome 
                    //ao listbox 
                    LtbMedicResp.Items.Add(leitor["Nome"].ToString());
                }

                //fecha conexão 
                conn.Close();
            }
            if (cmbFiltrarCategoriaMedica.Text == "Cirurgião Geral")
            {

                //instância da conexão 
                SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

                //string com o comando a ser executado 
                string sql = "SELECT Nome from Especialista WHERE (Status = 0) AND (Especialidade1 = 2)";

                //instância do comando recebendo como parâmetro 
                //a string com o comando e a conexão 
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //abro conexão 
                conn.Open();

                //instância do leitor 
                SqlCeDataReader leitor = cmd.ExecuteReader();


                LtbMedicResp.Items.Clear();
                //enquanto leitor lê 
                while (leitor.Read())
                {
                    //para cada iteração adiciono o nome 
                    //ao listbox 
                    LtbMedicResp.Items.Add(leitor["Nome"].ToString());
                }

                //fecha conexão 
                conn.Close();

            }
              if (cmbFiltrarCategoriaMedica.Text == "Clínico Geral")
            {

                //instância da conexão 
                SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

                //string com o comando a ser executado 
                string sql = "SELECT Nome from Especialista WHERE (Status = 0) AND (Especialidade1 = 3)";

                //instância do comando recebendo como parâmetro 
                //a string com o comando e a conexão 
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //abro conexão 
                conn.Open();

                //instância do leitor 
                SqlCeDataReader leitor = cmd.ExecuteReader();


                LtbMedicResp.Items.Clear();
                //enquanto leitor lê 
                while (leitor.Read())
                {
                    //para cada iteração adiciono o nome 
                    //ao listbox 
                    LtbMedicResp.Items.Add(leitor["Nome"].ToString());
                }

                //fecha conexão 
                conn.Close();

            }
              if (cmbFiltrarCategoriaMedica.Text == "Dermatologista")
            {

                //instância da conexão 
                SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

                //string com o comando a ser executado 
                string sql = "SELECT Nome from Especialista WHERE (Status = 0) AND (Especialidade1 = 4)";

                //instância do comando recebendo como parâmetro 
                //a string com o comando e a conexão 
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //abro conexão 
                conn.Open();

                //instância do leitor 
                SqlCeDataReader leitor = cmd.ExecuteReader();


                LtbMedicResp.Items.Clear();
                //enquanto leitor lê 
                while (leitor.Read())
                {
                    //para cada iteração adiciono o nome 
                    //ao listbox 
                    LtbMedicResp.Items.Add(leitor["Nome"].ToString());
                }

                //fecha conexão 
                conn.Close();

            }
              if (cmbFiltrarCategoriaMedica.Text == "Infectologista")
            {

                //instância da conexão 
                SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

                //string com o comando a ser executado 
                string sql = "SELECT Nome from Especialista WHERE (Status = 0) AND (Especialidade1 = 5)";

                //instância do comando recebendo como parâmetro 
                //a string com o comando e a conexão 
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //abro conexão 
                conn.Open();

                //instância do leitor 
                SqlCeDataReader leitor = cmd.ExecuteReader();


                LtbMedicResp.Items.Clear();
                //enquanto leitor lê 
                while (leitor.Read())
                {
                    //para cada iteração adiciono o nome 
                    //ao listbox 
                    LtbMedicResp.Items.Add(leitor["Nome"].ToString());
                }

                //fecha conexão 
                conn.Close();

            }
              if (cmbFiltrarCategoriaMedica.Text == "Neurologista")
            {

                //instância da conexão 
                SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

                //string com o comando a ser executado 
                string sql = "SELECT Nome from Especialista WHERE (Status = 0) AND (Especialidade1 = 6)";

                //instância do comando recebendo como parâmetro 
                //a string com o comando e a conexão 
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //abro conexão 
                conn.Open();

                //instância do leitor 
                SqlCeDataReader leitor = cmd.ExecuteReader();


                LtbMedicResp.Items.Clear();
                //enquanto leitor lê 
                while (leitor.Read())
                {
                    //para cada iteração adiciono o nome 
                    //ao listbox 
                    LtbMedicResp.Items.Add(leitor["Nome"].ToString());
                }

                //fecha conexão 
                conn.Close();

            }
                if (cmbFiltrarCategoriaMedica.Text == "Nutrologista")
            {

                //instância da conexão 
                SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

                //string com o comando a ser executado 
                string sql = "SELECT Nome from Especialista WHERE (Status = 0) AND (Especialidade1 = 7)";

                //instância do comando recebendo como parâmetro 
                //a string com o comando e a conexão 
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //abro conexão 
                conn.Open();

                //instância do leitor 
                SqlCeDataReader leitor = cmd.ExecuteReader();


                LtbMedicResp.Items.Clear();
                //enquanto leitor lê 
                while (leitor.Read())
                {
                    //para cada iteração adiciono o nome 
                    //ao listbox 
                    LtbMedicResp.Items.Add(leitor["Nome"].ToString());
                }

                //fecha conexão 
                conn.Close();

            }
             
                if (cmbFiltrarCategoriaMedica.Text == "Pediatra")
            {

                //instância da conexão 
                SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

                //string com o comando a ser executado 
                string sql = "SELECT Nome from Especialista WHERE (Status = 0) AND (Especialidade1 = 8)";

                //instância do comando recebendo como parâmetro 
                //a string com o comando e a conexão 
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //abro conexão 
                conn.Open();

                //instância do leitor 
                SqlCeDataReader leitor = cmd.ExecuteReader();


                LtbMedicResp.Items.Clear();
                //enquanto leitor lê 
                while (leitor.Read())
                {
                    //para cada iteração adiciono o nome 
                    //ao listbox 
                    LtbMedicResp.Items.Add(leitor["Nome"].ToString());
                }

                //fecha conexão 
                conn.Close();

            }
                if (cmbFiltrarCategoriaMedica.Text == "Psiquiatra")
            {

                //instância da conexão 
                SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

                //string com o comando a ser executado 
                string sql = "SELECT Nome from Especialista WHERE (Status = 0) AND (Especialidade1 = 9)";

                //instância do comando recebendo como parâmetro 
                //a string com o comando e a conexão 
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //abro conexão 
                conn.Open();

                //instância do leitor 
                SqlCeDataReader leitor = cmd.ExecuteReader();


                LtbMedicResp.Items.Clear();
                //enquanto leitor lê 
                while (leitor.Read())
                {
                    //para cada iteração adiciono o nome 
                    //ao listbox 
                    LtbMedicResp.Items.Add(leitor["Nome"].ToString());
                }

                //fecha conexão 
                conn.Close();

            }


        }

        private void LtbMedicResp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GpbDados_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void BtnVerificarHora_Click(object sender, EventArgs e)
        {
           //criar comparação
                MessageBox.Show("Horario Disponível!");
            

        }

        private void LtbMedicResp_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

      
       

      

        
    }
}
