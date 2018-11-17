using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using Controle;
using Negocio;
using Dados;

namespace Visao
{
    public partial class DashConsultaCadastro : UserControl
    {
        private Especialista user;
        private int idmedico;
        private int idconsulta;
        private Consulta consulta = null;

        public DashConsultaCadastro()
        {
            InitializeComponent();


        }
        private void CarregarGrid()
        {

            DtvConsultas.Rows.Clear();

            try
            {

                string sql = "SELECT Consulta.Id, Consulta.IdPaciente, Consulta.IdMedico, Consulta.Motivo, Consulta.HorarioAtendimento, Consulta.Data, Consulta.Status, Paciente.Nome, Paciente.Cpf, Paciente.Telefone, Paciente.Celular, Paciente.Email FROM Consulta INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id WHERE (Status=0) AND IdMedico LIKE  '%" + idmedico + "%' ";
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
                    consulta.Cpf = data.GetString(8);
                    consulta.Telefone = data.GetString(9);
                    consulta.Celular = data.GetString(10);
                    consulta.Email = data.GetString(11);

                    DtvConsultas.Rows.Add(consulta.Id, consulta.Nomepaciente, consulta.Cpf, consulta.Telefone, consulta.Celular, consulta.Data, consulta.Horario);

                }

                data.Close();
                BancodeDados.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        private void ButtonSalvarLaudo_Click(object sender, EventArgs e)
        {
            try
            {
                LaudoCtrl controle = new LaudoCtrl();

                Laudo laudo = CarregarLaudoDoForm();

                controle.InserirLaudo(laudo);

                MessageBox.Show("Laudo cadastrado com sucesso!!");

                limpaFormularioLaudo();


                btnaddLaudo.Visible = true;

                btnImprmirLaudo.Visible = false;
                labelimprimirLaudo.Visible = false;
                GpbLaudo.Visible = false;
                ButtonSalvarLaudo.Visible = false;
                btnaddLaudo.Enabled = false;
                btnCancelarLaudo.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }
        //função Limpa formulario apos cadastrar
        private void limpaFormularioReceita()
        {
            bmtidconsulta.Text = "";
            mtbdata.Text = "";
            bmtObs.Text = "";
            ListEx2.Items.Clear();
            ListMed2.Items.Clear();




        }

        private void limpaFormularioLaudo()
        {

            bmtidconsulta2.Text = "";
            mtbdata2.Text = "";
            BmtObs2.Text = "";
            cmbexame2.Items.Clear();
            bmtidexame.Text = "";

        }

        private Laudo CarregarLaudoDoForm()
        {
            //recebe os dados do formulario e joga em uma váriavel da istância laudo

            Laudo l = new Laudo();
            try
            {
                l.Idconsulta = int.Parse(bmtidconsulta2.Text);
                l.Data = mtbdata2.Text;
                l.Obs = BmtObs2.Text;
                l.Idexame = int.Parse(bmtidexame.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            return l;

        }
        private Receituario CarregarReceituarioDoForm()
        {
            //recebe os dados do formulario e joga em uma váriavel da istância laudo

            Receituario r = new Receituario();
            try
            {
                r.Idconsulta = int.Parse(bmtidconsulta.Text);
                r.Data = mtbdata.Text;
                r.Obs = bmtObs.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            return r;

        }


        private void CmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private Laudo ObterConsultaPorData(string id)
        {
            //objeto medico que será retornado pelo método 
            Laudo laudo = new Laudo();

            //instância da conexão 
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

            //string com o comando a ser executado 
            string sql = "SELECT * from Consulta WHERE Id = @Id";

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
                laudo.Id = Convert.ToInt32(leitor["Id"].ToString());
            }

            //fecha conexão 
            conn.Close();

            //Retorno o objeto paciente cujo o  
            //nome é igual ao informado no parâmetro 
            return laudo;

        }



        private void LtbMedicResp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MtbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cbmFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmFiltrar.Text == "Data")
            {
                txtPesquisar.Mask = "00/00/0000";
                txtPesquisarHora.Text = " ";
            }
            if (cbmFiltrar.Text == "")
            {
                txtPesquisar.Mask = "";
                txtPesquisar.Text = "";

                txtPesquisarHora.Mask = "";
                txtPesquisarHora.Text = "";
                cmbFiltrarHora.Text = "";

            }
        }

        private void btnbuscarConsulta_Click(object sender, EventArgs e)
        {

            try
            {

                if (cbmFiltrar.Text == "Data" && cmbFiltrarHora.Text == "Horário")
                {
                    Consulta consulta = null;
                    try
                    {
                        DtvConsultas.Rows.Clear();
                        string sql = "SELECT Consulta.Id, Consulta.IdPaciente, Consulta.IdMedico, Consulta.Motivo, Consulta.HorarioAtendimento, Consulta.Data, Consulta.Status, Paciente.Nome, Paciente.Cpf, Paciente.Telefone, Paciente.Celular, Paciente.Email FROM Consulta INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id WHERE (Status=0) AND Data LIKE '%" + txtPesquisar.Text + "%' AND IdMedico LIKE  '%" + idmedico + "%' AND Consulta.HorarioAtendimento LIKE '%" + txtPesquisarHora.Text + "%'";
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
                            consulta.Cpf = data.GetString(8);
                            consulta.Telefone = data.GetString(9);
                            consulta.Celular = data.GetString(10);


                            DtvConsultas.Rows.Add(consulta.Id, consulta.Nomepaciente, consulta.Cpf, consulta.Telefone, consulta.Celular, consulta.Data, consulta.Horario);

                        }

                        data.Close();
                        BancodeDados.FecharConexao();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                }
                else if (cbmFiltrar.Text == "Data")
                {
                    Consulta consulta = null;

                    try
                    {

                        DtvConsultas.Rows.Clear();
                        string sql = "SELECT Consulta.Id, Consulta.IdPaciente, Consulta.IdMedico, Consulta.Motivo, Consulta.HorarioAtendimento, Consulta.Data, Consulta.Status, Paciente.Nome, Paciente.Cpf, Paciente.Telefone, Paciente.Celular, Paciente.Email FROM Consulta INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id WHERE (Status=0) AND Data LIKE '%" + txtPesquisar.Text + "%' AND IdMedico LIKE  '%" + idmedico + "%' ";
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
                            consulta.Cpf = data.GetString(8);
                            consulta.Telefone = data.GetString(9);
                            consulta.Celular = data.GetString(10);


                            DtvConsultas.Rows.Add(consulta.Id, consulta.Nomepaciente, consulta.Cpf, consulta.Telefone, consulta.Celular, consulta.Data, consulta.Horario);

                        }


                        data.Close();
                        BancodeDados.FecharConexao();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                }

                else if (cbmFiltrar.Text == "")
                {
                    CarregarGrid();

                }

            }


            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        private void GpbDados_Enter(object sender, EventArgs e)
        {

        }

        private void cmbFiltrarID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrarHora.Text == "Horário")
            {
                txtPesquisarHora.Mask = "00:00";
            }
            if (cmbFiltrarHora.Text == "")
            {
                txtPesquisarHora.Mask = "";
                txtPesquisarHora.Text = "";
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void panelcadastrolaudo2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnaddLaudo_Click(object sender, EventArgs e)
        {
            limpaFormularioReceita();
            GpbReceituario.Visible = false;
            btnCancelarReceita.Visible = false;
            btnaddLaudo.Visible = false;
            ButtonSalvarReceituario.Visible = false;
            ButtonSalvarReceituario.Visible = false;
            btnimprimirReceita.Visible = false;
            labelimprimirReceita.Visible = false;

            btnImprmirLaudo.Visible = true;
            labelimprimirLaudo.Visible = true;
            GpbLaudo.Visible = true;
            btnAddReceituário.Visible = true;
            btnCancelarLaudo.Visible = true;
            ButtonSalvarLaudo.Visible = true;

            bmtidconsulta2.Text = idconsulta.ToString();

            //instância da conexão 
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

            //string com o comando a ser executado 
            string sql = "SELECT Nome from Exame";

            //instância do comando recebendo como parâmetro 
            //a string com o comando e a conexão 
            SqlCeCommand cmd = new SqlCeCommand(sql, conn);

            //abro conexão 
            conn.Open();

            //instância do leitor 
            SqlCeDataReader leitor = cmd.ExecuteReader();

            cmbexame2.Items.Clear();
            //enquanto leitor lê 
            while (leitor.Read())
            {
                //para cada iteração adiciono o nome 
                //ao listbox 
                cmbexame2.Items.Add(leitor["Nome"].ToString());
            }

            //fecha conexão 
            conn.Close();


        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            panelConsulta.Controls.Clear();
            DashConsultaCadastro novo = new DashConsultaCadastro();
            panelConsulta.Controls.Add(novo);
            novo.Tag = user;
            novo.Show();
        }

        private void btnAddReceituario_Click(object sender, EventArgs e)
        {
            GpbReceituario.Visible = true;
            btnaddLaudo.Visible = true;
            btnCancelarReceita.Visible = true;
            ButtonSalvarReceituario.Visible = true;
            btnimprimirReceita.Visible = true;
            labelimprimirReceita.Visible = true;

            btnImprmirLaudo.Visible = false;
            labelimprimirLaudo.Visible = false;
            ButtonSalvarLaudo.Visible = false;
            btnAddReceituário.Visible = false;
            btnCancelarLaudo.Visible = false;
            GpbLaudo.Visible = false;
            limpaFormularioLaudo();

            bmtidconsulta.Text = idconsulta.ToString();

            //LISTA DE EXAMES
            try
            {
                //instância da conexão 
                SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

                //string com o comando a ser executado 
                string sql = "SELECT Nome from Exame";

                //instância do comando recebendo como parâmetro 
                //a string com o comando e a conexão 
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //abro conexão 
                conn.Open();

                //instância do leitor 
                SqlCeDataReader leitor = cmd.ExecuteReader();

                ListEx1.Items.Clear();
                //enquanto leitor lê 
                while (leitor.Read())
                {
                    //para cada iteração adiciono o nome 
                    //ao listbox 
                    ListEx1.Items.Add(leitor["Nome"].ToString());
                }

                //fecha conexão 
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

            //LISTA MEDICAMENTOS
            try
            {
                //instância da conexão 
                SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

                //string com o comando a ser executado 
                string sql = "SELECT Nome from Medicamento";

                //instância do comando recebendo como parâmetro 
                //a string com o comando e a conexão 
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //abro conexão 
                conn.Open();

                //instância do leitor 
                SqlCeDataReader leitor = cmd.ExecuteReader();

                ListMed1.Items.Clear();
                //enquanto leitor lê 
                while (leitor.Read())
                {
                    //para cada iteração adiciono o nome 
                    //ao listbox 
                    ListMed1.Items.Add(leitor["Nome"].ToString());
                }

                //fecha conexão 
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }




        }

        private void panelcadastroReceiturario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            limpaFormularioLaudo();
            limpaFormularioReceita();


            GpbReceituario.Visible = false;
            btnaddLaudo.Visible = false;
            btnCancelarReceita.Visible = false;
            ButtonSalvarReceituario.Visible = false;
            btnVoltar2.Visible = false;
            ButtonSalvarLaudo.Visible = false;
            btnAddReceituário.Visible = false;
            btnCancelarLaudo.Visible = false;
            GpbLaudo.Visible = false;
            labelnome.Visible = false;
            txtnome.Visible = false;
            labelcpf.Visible = false;
            txtcpf.Visible = false;
            labelcelular.Visible = false;
            txtcelular.Visible = false;
            labeltelefone.Visible = false;
            txttelefone.Visible = false;
            labelemail.Visible = false;
            txtemail.Visible = false;
            txtIdconsulta.Visible = false;
            idescolhida.Visible = false;
            btnfinalizarconsulta.Visible = false;
            btnimprimirReceita.Visible = false;
            labelimprimirReceita.Visible = false;
            btnImprmirLaudo.Visible = false;
            labelimprimirLaudo.Visible = false;

            btnAddReceituário.Enabled = true;
            btnaddLaudo.Enabled = true;
            btnbuscarConsulta.Visible = true;
            DtvConsultas.Visible = true;
            CarregarGrid();
            medicolabel.Visible = true;
            txtMedico.Visible = true;
            btnRealizarConsulta.Visible = true;
            labelfiltrar.Visible = true;
            cbmFiltrar.Visible = true;
            cmbFiltrarHora.Visible = true;
            txtPesquisar.Visible = true;
            txtPesquisarHora.Visible = true;

        }



        private void btnRemoverExame_Click(object sender, EventArgs e)
        {
            ListEx1.Visible = false;
            btnRemoveExameLista.Visible = false;
            btnAddExamelista.Visible = false;
            ListEx2.Items.Clear();
            ListEx2.Visible = false;

        }

        private void btnRemoverMedicamento_Click(object sender, EventArgs e)
        {

            ListMed1.Visible = false;
            ListMed2.Visible = false;
            adicionamedicamentoslista.Visible = false;
            removemedicamentolista.Visible = false;
            ListMed2.Items.Clear();


        }

        private void btnCancelarReceituário_Click(object sender, EventArgs e)
        {
            GpbReceituario.Visible = false;
            btnAddReceituário.Visible = true;

            btnimprimirReceita.Visible = false;
            labelimprimirReceita.Visible = false;
            ButtonSalvarReceituario.Visible = false;
            btnCancelarReceita.Visible = false;
            limpaFormularioReceita();
        }

        private void btnCancelarLaudo_Click(object sender, EventArgs e)
        {
            btnImprmirLaudo.Visible = false;
            labelimprimirLaudo.Visible = false;
            GpbLaudo.Visible = false;
            btnCancelarLaudo.Visible = false;
            ButtonSalvarLaudo.Visible = false;
            btnaddLaudo.Visible = true;
            limpaFormularioLaudo();

        }

        private void btnfinalizarconsulta_Click(object sender, EventArgs e)
        {
            try
            {
                String valor = "2";
                String id = idescolhida.Text;
                string sql = String.Format("UPDATE Consulta SET Status ='{0}' WHERE Id={1}",
                    valor,
                    id
                    );

                BancodeDados.ExecutarSQLAlter(sql);

                MessageBox.Show("Consulta Realizada com sucesso!!");


                limpaFormularioLaudo();
                limpaFormularioReceita();


                GpbReceituario.Visible = false;
                btnaddLaudo.Visible = false;
                btnCancelarReceita.Visible = false;
                ButtonSalvarReceituario.Visible = false;
                btnVoltar2.Visible = false;
                ButtonSalvarLaudo.Visible = false;
                btnAddReceituário.Visible = false;
                btnCancelarLaudo.Visible = false;
                GpbLaudo.Visible = false;
                labelnome.Visible = false;
                txtnome.Visible = false;
                labelcpf.Visible = false;
                txtcpf.Visible = false;
                labelcelular.Visible = false;
                txtcelular.Visible = false;
                labeltelefone.Visible = false;
                txttelefone.Visible = false;
                labelemail.Visible = false;
                txtemail.Visible = false;
                txtIdconsulta.Visible = false;
                idescolhida.Visible = false;
                btnfinalizarconsulta.Visible = false;
                btnimprimirReceita.Visible = false;
                labelimprimirReceita.Visible = false;
                btnImprmirLaudo.Visible = false;
                labelimprimirLaudo.Visible = false;

                
                btnAddReceituário.Enabled = true;
                btnaddLaudo.Enabled = true;
                btnbuscarConsulta.Visible = true;
                DtvConsultas.Visible = true;
                CarregarGrid();
                medicolabel.Visible = true;
                txtMedico.Visible = true;
                btnRealizarConsulta.Visible = true;
                labelfiltrar.Visible = true;
                cbmFiltrar.Visible = true;
                cmbFiltrarHora.Visible = true;
                txtPesquisar.Visible = true;
                txtPesquisarHora.Visible = true;












            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        private void ButtonSalvarReceituario_Click(object sender, EventArgs e)
        {
            try
            {
                ReceituarioCtrl controle = new ReceituarioCtrl();

                Receituario receituario = CarregarReceituarioDoForm();

                controle.InserirReceituario(receituario);

                limpaFormularioReceita();

                MessageBox.Show("Receituário cadastrado com sucesso!!");


                btnAddReceituário.Visible = true;

                GpbReceituario.Visible = false;
                btnAddReceituário.Enabled = false;
                btnCancelarReceita.Visible = false;
                ButtonSalvarReceituario.Visible = false;
                btnimprimirReceita.Visible = false;
                labelimprimirReceita.Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private void btnRealizarConsulta_Click(object sender, EventArgs e)
        {
            labelfiltrar.Visible = false;
            cbmFiltrar.Visible = false;
            cmbFiltrarHora.Visible = false;
            txtPesquisar.Visible = false;
            txtPesquisarHora.Visible = false;
            DtvConsultas.Visible = false;
            btnRealizarConsulta.Visible = false;
            medicolabel.Visible = false;
            txtMedico.Visible = false;
            btnCancelarLaudo.Visible = false;
            btnbuscarConsulta.Visible = false;
            GpbReceituario.Visible = false;
            ButtonSalvarReceituario.Visible = false;
            btnCancelarReceita.Visible = false;
            txttelefone.Visible = false;
            labeltelefone.Visible = false;
            limpaFormularioLaudo();

            btnAddReceituário.Enabled = true;
            btnaddLaudo.Enabled = true;
            btnVoltar2.Visible = true;
            btnfinalizarconsulta.Visible = true;
            btnAddReceituário.Visible = true;
            txtIdconsulta.Visible = true;
            idescolhida.Visible = true;
            btnaddLaudo.Visible = true;
            labelcelular.Visible = true;
            labelcpf.Visible = true;
            labelemail.Visible = true;
            labelnome.Visible = true;
            labelcelular.Visible = true;
            labeltelefone.Visible = true;
            txttelefone.Visible = true;
            txtnome.Visible = true;
            txtcelular.Visible = true;
            txtcpf.Visible = true;
            txtemail.Visible = true;

            idconsulta = int.Parse(DtvConsultas.SelectedRows[0].Cells[0].Value.ToString());

            idescolhida.Text = idconsulta.ToString();

            string sql = "SELECT Consulta.Id, Consulta.IdPaciente, Consulta.IdMedico, Consulta.Motivo, Consulta.HorarioAtendimento, Consulta.Data, Consulta.Status, Paciente.Nome, Paciente.Cpf, Paciente.Telefone, Paciente.Celular, Paciente.Email FROM Consulta INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id WHERE (Status=0) AND Consulta.Id LIKE '%" + idescolhida.Text + "%'";
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
                consulta.Cpf = data.GetString(8);
                consulta.Telefone = data.GetString(9);
                consulta.Celular = data.GetString(10);
                consulta.Email = data.GetString(11);
            }

            data.Close();
            BancodeDados.FecharConexao();


            txtnome.Text = consulta.Nomepaciente;
            txtcpf.Text = consulta.Cpf;
            txtcelular.Text = consulta.Celular;
            txttelefone.Text = consulta.Telefone;
            txtemail.Text = consulta.Email;
        }

        private void listaexames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GpbLaudo_Enter(object sender, EventArgs e)
        {

        }

        private void DtvConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DashConsultaCadastro_Load(object sender, EventArgs e)
        {
            this.user = (Especialista)this.Tag;
            txtMedico.Text = this.user.Nomecompleto;
            idmedico = this.user.Id;
            CarregarGrid();
        }

        private void cmbexame2_MouseClick(object sender, MouseEventArgs e)
        {
            //variável recebe o objeto medico retornado pelo método 
            Exame exame = ObterExame(cmbexame2.SelectedItem.ToString());

            //passo os valores para os textbox
            bmtidexame.Text = exame.Id.ToString();
        }

        private Exame ObterExame(string nome)
        {

            //objeto medico que será retornado pelo método 
            Exame exame = new Exame();

            //instância da conexão 
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123");

            //string com o comando a ser executado 
            string sql = "SELECT * from Exame WHERE Nome = @Nome";

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
                exame.Id = Convert.ToInt32(leitor["Id"].ToString());
            }

            //fecha conexão 
            conn.Close();

            //Retorno o objeto paciente cujo o  
            //nome é igual ao informado no parâmetro 
            return exame;
        }

        private void cmbexame2_Click(object sender, EventArgs e)
        {
            //variável recebe o objeto medico retornado pelo método 
            Exame exame = ObterExame(cmbexame2.SelectedItem.ToString());

            //passo os valores para os textbox
            bmtidexame.Text = exame.Id.ToString();
        }

        private void cmbexame2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //variável recebe o objeto medico retornado pelo método 
            Exame exame = ObterExame(cmbexame2.SelectedItem.ToString());

            //passo os valores para os textbox
            bmtidexame.Text = exame.Id.ToString();
        }

        private void adicionamedicamentoslista_Click(object sender, EventArgs e)
        {
            ListMed2.Items.Add(ListMed1.SelectedItem);

            FormularioMedicamento form = new FormularioMedicamento();
            form.Show();
        }

        private void removemedicamentolista_Click(object sender, EventArgs e)
        {
           
            ListMed2.Items.Remove(ListMed2.SelectedItem);
        }

        private void btnAddExamelista_Click(object sender, EventArgs e)
        {
            ListEx2.Items.Add(ListEx1.SelectedItem);
        }

        private void btnRemoveExameLista_Click(object sender, EventArgs e)
        {
            ListEx2.Items.Remove(ListEx2.SelectedItem);

        }


        private void btnimprimirReceita_Click(object sender, EventArgs e)
        {
            if (printDialogReceita.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocumentReceita.PrinterSettings = printDialogReceita.PrinterSettings;
                printDocumentReceita.Print();
            }
        }

        private void printDocumentReceita_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(bmtidconsulta.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawString(mtbdata.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 150));
            e.Graphics.DrawString(bmtObs.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 200));
            e.Graphics.DrawString(ListMed2.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 250));
            e.Graphics.DrawString(ListEx2.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 300));
        }

        private void printDocumentLaudo_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(bmtidconsulta2.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawString(mtbdata2.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 150));
            e.Graphics.DrawString(BmtObs2.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 200));
            e.Graphics.DrawString(bmtidexame.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 250));

        }

        private void btnImprmirLaudo_Click(object sender, EventArgs e)
        {
            if (printDialogLaudo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocumentLaudo.PrinterSettings = printDialogLaudo.PrinterSettings;
                printDocumentLaudo.Print();
            }

        }
    }
}
