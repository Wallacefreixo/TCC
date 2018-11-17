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
using System.Security;

namespace Visao
{
    public partial class DashPacienteCadastro : UserControl
    {
        public DashPacienteCadastro()
        {
            InitializeComponent();
            
        }
        


        private void ButtonSalvarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                PacienteCtrl controle = new PacienteCtrl();

                Paciente paciente = CarregarPacienteDoForm();

                controle.InserirPaciente(paciente);


                limpaFormulario();

                MessageBox.Show("Paciente cadastrado com sucesso!!");

                panelPacienteCadastro2.Controls.Clear();
                DashPaciente novo = new DashPaciente();
                panelPacienteCadastro2.Controls.Add(novo);
                novo.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }
        private Paciente CarregarPacienteDoForm()
        {
            //recebe os dados do formulario e joga em uma váriavel da istância paciente

            Paciente p = new Paciente();
            try
            {
                p.Usuario = BmtUsuario.Text;
                p.Senha = BmtSenha.Text;
                p.NomeCompleto = BmtNome.Text;
                p.Telefone = MtbTelefone.Text;
                p.Celular = MtbCelular.Text;
                p.Cpf = MtbCPF.Text;
                p.Rg = MtbRG.Text;
                p.Idade = CmbTipoConvenio.SelectedIndex.ToString();
                p.Tiposanguineo = CmbTipoSanguineo.SelectedIndex.ToString();
                p.Tipoconvenio = CmbTipoConvenio.SelectedIndex.ToString();
                p.Nplanodesaude = BmtNumeroPlano.Text;
                p.Datavalidadeplano = MtbValidadePlano.Text;
                p.Endereco = bmtEndereco.Text;
                p.Cidade = BmtCidade.Text;
                p.Estado = CmbEstado.SelectedIndex.ToString();
                p.Pacienteespecial = CkbPacienteEspecial.Checked;
                p.Sexo = CmbSexo.SelectedIndex.ToString();
                p.Estadocivil = CmbEstadoCivil.SelectedIndex.ToString();
                p.Nomepai = BmtNomePai.Text;
                p.Nomemae = BmtNomeMae.Text;
                p.Obs = BmtObs.Text;
                p.Email = MtbEmail.Text;

                /*
                //SEXO
                if (RdbMasculino.Checked)
                {
                    p.Sexo = "masculino";
                }
                if (RdbFeminino.Checked)
                {
                    p.Sexo = "feminino";
                }
                //Estado Civil
                if (RdbCasado.Checked)
                {
                    p.Estadocivil = "casado";
                }
                if (RdbSolteiro.Checked)
                {
                    p.Estadocivil = "solteiro";
                }
                */

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            return p;

        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelPacienteCadastro2.Controls.Clear();
            DashPaciente novo = new DashPaciente();
            panelPacienteCadastro2.Controls.Add(novo);
            novo.Show();

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
            MtbEmail.Text = "";


        }

        public Paciente paciente { get; set; }

     
        public string arquivo { get; set; }

        private void btnInserirFoto_Click(object sender, EventArgs e)
        {
            //define as propriedades do controle 
            //OpenFileDialog
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Selecionar Fotos";
            ofd1.InitialDirectory = @"C:\Users";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            DialogResult dr = this.ofd1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in ofd1.FileNames)
                {

                    // cria um PictureBox
                    try
                    {
                        pictureBoxPaciente pb = new pictureBoxPaciente();
                        Image Imagem = Image.FromFile(arquivo);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        //para exibir as imagens em tamanho natural 
                        //descomente as linhas abaixo e comente as duas seguintes
                        //pb.Height = loadedImage.Height;
                        //pb.Width = loadedImage.Width;
                        pb.Height = 86;
                        pb.Width = 82;
                        //atribui a imagem ao PictureBox - pb
                        pb.Image = Imagem;
                    }
                    catch (SecurityException ex)
                    {
                        // O usuário  não possui permissão para ler arquivos
                        MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                    "Mensagem : " + ex.Message + "\n\n" +
                                                    "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        // Não pode carregar a imagem (problemas de permissão)
                        MessageBox.Show("Não é possível exibir a imagem : " + arquivo.Substring(arquivo.LastIndexOf('\\'))
                                                   + ". Você pode não ter permissão para ler o arquivo , ou " +
                                                   " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                    }
                }
            }
        }

        private void ofd1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void panelPacienteCadastro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxPaciente_Click(object sender, EventArgs e)
        {

        }

        private void MtbEmail_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bunifuCustomLabel23_Click(object sender, EventArgs e)
        {

        }

        private void GpbDadosPessoais_Enter(object sender, EventArgs e)
        {

        }

        private void BmtObs_TextChanged(object sender, EventArgs e)
        {

        }

           

    }

 }
