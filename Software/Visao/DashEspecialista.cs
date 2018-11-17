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
using System.Data.SqlServerCe;
using Dados;

namespace Visao
{
    public partial class DashEspecialista : UserControl
    {
        //Atributos
        private Especialista especialista;

        public DashEspecialista()
        {
            InitializeComponent();
        }

        private void DashMedicos_Load(object sender, EventArgs e)
        {

            CarregarGrid();
        }

        
        private void CarregarGrid()
        {
            try
            {
                DtvEspecialista.Rows.Clear();

                EspecialistaCtrl controle = new EspecialistaCtrl();

                List<Especialista> listaEspecialista = controle.BuscarTodosEspecialistas();

                foreach (Especialista e in listaEspecialista)
                {
                    DtvEspecialista.Rows.Add(e.Id, e.Status, e.Nomecompleto, e.Cpf ,e.Rg, e.Telefone, e.Celular, e.Email);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        // Carrega o form de medico da grade view e preenche os campos
        private void CarregarFormDeEspecialista(Especialista _especialista)
        {
            try
            {
                BmtUsuario.Text = _especialista.Usuario;
                BmtSenha.Text = _especialista.Senha;
                MtbCPF.Text = _especialista.Cpf;
                MtbRG.Text = _especialista.Rg;
                MtbTelefone.Text = _especialista.Telefone;
                MtbCelular.Text = _especialista.Celular;
                MtbEmail.Text = _especialista.Email;
                CmbSexo.SelectedIndex = int.Parse(_especialista.Sexo);
                CmbStatus.SelectedIndex = int.Parse(_especialista.Status);
                BmtObs.Text = _especialista.Obs;
                CmbIdade.SelectedIndex = int.Parse(_especialista.Idade);
                CmbAreaAtuacao.SelectedIndex = int.Parse(_especialista.Areaatuacao); ;
                CmbEspecialidade1.SelectedIndex = int.Parse(_especialista.Especialidade1);
                CmbEspecialidade2.SelectedIndex = int.Parse(_especialista.Especialidade2);
                MtbHoraini.Text = _especialista.Horaatendimentoini;
                MtbHorafim.Text = _especialista.Horaatendimentofim ;
                CmbTipoDocumento.SelectedIndex = int.Parse(_especialista.Tipodocumentomedico);
                MtbNumeroDocumento.Text = _especialista.Numerodocumento;
                CmbUF.SelectedIndex = int.Parse(_especialista.Uf);
                CmbSituacao.SelectedIndex = int.Parse(_especialista.Situacao);
                CmbTipoInscricao.SelectedIndex = int.Parse(_especialista.Tipoinscricao);
                CkbSegunda.Checked = _especialista.Atendimentosegunda;
                CkbTerca.Checked = _especialista.Atendimentoterca;
                CkbQuarta.Checked = _especialista.Atendimentoquarta;
                CkbQuinta.Checked = _especialista.Atendimentoquinta;
                CkbSexta.Checked = _especialista.Atendimentosexta;
                CkbSabado.Checked = _especialista.Atendimentosabado;
                CkbDomingo.Checked = _especialista.Atendimentodomingo;
                CmbTipoPermissao.SelectedIndex = int.Parse(_especialista.Tipopermissao);
                BmtNome.Text = _especialista.Nomecompleto;
                cmbProfi.SelectedIndex = int.Parse(_especialista.Profissao);



                /*
                //SEXO
                if (_medico.Sexo.Equals("masculino"))
                {
                    RdbMasculino.Checked = true;
                }
                else
                {
                    RdbFeminino.Checked = true;
                }
                 */


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }


        }

        //função Limpa formulario apos cadastrar
        private void limpaFormulario()
        {

            BmtUsuario.Text = "";
            BmtSenha.Text = "";
            MtbCPF.Text = "";
            MtbRG.Text = "";
            MtbTelefone.Text = "";
            MtbCelular.Text = "";
            MtbEmail.Text = "";
            CmbSexo.SelectedItem = null;
            CmbStatus.SelectedItem = null;
            BmtObs.Text = "";
            CmbIdade.SelectedItem = null;
            CmbAreaAtuacao.SelectedItem = null;
            CmbEspecialidade1.SelectedItem = null;
            CmbEspecialidade2.SelectedItem = null;
            MtbHoraini.Text = "";
            MtbHorafim.Text = "";
            CmbTipoDocumento.SelectedItem = null;
            MtbNumeroDocumento.Text = "";
            CmbUF.SelectedItem = null;
            CmbSituacao.SelectedItem = null;
            CmbTipoInscricao.SelectedItem = null;
            CkbSegunda.Checked = false;
            CkbTerca.Checked = false;
            CkbQuarta.Checked = false;
            CkbQuinta.Checked = false;
            CkbSexta.Checked = false;
            CkbSabado.Checked = false;
            CkbDomingo.Checked = false;
            CmbTipoPermissao.SelectedItem = null;
            BmtNome.Text = "";
            cmbProfi.SelectedItem = null;

        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            int id = (int)DtvEspecialista.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Deseja deletar o especialista de id = " + id + "?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    EspecialistaCtrl controle = new EspecialistaCtrl();
                    controle.DeletarEspecialista(id);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message);
                }
                CarregarGrid();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            BtnDeletar.Visible = false;
            btnDados.Visible = false;
            DtvEspecialista.Visible = false;
            Btncadastrarmedico.Visible = false;
            btnBuscar.Visible = false;
            label.Visible = false;
            txtPesquisar.Visible = false;
            cbmFiltrar.Visible = false;
            textomedico.Visible = false;
            BtnAtualizar.Visible = false;
            labelAtt.Visible = false;
            labeldeletar.Visible = false;
            label.Visible = false;
            labelvisualizar.Visible = false;

            GpbDadosPessoais.Visible = true;
         
            GpbComplementares.Visible = true;
            gpbLogin.Visible = true;
            gpbProfissional.Visible = true;
            gpbObs.Visible = true;
            BtnCancelar.Visible = true;
            BtnSalvarAlteracoes.Visible = true;
            textatualizarmedico.Visible = true;


            GpbDadosPessoais.Enabled = true;
            GpbComplementares.Enabled = true;
            gpbLogin.Enabled = true;
            gpbProfissional.Enabled = true;
            gpbObs.Enabled = true;

            int id = int.Parse(DtvEspecialista.SelectedRows[0].Cells[0].Value.ToString());

            EspecialistaCtrl controle = new EspecialistaCtrl();

            this.especialista = controle.BuscarEspecialistaID(id);

            // Metodo para carregar paciente do form
            CarregarFormDeEspecialista(this.especialista);
        }


        private void BtnSalvarAlteracoes_Click(object sender, EventArgs e)
        {

            try
            {
                EspecialistaCtrl controle = new EspecialistaCtrl();

                especialista.Usuario = BmtUsuario.Text;
                especialista.Senha = BmtSenha.Text;
                especialista.Cpf = MtbCPF.Text;
                especialista.Rg = MtbRG.Text;
                especialista.Telefone = MtbTelefone.Text;
                especialista.Celular = MtbCelular.Text;
                especialista.Email = MtbEmail.Text;
                especialista.Sexo = CmbSexo.SelectedIndex.ToString();
                especialista.Status = CmbStatus.SelectedIndex.ToString();
                especialista.Obs = BmtObs.Text;
                especialista.Idade = CmbIdade.SelectedIndex.ToString();
                especialista.Areaatuacao = CmbAreaAtuacao.SelectedIndex.ToString();
                especialista.Especialidade1 = CmbEspecialidade1.SelectedIndex.ToString();
                especialista.Especialidade2 = CmbEspecialidade2.SelectedIndex.ToString();
                especialista.Horaatendimentoini = MtbHoraini.Text;
                especialista.Horaatendimentofim = MtbHorafim.Text;
                especialista.Tipodocumentomedico = CmbTipoDocumento.SelectedIndex.ToString();
                especialista.Numerodocumento = MtbNumeroDocumento.Text;
                especialista.Uf = CmbUF.SelectedIndex.ToString();
                especialista.Situacao = CmbSituacao.SelectedIndex.ToString();
                especialista.Tipoinscricao = CmbTipoInscricao.SelectedIndex.ToString();
                especialista.Atendimentosegunda = CkbSegunda.Checked;
                especialista.Atendimentoterca = CkbTerca.Checked;
                especialista.Atendimentoquarta = CkbQuarta.Checked;
                especialista.Atendimentoquinta = CkbQuinta.Checked;
                especialista.Atendimentosexta = CkbSexta.Checked;
                especialista.Atendimentosabado = CkbSabado.Checked;
                especialista.Atendimentodomingo = CkbDomingo.Checked;
                especialista.Tipopermissao = CmbTipoPermissao.SelectedIndex.ToString();
                especialista.Nomecompleto = BmtNome.Text;
                especialista.Profissao = cmbProfi.SelectedIndex.ToString();

                controle.AtualizarEspecialista(especialista);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }


            MessageBox.Show("Especialista atualizado com sucesso!");
            limpaFormulario();
            CarregarGrid();

            BtnDeletar.Visible = true;
            btnDados.Visible = true;
            DtvEspecialista.Visible = true;
            Btncadastrarmedico.Visible = true;
            btnBuscar.Visible = true;
            label.Visible = true;
            txtPesquisar.Visible = true;
            cbmFiltrar.Visible = true;
            textomedico.Visible = true;
            BtnAtualizar.Visible = true;
            labelAtt.Visible = true;
            labeldeletar.Visible = true;
            labelvisualizar.Visible = true;

            GpbDadosPessoais.Visible = false;
           
            GpbComplementares.Visible = false;
            gpbLogin.Visible = false;
            gpbProfissional.Visible = false;
            gpbObs.Visible = false;
            BtnCancelar.Visible = false;
            BtnSalvarAlteracoes.Visible = false;
            textatualizarmedico.Visible = false;

            

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnDeletar.Visible = true;
            btnDados.Visible = true;
            DtvEspecialista.Visible = true;
            Btncadastrarmedico.Visible = true;
            btnBuscar.Visible = true;
            label.Visible = true;
            txtPesquisar.Visible = true;
            cbmFiltrar.Visible = true;
            textomedico.Visible = true;
            BtnAtualizar.Visible = true;
            labelAtt.Visible = true;
            labeldeletar.Visible = true;
            labelvisualizar.Visible = true;

            GpbDadosPessoais.Visible = false;
            GpbComplementares.Visible = false;
            gpbLogin.Visible = false;
            gpbProfissional.Visible = false;
            gpbObs.Visible = false;
            BtnCancelar.Visible = false;
            BtnSalvarAlteracoes.Visible = false;
            textatualizarmedico.Visible = false;

            limpaFormulario();
        }


        private void Btncadastrarespecialista_Click(object sender, EventArgs e)
        {
            panelCadastroMedico.Controls.Clear();
            DashEspecialistaCadastro novo = new DashEspecialistaCadastro();
            panelCadastroMedico.Controls.Add(novo);
            novo.Show();
        }

        private void panelAtualização_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BmtObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProfi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProfi.Text == "Médico")
            {
                
                CmbAreaAtuacao.Enabled = true;
                CmbEspecialidade1.Enabled = true;
                CmbEspecialidade2.Enabled = true;
                CmbTipoDocumento.Enabled = true;
                MtbNumeroDocumento.Enabled = true;
                CmbUF.Enabled = true;
                CmbSituacao.Enabled = true;
                CmbTipoInscricao.Enabled = true;

            }

