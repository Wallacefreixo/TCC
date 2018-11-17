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
using Dados;
using Negocio;
using System.Data.SqlServerCe;

namespace Visao
{
    public partial class DashAgendamento : UserControl
    {
        //Atributos
        private Consulta consulta;
        private Especialista user;

        public DashAgendamento()
        {
            InitializeComponent();

           
        }

        private void BtncadastrarConsulta_Click(object sender, EventArgs e)
        {
            panelcadastroconsulta.Controls.Clear();
            DashAgendamentoCadastro novo = new DashAgendamentoCadastro();
            panelcadastroconsulta.Controls.Add(novo);
            novo.Show();
        }

        private void DashConsulta_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            this.user = (Especialista)this.Tag;
            txtnomeSecretaria.Text = this.user.Nomecompleto;
        }


        private void CarregarGrid()
        {
            try
            {
                DtvConsultas.Rows.Clear();

                /*
            List<Agendamento> listaAgendamentos = CtrlAgendamento.BuscarTodos();

            foreach (Agendamento ag in listaAgendamentos)
            {
                DtvConsultas.Rows.Add(ag.Id, ag.Paciente.NomeCompleto, ag.Especialista.Nomecompleto, ag.Especialista.Especialidade1, ag.Data, ag.Horario);
            }
             */
            
           ConsultaCtrl controle = new ConsultaCtrl();

           List<Consulta> listaConsultas = controle.BuscarTodasConsultas();

           foreach (Consulta c in listaConsultas)
           {
               DtvConsultas.Rows.Add(c.Id, c.Status, c.Nomepaciente, c.Medicoresp, c.Data, c.Horario);
           }
         
            }

            catch (Exception ex)
            {

                MessageBox.Show("ERRO: " + ex.Message);
            }
        }


