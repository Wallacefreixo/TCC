using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Controle;
using Dados;
using System.Data.SqlServerCe;

namespace Visao
{
    public partial class DashPaciente : UserControl
    {

        //Atributos
        private Paciente paciente;

        public DashPaciente()
        {
            InitializeComponent();
        }

        private void DashDashPaciente_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        #region Metodos Privados



        private void CarregarGrid()
        {
            try
            {
                DtvPacientes.Rows.Clear();

                PacienteCtrl controle = new PacienteCtrl();

                List<Paciente> listaPacientes = controle.BuscarTodosPacientes();

                foreach (Paciente p in listaPacientes)
                {
                    DtvPacientes.Rows.Add(p.Id, p.NomeCompleto, p.Cpf,p.Rg, p.Telefone, p.Celular, p.Email);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO: " + ex.Message);
            }
        }


    
        #endregion

       


        


        private void Btncadastrarpaciente_Click(object sender, EventArgs e)
        {
            panelcadastropaciente.Controls.Clear();
            DashPacienteCadastro novo = new DashPacienteCadastro();
            panelcadastropaciente.Controls.Add(novo);
            novo.Show();
        }


        private void btnatt_Click(object sender, EventArgs e)
        {
            panelcadastropaciente.Controls.Clear();
            DashPacienteCadastro novo = new DashPacienteCadastro();
            panelcadastropaciente.Controls.Add(novo);
            novo.Show();

            int id = int.Parse(DtvPacientes.SelectedRows[0].Cells[0].Value.ToString());

            PacienteCtrl controle = new PacienteCtrl();

            this.paciente = controle.BuscarPacienteID(id);

       

        }

        private void BtnDeletar_Click_1(object sender, EventArgs e)
        {
           
            int id = (int)DtvPacientes.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Deseja deletar o paciente de id = " + id + "?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                   PacienteCtrl controle = new PacienteCtrl();

                   controle.DeletarPaciente(id);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message);
                }
                CarregarGrid();
            }

        }

        private void btnatt_Click_1(object sender, EventArgs e)
        {
            labelAtt.Visible = false;
            labeldeletar.Visible = false;
            labelvisualizar.Visible = false;
            BtnDeletar.Visible = false;
            btnDados.Visible = false;
            DtvPacientes.Visible = false;
            Btncadastrarpaciente.Visible = false;
            btnBuscar.Visible = false;
            label.Visible = false;
            txtPesquisar.Visible = false;
            cbmFiltrar.Visible = false;
            textpaciente.Visible = false;
            BtnAtualizar.Visible = false;

            labelatualizarpaciente.Visible = true;
            GpbConvenio.Visible = true;
            GpbEndereco.Visible = true;
            GpbDadosPessoais.Visible = true;
            gpbLogin.Visible = true;
            gpbObs.Visible = true;
            BtnCancelar.Visible = true;
            BtnSalvarAlteracoes.Visible = true;

            int id = int.Parse(DtvPacientes.SelectedRows[0].Cells[0].Value.ToString());

            PacienteCtrl controle = new PacienteCtrl();

            this.paciente = controle.BuscarPacienteID(id);
            // Metodo para carregar paciente do form
            CarregarFormDePaciente(this.paciente);


        }
        private void CarregarFormDePaciente(Paciente _paciente)
        {
            try
            {
                BmtUsuario.Text = _paciente.Usuario;
                BmtSenha.Text = _paciente.Senha;
                BmtNome.Text = _paciente.NomeCompleto;
                MtbTelefone.Text = _paciente.Telefone;
                MtbCelular.Text = _paciente.Celular;
                MtbCPF.Text = _paciente.Cpf;
                MtbRG.Text = _paciente.Rg;
                CmbIdade.SelectedIndex = int.Parse(_paciente.Idade);
                CmbTipoSanguineo.SelectedIndex = int.Parse(_paciente.Tiposanguineo);
                CmbTipoConvenio.SelectedIndex = int.Parse(_paciente.Tipoconvenio);
                BmtNumeroPlano.Text = _paciente.Nplanodesaude;
                MtbValidadePlano.Text = _paciente.Datavalidadeplano;
                bmtEndereco.Text = _paciente.Endereco;
                BmtCidade.Text = _paciente.Cidade;
                CmbEstado.SelectedIndex = int.Parse(_paciente.Estado);
                CkbPacienteEspecial.Checked = _paciente.Pacienteespecial;
                CmbSexo.SelectedIndex = int.Parse(_paciente.Sexo);
                CmbEstadoCivil.SelectedIndex = int.Parse(_paciente.Estadocivil);
                BmtNomePai.Text = _paciente.Nomepai;
                BmtNomeMae.Text = _paciente.Nomemae;
                BmtObs.Text = _paciente.Obs;
                BmtEmail.Text = _paciente.Email;
                
                /*
                //SEXO
                if (_paciente.Sexo.Equals("masculino"))
                {
                    RdbMasculino.Checked = true;
                }
                else
                {
                    RdbFeminino.Checked = true;
                }
                //Estado Civil
                if (_paciente.Estadocivil.Equals("casado"))
                {
                    RdbCasado.Checked = true;
                }
                else
                {
                    RdbSolteiro.Checked = true;
                }*/


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }


        }


        private void BtnSalvarAlteracoes_Click_1(object sender, EventArgs e)
        {
            try
            {
                PacienteCtrl controle = new PacienteCtrl();

                paciente.Usuario = BmtUsuario.Text;
                paciente.Senha =   BmtSenha.Text;
                paciente.NomeCompleto = BmtNome.Text;
                paciente.Telefone = MtbTelefone.Text;
                paciente.Celular = MtbCelular.Text;
                paciente.Cpf = MtbCPF.Text;
                paciente.Rg = MtbRG.Text;
                paciente.Idade = CmbIdade.SelectedIndex.ToString();
                paciente.Tiposanguineo = CmbTipoSanguineo.SelectedIndex.ToString();
                paciente.Tipoconvenio = CmbTipoConvenio.SelectedIndex.ToString();
                paciente.Nplanodesaude = BmtNumeroPlano.Text;
                paciente.Datavalidadeplano = MtbValidadePlano.Text;
                paciente.Endereco = bmtEndereco.Text;
                paciente.Cidade = BmtCidade.Text;
                paciente.Estado = CmbEstado.SelectedIndex.ToString();
                paciente.Pacienteespecial = CkbPacienteEspecial.Checked;
                paciente.Sexo = CmbSexo.SelectedIndex.ToString();
                paciente.Estadocivil = CmbEstadoCivil.SelectedIndex.ToString();
                paciente.Nomepai = BmtNomePai.Text;
                paciente.Nomemae = BmtNomeMae.Text;
                paciente.Obs = BmtObs.Text;
                paciente.Email = BmtEmail.Text;

                /*
                //SEXO
                if (RdbMasculino.Checked)
                {
                    paciente.Sexo = "masculino";
                }
                if (RdbFeminino.Checked)
                {
                    paciente.Sexo = "feminino";
                }
                //Estado Civil
                if (RdbCasado.Checked)
                {
                    paciente.Estadocivil = "casado";
                }
                if (RdbSolteiro.Checked)
                {
                    paciente.Estadocivil = "solteiro";
                }*/

                controle.AtualizarPaciente(paciente);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
            MessageBox.Show("Paciente atualizado com sucesso!");
            limpaFormulario();
            CarregarGrid();

            BtnDeletar.Visible = true;
            btnDados.Visible = true;
            DtvPacientes.Visible = true;
            Btncadastrarpaciente.Visible = true;
            btnBuscar.Visible = true;
            label.Visible = true;
            cbmFiltrar.Visible = true;
            txtPesquisar.Visible = true;
            textpaciente.Visible = true;
            BtnAtualizar.Visible = true;
            labelAtt.Visible = true;
            labeldeletar.Visible = true;
            labelvisualizar.Visible = true;

            labelatualizarpaciente.Visible = false;
            GpbConvenio.Visible = false;
            GpbEndereco.Visible = false;
            GpbDadosPessoais.Visible = false;
            gpbLogin.Visible = false;
            gpbObs.Visible = false;
            BtnCancelar.Visible = false;
            BtnSalvarAlteracoes.Visible = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
        private void limpaFormulario()
        {
            BmtUsuario.Text = "";
            BmtSenha.Text = "";
            BmtNome.Text = "";
            MtbTelefone.Text = "";
            MtbCelular.Text = "";
            MtbCPF.Text = "";
            MtbRG.Text = "";
            CmbIdade.SelectedItem = null;
            CmbTipoSanguineo.SelectedItem = null;
            CmbTipoConvenio.SelectedItem = null;
            BmtNumeroPlano.Text = "";
            MtbValidadePlano.Text = "";
            bmtEndereco.Text = "";
            BmtCidade.Text = "";
            CmbEstado.SelectedItem = null;
            CkbPacienteEspecial.Checked = false;
            CmbSexo.SelectedItem = null;
            CmbEstadoCivil.SelectedItem = null;
            BmtNomePai.Text = "";
            BmtNomeMae.Text = "";
            BmtObs.Text = "";
            BmtEmail.Text ="";

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpaFormulario();

            labelAtt.Visible = true;
            labeldeletar.Visible = true;
            labelvisualizar.Visible = true;
            BtnDeletar.Visible = true;
            btnDados.Visible = true;
            DtvPacientes.Visible = true;
            Btncadastrarpaciente.Visible = true;
            btnBuscar.Visible = true;
            label.Visible = true;
            txtPesquisar.Visible = true;
            cbmFiltrar.Visible = true;
            textpaciente.Visible = true;
            BtnAtualizar.Visible = true;

            labelatualizarpaciente.Visible = false;
            GpbConvenio.Visible = false;
            GpbEndereco.Visible = false;
            GpbDadosPessoais.Visible = false;
            gpbLogin.Visible = false;
            gpbObs.Visible = false;
            BtnCancelar.Visible = false;
            BtnSalvarAlteracoes.Visible = false;
            textatualizarpaciente.Visible = false;

        }

        private void GpbComplementares_Enter(object sender, EventArgs e)
        {

        }

        private void btnDados_Click(object sender, EventArgs e)
        {

        }

        private void DtvPacientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbmFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmFiltrar.Text == "Nome")
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
            }
            if (cbmFiltrar.Text == "RG")
            {
                txtPesquisar.Mask = "00.000.000-0";
                txtPesquisar.Text = "";
            }

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {


                DtvPacientes.Rows.Clear();

                if (cbmFiltrar.Text == "Nome")
                {
                    Paciente paciente = null;

                    try
                    {
                        string sql = "SELECT * FROM Paciente WHERE Nome LIKE '%" + txtPesquisar.Text + "%'";
                        SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                        while (data.Read())
                        {
                            paciente = new Paciente();

                            paciente.Id = data.GetInt32(0);
                            paciente.Usuario = data.GetString(1);
                            paciente.Senha = data.GetString(2);
                            paciente.NomeCompleto = data.GetString(3);
                            paciente.Telefone = data.GetString(4);
                            paciente.Celular = data.GetString(5);
                            paciente.Cpf = data.GetString(6);
                            paciente.Rg = data.GetString(7);
                            paciente.Idade = data.GetString(8);
                            paciente.Tiposanguineo = data.GetString(9);
                            paciente.Tipoconvenio = data.GetString(10);
                            paciente.Nplanodesaude = data.GetString(11);
                            paciente.Datavalidadeplano = data.GetString(12);
                            paciente.Endereco = data.GetString(13);
                            paciente.Cidade = data.GetString(14);
                            paciente.Estado = data.GetString(15);
                            paciente.Pacienteespecial = data.GetBoolean(16);
                            paciente.Sexo = data.GetString(17);
                            paciente.Estadocivil = data.GetString(18);
                            paciente.Nomepai = data.GetString(19);
                            paciente.Nomemae = data.GetString(20);
                            paciente.Obs = data.GetString(21);
                            paciente.Email = data.GetString(22);

                            DtvPacientes.Rows.Add(paciente.Id, paciente.NomeCompleto, paciente.Cpf, paciente.Rg, paciente.Telefone, paciente.Celular, paciente.Email);
                        }

                        data.Close();
                        BancodeDados.FecharConexao();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                }

                if (cbmFiltrar.Text == "CPF")
                {
                    Paciente paciente = null;

                    try
                    {
                        String dado = txtPesquisar.Text;
                        string sql = "SELECT * FROM Paciente WHERE Cpf LIKE '%" + txtPesquisar.Text + "%'";
                        SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                        while (data.Read())
                        {
                            paciente = new Paciente();

                            paciente.Id = data.GetInt32(0);
                            paciente.Usuario = data.GetString(1);
                            paciente.Senha = data.GetString(2);
                            paciente.NomeCompleto = data.GetString(3);
                            paciente.Telefone = data.GetString(4);
                            paciente.Celular = data.GetString(5);
                            paciente.Cpf = data.GetString(6);
                            paciente.Rg = data.GetString(7);
                            paciente.Idade = data.GetString(8);
                            paciente.Tiposanguineo = data.GetString(9);
                            paciente.Tipoconvenio = data.GetString(10);
                            paciente.Nplanodesaude = data.GetString(11);
                            paciente.Datavalidadeplano = data.GetString(12);
                            paciente.Endereco = data.GetString(13);
                            paciente.Cidade = data.GetString(14);
                            paciente.Estado = data.GetString(15);
                            paciente.Pacienteespecial = data.GetBoolean(16);
                            paciente.Sexo = data.GetString(17);
                            paciente.Estadocivil = data.GetString(18);
                            paciente.Nomepai = data.GetString(19);
                            paciente.Nomemae = data.GetString(20);
                            paciente.Obs = data.GetString(21);
                            paciente.Email = data.GetString(22);

                            DtvPacientes.Rows.Add(paciente.Id, paciente.NomeCompleto, paciente.Cpf, paciente.Rg, paciente.Telefone, paciente.Celular, paciente.Email);
                        }

                        data.Close();
                        BancodeDados.FecharConexao();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }



                }
                if (cbmFiltrar.Text == "RG")
                {
                    Paciente paciente = null;

                    try
                    {
                        String dado = txtPesquisar.Text;
                        string sql = "SELECT * FROM Paciente WHERE Rg LIKE '%" + txtPesquisar.Text + "%'";
                        SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                        while (data.Read())
                        {
                            paciente = new Paciente();

                            paciente.Id = data.GetInt32(0);
                            paciente.Usuario = data.GetString(1);
                            paciente.Senha = data.GetString(2);
                            paciente.NomeCompleto = data.GetString(3);
                            paciente.Telefone = data.GetString(4);
                            paciente.Celular = data.GetString(5);
                            paciente.Cpf = data.GetString(6);
                            paciente.Rg = data.GetString(7);
                            paciente.Idade = data.GetString(8);
                            paciente.Tiposanguineo = data.GetString(9);
                            paciente.Tipoconvenio = data.GetString(10);
                            paciente.Nplanodesaude = data.GetString(11);
                            paciente.Datavalidadeplano = data.GetString(12);
                            paciente.Endereco = data.GetString(13);
                            paciente.Cidade = data.GetString(14);
                            paciente.Estado = data.GetString(15);
                            paciente.Pacienteespecial = data.GetBoolean(16);
                            paciente.Sexo = data.GetString(17);
                            paciente.Estadocivil = data.GetString(18);
                            paciente.Nomepai = data.GetString(19);
                            paciente.Nomemae = data.GetString(20);
                            paciente.Obs = data.GetString(21);
                            paciente.Email = data.GetString(22);

                            DtvPacientes.Rows.Add(paciente.Id, paciente.NomeCompleto, paciente.Cpf, paciente.Rg, paciente.Telefone, paciente.Celular, paciente.Email);
                        }

                        data.Close();
                        BancodeDados.FecharConexao();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }



             }
                if (cbmFiltrar.Text == "ID")
                {
                    Paciente paciente = null;

                    try
                    {
                        String dado = txtPesquisar.Text;
                        string sql = "SELECT * FROM Paciente WHERE Id LIKE '%" + txtPesquisar.Text + "%'";
                        SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                        while (data.Read())
                        {
                            paciente = new Paciente();

                            paciente.Id = data.GetInt32(0);
                            paciente.Usuario = data.GetString(1);
                            paciente.Senha = data.GetString(2);
                            paciente.NomeCompleto = data.GetString(3);
                            paciente.Telefone = data.GetString(4);
                            paciente.Celular = data.GetString(5);
                            paciente.Cpf = data.GetString(6);
                            paciente.Rg = data.GetString(7);
                            paciente.Idade = data.GetString(8);
                            paciente.Tiposanguineo = data.GetString(9);
                            paciente.Tipoconvenio = data.GetString(10);
                            paciente.Nplanodesaude = data.GetString(11);
                            paciente.Datavalidadeplano = data.GetString(12);
                            paciente.Endereco = data.GetString(13);
                            paciente.Cidade = data.GetString(14);
                            paciente.Estado = data.GetString(15);
                            paciente.Pacienteespecial = data.GetBoolean(16);
                            paciente.Sexo = data.GetString(17);
                            paciente.Estadocivil = data.GetString(18);
                            paciente.Nomepai = data.GetString(19);
                            paciente.Nomemae = data.GetString(20);
                            paciente.Obs = data.GetString(21);
                            paciente.Email = data.GetString(22);

                            DtvPacientes.Rows.Add(paciente.Id, paciente.NomeCompleto, paciente.Cpf, paciente.Rg, paciente.Telefone, paciente.Celular, paciente.Email);
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

        private void txtPesquisar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnDados_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(DtvPacientes.SelectedRows[0].Cells[0].Value.ToString());

            PacienteCtrl controle = new PacienteCtrl();

            this.paciente = controle.BuscarPacienteID(id);
            // Metodo para carregar paciente do form
            CarregarFormDePaciente(this.paciente);

            //campos visible
            btnVoltar.Visible = true;
            labeldados.Visible = true;
            btnimprimir.Visible = true;
            labelimprimir.Visible = true;
            gpbLogin.Visible = true;
            GpbDadosPessoais.Visible = true;
            GpbEndereco.Visible = true;
            GpbConvenio.Visible = true;
            gpbObs.Visible = true;

            labelAtt.Visible = false;
            labeldeletar.Visible = false;
            labelvisualizar.Visible = false;
            BtnDeletar.Visible = false;
            btnDados.Visible = false;
            DtvPacientes.Visible = false;
            Btncadastrarpaciente.Visible = false;
            btnBuscar.Visible = false;
            label.Visible = false;
            txtPesquisar.Visible = false;
            cbmFiltrar.Visible = false;
            textpaciente.Visible = false;
            BtnAtualizar.Visible = false;
            gpbLogin.Enabled = false;
            GpbDadosPessoais.Enabled = false;
            GpbEndereco.Enabled = false;
            GpbConvenio.Enabled = false;
            gpbObs.Enabled = false;


        }


        private void labelimprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            //campos visible
            btnVoltar.Visible = false;
            labeldados.Visible = false;
            btnimprimir.Visible = false;
            labelimprimir.Visible = false;
            gpbLogin.Visible = false;
            GpbDadosPessoais.Visible = false;
            GpbEndereco.Visible = false;
            GpbConvenio.Visible = false;
            gpbObs.Visible = false;

            labelAtt.Visible = true;
            labeldeletar.Visible = true;
            labelvisualizar.Visible = true;
            BtnDeletar.Visible = true;
            btnDados.Visible = true;
            DtvPacientes.Visible = true;
            Btncadastrarpaciente.Visible = true;
            btnBuscar.Visible = true;
            label.Visible = true;
            txtPesquisar.Visible = true;
            cbmFiltrar.Visible = true;
            textpaciente.Visible = true;
            BtnAtualizar.Visible = true;
            gpbLogin.Enabled = true;
            GpbDadosPessoais.Enabled = true;
            GpbEndereco.Enabled = true;
            GpbConvenio.Enabled = true;
            gpbObs.Enabled = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(BmtUsuario.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawString(BmtSenha.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 150));
            e.Graphics.DrawString(BmtNome.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 200));
            e.Graphics.DrawString(MtbCPF.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 250));
            e.Graphics.DrawString(MtbRG.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 300));
            e.Graphics.DrawString(MtbTelefone.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 350));
            e.Graphics.DrawString(MtbCelular.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 400));
            e.Graphics.DrawString(BmtEmail.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 450));
            e.Graphics.DrawString(CmbIdade.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 500));
            e.Graphics.DrawString(BmtNomeMae.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 550));
            e.Graphics.DrawString(BmtNomePai.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 600));
            e.Graphics.DrawString(CmbEstadoCivil.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 650));
            e.Graphics.DrawString(CmbSexo.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 700));
            e.Graphics.DrawString(CmbTipoSanguineo.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 750));
            e.Graphics.DrawString(bmtEndereco.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 800));
            e.Graphics.DrawString(CmbEstado.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 850));
            e.Graphics.DrawString(BmtCidade.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 900));
            e.Graphics.DrawString(CmbTipoConvenio.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 950));
            e.Graphics.DrawString(MtbValidadePlano.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 1000));
            e.Graphics.DrawString(BmtNumeroPlano.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 1050));
            e.Graphics.DrawString(BmtObs.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 1100));
         
          
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }







    }
}