            else
            {
                CmbAreaAtuacao.SelectedItem = null;
                CmbEspecialidade1.SelectedItem = null;
                CmbEspecialidade2.SelectedItem = null;
                CmbTipoDocumento.SelectedItem = null;
                MtbNumeroDocumento.Text = "";
                CmbUF.SelectedItem = null;
                CmbSituacao.SelectedItem = null;
                CmbTipoInscricao.SelectedItem = null;
                CmbTipoDocumento.SelectedItem = null;

                CmbAreaAtuacao.Enabled = false;
                CmbEspecialidade1.Enabled = false;
                CmbEspecialidade2.Enabled = false;
                CmbTipoDocumento.Enabled = false;
                MtbNumeroDocumento.Enabled = false;
                CmbUF.Enabled = false;
                CmbSituacao.Enabled = false;
                CmbTipoInscricao.Enabled = false;
            }
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
            if (cbmFiltrar.Text == "ID")
            {
                txtPesquisar.Mask = "";
                txtPesquisar.Text = "";
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                DtvEspecialista.Rows.Clear();

                if (cbmFiltrar.Text == "Nome")
                {
                    Especialista especialista = null;

                    try
                    {
                        string sql = "SELECT * FROM Especialista WHERE Nome LIKE '%" + txtPesquisar.Text + "%'";
                        SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                        while (data.Read())
                        {
                            especialista = new Especialista();

                            especialista.Id = data.GetInt32(0);
                            especialista.Usuario = data.GetString(1);
                            especialista.Senha = data.GetString(2);
                            especialista.Cpf = data.GetString(3);
                            especialista.Rg = data.GetString(4);
                            especialista.Telefone = data.GetString(5);
                            especialista.Celular = data.GetString(6);
                            especialista.Email = data.GetString(7);
                            especialista.Sexo = data.GetString(8);
                            especialista.Status = data.GetString(9);
                            especialista.Obs = data.GetString(10);
                            especialista.Idade = data.GetString(11);
                            especialista.Areaatuacao = data.GetString(12);
                            especialista.Especialidade1 = data.GetString(13);
                            especialista.Especialidade2 = data.GetString(14);
                            especialista.Horaatendimentoini = data.GetString(15);
                            especialista.Horaatendimentofim = data.GetString(16);
                            especialista.Tipodocumentomedico = data.GetString(17);
                            especialista.Numerodocumento = data.GetString(18);
                            especialista.Uf = data.GetString(19);
                            especialista.Situacao = data.GetString(20);
                            especialista.Tipoinscricao = data.GetString(21);
                            especialista.Atendimentosegunda = data.GetBoolean(22);
                            especialista.Atendimentoterca = data.GetBoolean(23);
                            especialista.Atendimentoquarta = data.GetBoolean(24);
                            especialista.Atendimentoquinta = data.GetBoolean(25);
                            especialista.Atendimentosexta = data.GetBoolean(26);
                            especialista.Atendimentosabado = data.GetBoolean(27);
                            especialista.Atendimentodomingo = data.GetBoolean(28);
                            especialista.Tipopermissao = data.GetString(29);
                            especialista.Nomecompleto = data.GetString(30);
                            especialista.Profissao = data.GetString(31);

                            DtvEspecialista.Rows.Add(especialista.Id, especialista.Status, especialista.Nomecompleto, especialista.Cpf, especialista.Rg, especialista.Telefone, especialista.Celular, especialista.Email);
                        

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
                    Especialista especialista = null;

                    try
                    {
                        string sql = "SELECT * FROM Especialista WHERE Cpf LIKE '%" + txtPesquisar.Text + "%'";
                        SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                        while (data.Read())
                        {
                            especialista = new Especialista();

                            especialista.Id = data.GetInt32(0);
                            especialista.Usuario = data.GetString(1);
                            especialista.Senha = data.GetString(2);
                            especialista.Cpf = data.GetString(3);
                            especialista.Rg = data.GetString(4);
                            especialista.Telefone = data.GetString(5);
                            especialista.Celular = data.GetString(6);
                            especialista.Email = data.GetString(7);
                            especialista.Sexo = data.GetString(8);
                            especialista.Status = data.GetString(9);
                            especialista.Obs = data.GetString(10);
                            especialista.Idade = data.GetString(11);
                            especialista.Areaatuacao = data.GetString(12);
                            especialista.Especialidade1 = data.GetString(13);
                            especialista.Especialidade2 = data.GetString(14);
                            especialista.Horaatendimentoini = data.GetString(15);
                            especialista.Horaatendimentofim = data.GetString(16);
                            especialista.Tipodocumentomedico = data.GetString(17);
                            especialista.Numerodocumento = data.GetString(18);
                            especialista.Uf = data.GetString(19);
                            especialista.Situacao = data.GetString(20);
                            especialista.Tipoinscricao = data.GetString(21);
                            especialista.Atendimentosegunda = data.GetBoolean(22);
                            especialista.Atendimentoterca = data.GetBoolean(23);
                            especialista.Atendimentoquarta = data.GetBoolean(24);
                            especialista.Atendimentoquinta = data.GetBoolean(25);
                            especialista.Atendimentosexta = data.GetBoolean(26);
                            especialista.Atendimentosabado = data.GetBoolean(27);
                            especialista.Atendimentodomingo = data.GetBoolean(28);
                            especialista.Tipopermissao = data.GetString(29);
                            especialista.Nomecompleto = data.GetString(30);
                            especialista.Profissao = data.GetString(31);

                            DtvEspecialista.Rows.Add(especialista.Id, especialista.Status, especialista.Nomecompleto, especialista.Cpf, especialista.Rg, especialista.Telefone, especialista.Celular, especialista.Email);

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
                    Especialista especialista = null;

                    try
                    {
                        string sql = "SELECT * FROM Especialista WHERE Rg LIKE '%" + txtPesquisar.Text + "%'";
                        SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                        while (data.Read())
                        {
                            especialista = new Especialista();

                            especialista.Id = data.GetInt32(0);
                            especialista.Usuario = data.GetString(1);
                            especialista.Senha = data.GetString(2);
                            especialista.Cpf = data.GetString(3);
                            especialista.Rg = data.GetString(4);
                            especialista.Telefone = data.GetString(5);
                            especialista.Celular = data.GetString(6);
                            especialista.Email = data.GetString(7);
                            especialista.Sexo = data.GetString(8);
                            especialista.Status = data.GetString(9);
                            especialista.Obs = data.GetString(10);
                            especialista.Idade = data.GetString(11);
                            especialista.Areaatuacao = data.GetString(12);
                            especialista.Especialidade1 = data.GetString(13);
                            especialista.Especialidade2 = data.GetString(14);
                            especialista.Horaatendimentoini = data.GetString(15);
                            especialista.Horaatendimentofim = data.GetString(16);
                            especialista.Tipodocumentomedico = data.GetString(17);
                            especialista.Numerodocumento = data.GetString(18);
                            especialista.Uf = data.GetString(19);
                            especialista.Situacao = data.GetString(20);
                            especialista.Tipoinscricao = data.GetString(21);
                            especialista.Atendimentosegunda = data.GetBoolean(22);
                            especialista.Atendimentoterca = data.GetBoolean(23);
                            especialista.Atendimentoquarta = data.GetBoolean(24);
                            especialista.Atendimentoquinta = data.GetBoolean(25);
                            especialista.Atendimentosexta = data.GetBoolean(26);
                            especialista.Atendimentosabado = data.GetBoolean(27);
                            especialista.Atendimentodomingo = data.GetBoolean(28);
                            especialista.Tipopermissao = data.GetString(29);
                            especialista.Nomecompleto = data.GetString(30);
                            especialista.Profissao = data.GetString(31);

                            DtvEspecialista.Rows.Add(especialista.Id, especialista.Status, especialista.Nomecompleto, especialista.Cpf, especialista.Rg, especialista.Telefone, especialista.Celular, especialista.Email);
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
                    Especialista especialista = null;

                    try
                    {
                        string sql = "SELECT * FROM Especialista WHERE Id LIKE '%" + txtPesquisar.Text + "%'";
                        SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                        while (data.Read())
                        {
                            especialista = new Especialista();

                            especialista.Id = data.GetInt32(0);
                            especialista.Usuario = data.GetString(1);
                            especialista.Senha = data.GetString(2);
                            especialista.Cpf = data.GetString(3);
                            especialista.Rg = data.GetString(4);
                            especialista.Telefone = data.GetString(5);
                            especialista.Celular = data.GetString(6);
                            especialista.Email = data.GetString(7);
                            especialista.Sexo = data.GetString(8);
                            especialista.Status = data.GetString(9);
                            especialista.Obs = data.GetString(10);
                            especialista.Idade = data.GetString(11);
                            especialista.Areaatuacao = data.GetString(12);
                            especialista.Especialidade1 = data.GetString(13);
                            especialista.Especialidade2 = data.GetString(14);
                            especialista.Horaatendimentoini = data.GetString(15);
                            especialista.Horaatendimentofim = data.GetString(16);
                            especialista.Tipodocumentomedico = data.GetString(17);
                            especialista.Numerodocumento = data.GetString(18);
                            especialista.Uf = data.GetString(19);
                            especialista.Situacao = data.GetString(20);
                            especialista.Tipoinscricao = data.GetString(21);
                            especialista.Atendimentosegunda = data.GetBoolean(22);
                            especialista.Atendimentoterca = data.GetBoolean(23);
                            especialista.Atendimentoquarta = data.GetBoolean(24);
                            especialista.Atendimentoquinta = data.GetBoolean(25);
                            especialista.Atendimentosexta = data.GetBoolean(26);
                            especialista.Atendimentosabado = data.GetBoolean(27);
                            especialista.Atendimentodomingo = data.GetBoolean(28);
                            especialista.Tipopermissao = data.GetString(29);
                            especialista.Nomecompleto = data.GetString(30);
                            especialista.Profissao = data.GetString(31);

                            DtvEspecialista.Rows.Add(especialista.Id, especialista.Status, especialista.Nomecompleto, especialista.Cpf, especialista.Rg, especialista.Telefone, especialista.Celular, especialista.Email);

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

        private void CmbEspecialidade1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelcadastroespecialista_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DtvEspecialista.SelectedRows[0].Cells[0].Value.ToString());

            EspecialistaCtrl controle = new EspecialistaCtrl();

            this.especialista = controle.BuscarEspecialistaID(id);

            // Metodo para carregar paciente do form
            CarregarFormDeEspecialista(this.especialista);

            BtnDeletar.Visible = false;
            btnDados.Visible = false;
            DtvEspecialista.Visible = false;
            Btncadastrarmedico.Visible = false;
            btnBuscar.Visible = false;
            label.Visible = false;
            txtPesquisar.Visible = false;
            cbmFiltrar.Visible = false;
            textomedico.Visible = false;
            BtnAtualizar.Visible = false;
            labelAtt.Visible = false;
            labeldeletar.Visible = false;
            label.Visible = false;
            labelvisualizar.Visible = false;
            textatualizarmedico.Visible = false;

            btnVoltar.Visible = true;
            labeldadosespecialista.Visible = true;
            btnimprimir.Visible = true;
            labelimprimir.Visible = true;

            GpbDadosPessoais.Visible = true;
         
            GpbComplementares.Visible = true;
            gpbLogin.Visible = true;
            gpbProfissional.Visible = true;
            gpbObs.Visible = true;

            GpbDadosPessoais.Enabled = false;
            GpbComplementares.Enabled = false;
            gpbLogin.Enabled = false;
            gpbProfissional.Enabled = false;
            gpbObs.Enabled = false;
        
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            BtnDeletar.Visible = true;
            btnDados.Visible = true;
            DtvEspecialista.Visible = true;
            Btncadastrarmedico.Visible = true;
            btnBuscar.Visible = true;
            label.Visible = true;
            txtPesquisar.Visible = true;
            cbmFiltrar.Visible = true;
            textomedico.Visible = true;
            BtnAtualizar.Visible = true;
            labelAtt.Visible = true;
            labeldeletar.Visible = true;
            label.Visible = true;
            labelvisualizar.Visible = true;

            btnVoltar.Visible = false;
            labeldadosespecialista.Visible = false;
            btnimprimir.Visible = false;
            labelimprimir.Visible = false;
            GpbDadosPessoais.Visible = false;
       
            GpbComplementares.Visible = false;
            gpbLogin.Visible = false;
            gpbProfissional.Visible = false;
            gpbObs.Visible = false;
            BtnCancelar.Visible = false;
            BtnSalvarAlteracoes.Visible = false;
            textatualizarmedico.Visible = false;

            GpbDadosPessoais.Enabled = false;
            
            GpbComplementares.Enabled = false;
            gpbLogin.Enabled = false;
            gpbProfissional.Enabled = false;
            gpbObs.Enabled = false;
        }


        public void CarregarCombo()
        {

            //CtrlProfissao controle = new CtrlProfissao();

             //List<Profissao> listaProfissao = controle.buscartodos();
            //Acesso ao BD
            //Lista de valores ou objetos
            //cmbProfi.DisplayMember = "id";
           // cmbProfi.ValueMember = "nome";

           // cmbProfi.DataSource = listaProfissao;
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString(BmtUsuario.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawString(BmtSenha.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 120));
            e.Graphics.DrawString(CmbTipoPermissao.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 140));
            e.Graphics.DrawString(cmbProfi.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 160));
            e.Graphics.DrawString(BmtNome.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 180));
            e.Graphics.DrawString(MtbCPF.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 200));
            e.Graphics.DrawString(MtbRG.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 220));
            e.Graphics.DrawString(MtbTelefone.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 240));
            e.Graphics.DrawString(MtbCelular.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 260));
            e.Graphics.DrawString(MtbEmail.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 280));
            e.Graphics.DrawString(CmbIdade.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 300));
            e.Graphics.DrawString(CmbSexo.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 320));
            e.Graphics.DrawString(CmbStatus.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 340));
            e.Graphics.DrawString(CmbAreaAtuacao.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 360));
            e.Graphics.DrawString(CmbEspecialidade1.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 380));
            e.Graphics.DrawString(CmbEspecialidade2.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 400));
            e.Graphics.DrawString(MtbHoraini.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 420));
            e.Graphics.DrawString(MtbHorafim.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 440));
            e.Graphics.DrawString(CmbTipoDocumento.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 460));
            e.Graphics.DrawString(MtbNumeroDocumento.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 480));
            e.Graphics.DrawString(CmbUF.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 500));
            e.Graphics.DrawString(CmbSituacao.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 520));
            e.Graphics.DrawString(CmbTipoInscricao.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 540));
            e.Graphics.DrawString(CkbSegunda.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 560));
            e.Graphics.DrawString(CkbTerca.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 600));
            e.Graphics.DrawString(CkbQuarta.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 620));
            e.Graphics.DrawString(CkbQuinta.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 640));
            e.Graphics.DrawString(CkbSexta.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 660));
            e.Graphics.DrawString(CkbSabado.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 680));
            e.Graphics.DrawString(CkbDomingo.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 700));
            e.Graphics.DrawString(BmtObs.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 720));
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