        private void panelcadastroconsulta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbmFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmFiltrar.Text == "Data")
            {
                txtPesquisar.Mask = "00/00/0000";
                txtPesquisar.Text = "";
                cmbFiltrarStatus.SelectedItem = null;
            }
            if (cbmFiltrar.Text == "")
            {
                txtPesquisar.Mask = "";
                txtPesquisar.Text = "";
                cmbFiltrarStatus.SelectedItem = null;
            }
        }

 

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                DtvConsultas.Rows.Clear();

                if (cbmFiltrar.Text == "Data" && cmbFiltrarStatus.Text == "Confirmada")
                {
                    Consulta consulta = null;

                    try
                    {
                        string sql = "SELECT Consulta.Id, Consulta.IdPaciente, Consulta.IdMedico, Consulta.Motivo, Consulta.HorarioAtendimento, Consulta.Data, Consulta.Status, Paciente.Nome, Especialista.Nome, Especialista.Especialidade1 FROM Consulta INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id WHERE (Consulta.Status=0) AND Data LIKE '%" + txtPesquisar.Text + "%'";
                        SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                        while (data.Read())
                        {
                            consulta = new Consulta();

                            consulta.Id = data.GetInt32(0);
                            consulta.Idpaciente = data.GetInt32(1);
                            consulta.Idmedico = data.GetInt32(2);
                            consulta.Motivo = data.GetString(3);
                            consulta.Horario = data.GetString(4);
                            consulta.Data = data.GetString(5);
                            consulta.Status = data.GetString(6);
                            consulta.Nomepaciente = data.GetString(7);
                            consulta.Medicoresp = data.GetString(8);
                            consulta.Tipoconsulta = data.GetString(9);

                            DtvConsultas.Rows.Add(consulta.Id, consulta.Status, consulta.Nomepaciente, consulta.Medicoresp, consulta.Data, consulta.Horario);
                        }

                        data.Close();
                        BancodeDados.FecharConexao();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                }
                if (cbmFiltrar.Text == "Data" && cmbFiltrarStatus.Text == "Cancelada")
                {
                    Consulta consulta = null;

                    try
                    {
                        string sql = "SELECT Consulta.Id, Consulta.IdPaciente, Consulta.IdMedico, Consulta.Motivo, Consulta.HorarioAtendimento, Consulta.Data, Consulta.Status, Paciente.Nome, Especialista.Nome, Especialista.Especialidade1 FROM Consulta INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id WHERE (Consulta.Status=1) AND Data LIKE '%" + txtPesquisar.Text + "%'";
                        SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                        while (data.Read())
                        {
                            consulta = new Consulta();

                            consulta.Id = data.GetInt32(0);
                            consulta.Idpaciente = data.GetInt32(1);
                            consulta.Idmedico = data.GetInt32(2);
                            consulta.Motivo = data.GetString(3);
                            consulta.Horario = data.GetString(4);
                            consulta.Data = data.GetString(5);
                            consulta.Status = data.GetString(6);
                            consulta.Nomepaciente = data.GetString(7);
                            consulta.Medicoresp = data.GetString(8);
                            consulta.Tipoconsulta = data.GetString(9);

                            DtvConsultas.Rows.Add(consulta.Id, consulta.Status, consulta.Nomepaciente, consulta.Medicoresp, consulta.Data, consulta.Horario);
                        }

                        data.Close();
                        BancodeDados.FecharConexao();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                }
                if (cbmFiltrar.Text == "Data" && cmbFiltrarStatus.Text == "Realizada")
                {
                    Consulta consulta = null;

                    try
                    {
                        string sql = "SELECT Consulta.Id, Consulta.IdPaciente, Consulta.IdMedico, Consulta.Motivo, Consulta.HorarioAtendimento, Consulta.Data, Consulta.Status, Paciente.Nome, Especialista.Nome, Especialista.Especialidade1 FROM Consulta INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id WHERE (Consulta.Status=2) AND Data LIKE '%" + txtPesquisar.Text + "%'";
                        SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                        while (data.Read())
                        {
                            consulta = new Consulta();

                            consulta.Id = data.GetInt32(0);
                            consulta.Idpaciente = data.GetInt32(1);
                            consulta.Idmedico = data.GetInt32(2);
                            consulta.Motivo = data.GetString(3);
                            consulta.Horario = data.GetString(4);
                            consulta.Data = data.GetString(5);
                            consulta.Status = data.GetString(6);
                            consulta.Nomepaciente = data.GetString(7);
                            consulta.Medicoresp = data.GetString(8);
                            consulta.Tipoconsulta = data.GetString(9);

                            DtvConsultas.Rows.Add(consulta.Id, consulta.Status, consulta.Nomepaciente, consulta.Medicoresp, consulta.Data, consulta.Horario);
                        }

                        data.Close();
                        BancodeDados.FecharConexao();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                }
                
                if (cbmFiltrar.Text == "Data" && cmbFiltrarStatus.Text == "")
                {
                    Consulta consulta = null;

                    try
                    {
                        string sql = "SELECT Consulta.Id, Consulta.IdPaciente, Consulta.IdMedico, Consulta.Motivo, Consulta.HorarioAtendimento, Consulta.Data, Consulta.Status, Paciente.Nome, Especialista.Nome, Especialista.Especialidade1 FROM Consulta INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id WHERE Data LIKE '%" + txtPesquisar.Text + "%'";
                        SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                        while (data.Read())
                        {
                            consulta = new Consulta();

                            consulta.Id = data.GetInt32(0);
                            consulta.Idpaciente = data.GetInt32(1);
                            consulta.Idmedico = data.GetInt32(2);
                            consulta.Motivo = data.GetString(3);
                            consulta.Horario = data.GetString(4);
                            consulta.Data = data.GetString(5);
                            consulta.Status = data.GetString(6);
                            consulta.Nomepaciente = data.GetString(7);
                            consulta.Medicoresp = data.GetString(8);
                            consulta.Tipoconsulta = data.GetString(9);

                            DtvConsultas.Rows.Add(consulta.Id, consulta.Status, consulta.Nomepaciente, consulta.Medicoresp, consulta.Data, consulta.Horario);
                        }

                        data.Close();
                        BancodeDados.FecharConexao();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                }

            
                
                if (cbmFiltrar.Text == "")
                {
                    CarregarGrid();
                }

            }
            catch (Exception ex)
            {
                //Caso haja uma exceção
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            labelStatus.Visible = false;
            cmbFiltrarStatus.Visible = false;
            BtnDeletar.Visible = false;
            btnDados.Visible = false;
            label.Visible = false;
            BtnAtualizar.Visible = false;
            DtvConsultas.Visible = false;
            BtncadastrarConsulta.Visible = false;
            btnBuscar.Visible = false;
            txtConsultas.Visible = false;
            txtPesquisar.Visible = false;
            cbmFiltrar.Visible = false;
            labelAtt.Visible = false;
            labeldeletar.Visible = false;
            labelvisualizar.Visible = false;
            txtnomeSecretaria.Visible = false;

            MtbHorafim.Visible = true;
            mtbHoraInicial.Visible = true;
            DadosPaciente.Visible = true;
            DadosMedico.Visible = true;
            GpbDados.Visible = true;
            BtnCancelar.Visible = true;
            BtnSalvarAlteracoes.Visible = true;
            BtnVerificarHora.Visible = true;
            txtAtualizar.Visible = true;
            txtHorario.Visible = true;
            txtIni.Visible = true;
            txtFim.Visible = true;
            CkbSegunda.Visible = true;
            CkbTerca.Visible = true;
            CkbQuarta.Visible = true;
            CkbQuinta.Visible = true;
            CkbSexta.Visible = true;
            CkbSabado.Visible = true;
            CkbDomingo.Visible = true;

            DadosPaciente.Enabled = true;
            DadosMedico.Enabled = true;
            GpbDados.Enabled = true;


            int id = int.Parse(DtvConsultas.SelectedRows[0].Cells[0].Value.ToString());

            ConsultaCtrl controle = new ConsultaCtrl();

            this.consulta = controle.BuscarConsultaID(id);

            // Metodo para carregar paciente do form
            CarregarFormDeConsulta(this.consulta);
        }

        private void CarregarFormDeConsulta(Consulta _consulta)
        {
            try
            {
                BmtIdPaciente.Text = _consulta.Idpaciente.ToString();
                BmtIdMedico.Text = consulta.Idmedico.ToString();
                BmtMotivo.Text = _consulta.Motivo;
                MtbHorario.Text = _consulta.Horario;
                MtbData.Text = _consulta.Data;
                CmbStatus.SelectedIndex = int.Parse(_consulta.Status);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }


        private void limpaFormulario()
        {
            BmtIdPaciente.Text = "";
            BmtIdMedico.Text = "";
            BmtMotivo.Text = "";
            MtbHorario.Text = "";
            MtbData.Text = "";
            TxtPesquisarPaciente.Text = "";
            cmbFiltrarPaciente.SelectedItem = null;
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
            LtbMedicResp.Items.Clear();
            cbmFiltrar.SelectedItem = null;
            txtPesquisar.Text = "";
            LtbMedicResp.Items.Clear();


        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            int id = (int)DtvConsultas.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Deseja deletar a consulta de id = " + id + "?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    ConsultaCtrl controle = new ConsultaCtrl();
                    controle.DeletarConsulta(id);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message);
                }
                CarregarGrid();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnDeletar.Visible = true;
            btnDados.Visible = true;
            BtnAtualizar.Visible = true;
            label.Visible = true;
            DtvConsultas.Visible = true;
            BtncadastrarConsulta.Visible = true;
            btnBuscar.Visible = true;
            txtConsultas.Visible = true;
            txtPesquisar.Visible = true;
            cbmFiltrar.Visible = true;
            txtnomeSecretaria.Visible = true;
            labelStatus.Visible = true;
            cmbFiltrarStatus.Visible = true;
            labelAtt.Visible = true;
            labeldeletar.Visible = true;
            labelvisualizar.Visible = true;

            MtbHorafim.Visible = false;
            mtbHoraInicial.Visible = false;
            DadosPaciente.Visible = false;
            DadosMedico.Visible = false;
            GpbDados.Visible = false;
            BtnCancelar.Visible = false;
            BtnSalvarAlteracoes.Visible = false;
            BtnVerificarHora.Visible = false;
            txtAtualizar.Visible = false;
            txtHorario.Visible = false;
            txtIni.Visible = false;
            txtFim.Visible = false;
            CkbSegunda.Visible = false;
            CkbTerca.Visible = false;
            CkbQuarta.Visible = false;
            CkbQuinta.Visible = false;
            CkbSexta.Visible = false;
            CkbSabado.Visible = false;
            CkbDomingo.Visible = false;

            limpaFormulario();
        }

        private void BtnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
         try{
                ConsultaCtrl controle = new ConsultaCtrl();
                
                consulta.Idpaciente = int.Parse(BmtIdPaciente.Text);
                consulta.Idmedico = int.Parse(BmtIdMedico.Text); 
                consulta.Motivo = BmtMotivo.Text;
                consulta.Horario = MtbHorario.Text;
                consulta.Data = MtbData.Text;
                consulta.Status = CmbStatus.SelectedIndex.ToString();


                controle.AtualizarConsulta(consulta);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            MessageBox.Show("Consulta atualizado com sucesso!");
            limpaFormulario();
            CarregarGrid();

            BtnDeletar.Visible = true;
            btnDados.Visible = true;
            BtnAtualizar.Visible = true;
            DtvConsultas.Visible = true;
            label.Visible = true;
            BtncadastrarConsulta.Visible = true;
            btnBuscar.Visible = true;
            txtConsultas.Visible = true;
            txtPesquisar.Visible = true;
            cbmFiltrar.Visible = true;
            txtnomeSecretaria.Visible = true;
            labelStatus.Visible = true;
            cmbFiltrarStatus.Visible = true;
            labelAtt.Visible = true;
            labeldeletar.Visible = true;
            labelvisualizar.Visible = true;

            MtbHorafim.Visible = false;
            mtbHoraInicial.Visible = false;
            DadosPaciente.Visible = false;
            DadosMedico.Visible = false;
            GpbDados.Visible = false;
            BtnCancelar.Visible = false;
            BtnSalvarAlteracoes.Visible = false;
            BtnVerificarHora.Visible = false;
            txtAtualizar.Visible = false;
            txtHorario.Visible = false;
            txtIni.Visible = false;
            txtFim.Visible = false;
            CkbSegunda.Visible = false;
            CkbTerca.Visible = false;
            CkbQuarta.Visible = false;
            CkbQuinta.Visible = false;
            CkbSexta.Visible = false;
            CkbSabado.Visible = false;
            CkbDomingo.Visible = false;


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

        private void cmbFiltrarCategoriaMedica_SelectedIndexChanged_1(object sender, EventArgs e)
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


        private void btnbuscarPaciente_Click(object sender, EventArgs e)
        {
            if (cmbFiltrarPaciente.Text == "Nome Completo")
            {
                try
                {
                    //variável recebe o objeto cliente retornado pelo método 
                    Paciente paciente = ObterPacientePorNome(TxtPesquisarPaciente.Text);

                    //passo os valores para os textbox 

                    MessageBox.Show("Paciente encontrado com nome: " + paciente.NomeCompleto.ToString());
                    BmtIdPaciente.Text = paciente.Id.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message);
                }

            }
            if (cmbFiltrarPaciente.Text == "CPF")
            {
                try
                {
                    //variável recebe o objeto cliente retornado pelo método 
                    Paciente paciente = ObterPacientePorCpf(TxtPesquisarPaciente.Text);


                    //passo os valores para os textbox 

                    MessageBox.Show("Paciente encontrado com nome: " + paciente.NomeCompleto.ToString());
                    BmtIdPaciente.Text = paciente.Id.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message);
                }

            }
            if (cmbFiltrarPaciente.Text == "RG")
            {
                try
                {
                    //variável recebe o objeto cliente retornado pelo método 
                    Paciente paciente = ObterPacientePorRg(TxtPesquisarPaciente.Text);

                    //passo os valores para os textbox 

                    MessageBox.Show("Paciente encontrado com nome: " + paciente.NomeCompleto.ToString());
                    BmtIdPaciente.Text = paciente.Id.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message);
                }

            }
            if (cmbFiltrarPaciente.Text == "ID")
            {
                try
                {
                    //variável recebe o objeto cliente retornado pelo método 
                    Paciente paciente = ObterPacientePorId(TxtPesquisarPaciente.Text);

                    //passo os valores para os textbox 
                    MessageBox.Show("Paciente encontrado com nome: " + paciente.NomeCompleto.ToString());
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

        private void cmbFiltrarPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrarPaciente.Text == "Nome Completo")
            {
                TxtPesquisarPaciente.Mask = "";
                TxtPesquisarPaciente.Text = "";

            }
            if (cmbFiltrarPaciente.Text == "CPF")
            {
                TxtPesquisarPaciente.Mask = "000.000.000-00";
                TxtPesquisarPaciente.Text = "";
            }
            if (cmbFiltrarPaciente.Text == "")
            {
                TxtPesquisarPaciente.Mask = "";
                TxtPesquisarPaciente.Text = "";
                BmtIdPaciente.Text = "";
            }
            if (cmbFiltrarPaciente.Text == "RG")
            {
                TxtPesquisarPaciente.Mask = "00.000.000-0";
                TxtPesquisarPaciente.Text = "";
            }
            
        }

        private void panelconsultacadastro2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LtbMedicResp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DtvConsultas.SelectedRows[0].Cells[0].Value.ToString());

            ConsultaCtrl controle = new ConsultaCtrl();

            this.consulta = controle.BuscarConsultaID(id);

            // Metodo para carregar paciente do form
            CarregarFormDeConsulta(this.consulta);


            BtnDeletar.Visible = false;
            btnDados.Visible = false;
            label.Visible = false;
            BtnAtualizar.Visible = false;
            DtvConsultas.Visible = false;
            BtncadastrarConsulta.Visible = false;
            btnBuscar.Visible = false;
            txtConsultas.Visible = false;
            txtPesquisar.Visible = false;
            cbmFiltrar.Visible = false;
            labelAtt.Visible = false;
            labeldeletar.Visible = false;
            labelvisualizar.Visible = false;
            txtnomeSecretaria.Visible = false;
            labelStatus.Visible = false;
            cmbFiltrarStatus.Visible = false;
            BtnSalvarAlteracoes.Visible = false;
            BtnCancelar.Visible = false;

            btnbuscarPaciente.Visible = true;
            btnimprimir.Visible = true;
            labelimprimir.Visible = true;
            labelvisualizaragenda.Visible = true;
            btnVoltar.Visible = true;
            MtbHorafim.Visible = true;
            mtbHoraInicial.Visible = true;
            DadosPaciente.Visible = true;
            DadosMedico.Visible = true;
            GpbDados.Visible = true;
            txtHorario.Visible = true;
            txtIni.Visible = true;
            txtFim.Visible = true;
            CkbSegunda.Visible = true;
            CkbTerca.Visible = true;
            CkbQuarta.Visible = true;
            CkbQuinta.Visible = true;
            CkbSexta.Visible = true;
            CkbSabado.Visible = true;
            CkbDomingo.Visible = true;

            DadosPaciente.Enabled = false;
            DadosMedico.Enabled = false;
            GpbDados.Enabled = false;
           
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DadosPaciente.Enabled = true;
            DadosMedico.Enabled = true;
            GpbDados.Enabled = true;

            labelStatus.Visible = true;
            cmbFiltrarStatus.Visible = true;
            BtnDeletar.Visible = true;
            btnDados.Visible = true;
            label.Visible = true;
            BtnAtualizar.Visible = true;
            DtvConsultas.Visible = true;
            BtncadastrarConsulta.Visible = true;
            btnBuscar.Visible = true;
            txtConsultas.Visible = true;
            txtPesquisar.Visible = true;
            cbmFiltrar.Visible = true;
            labelAtt.Visible = true;
            labeldeletar.Visible = true;
            labelvisualizar.Visible = true;
            txtnomeSecretaria.Visible = true;

            btnimprimir.Visible = false;
            labelimprimir.Visible = false;
            labelvisualizaragenda.Visible = false;
            btnVoltar.Visible = false;
            MtbHorafim.Visible = false;
            mtbHoraInicial.Visible = false;
            DadosPaciente.Visible = false;
            DadosMedico.Visible = false;
            GpbDados.Visible = false;
            BtnCancelar.Visible = false;
            BtnSalvarAlteracoes.Visible = false;
            BtnVerificarHora.Visible = false;
            txtAtualizar.Visible = false;
            txtHorario.Visible = false;
            txtIni.Visible = false;
            txtFim.Visible = false;
            CkbSegunda.Visible = false;
            CkbTerca.Visible = false;
            CkbQuarta.Visible = false;
            CkbQuinta.Visible = false;
            CkbSexta.Visible = false;
            CkbSabado.Visible = false;
            CkbDomingo.Visible = false;

        }

        private void BtnVerificarHora_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Horario Disponível!");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(BmtIdPaciente.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawString(BmtIdMedico.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 150));
            e.Graphics.DrawString(MtbHorario.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 200));
            e.Graphics.DrawString(MtbData.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 250));
            e.Graphics.DrawString(CmbStatus.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 300));
            e.Graphics.DrawString(BmtMotivo.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 350));
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void LtbMedicResp_Click(object sender, EventArgs e)
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
       
    }
}
