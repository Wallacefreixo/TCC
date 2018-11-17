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
    public partial class DashEspecialistaCadastro : UserControl
    {
        public DashEspecialistaCadastro()
        {
            InitializeComponent();
        }

        private void ButtonSalvarEspecialista_Click(object sender, EventArgs e)
        {
            try
            {
                EspecialistaCtrl controle = new EspecialistaCtrl();

                Especialista especialista = CarregarEspecialistaDoForm();

                controle.InserirEspecialista(especialista);


                limpaFormulario();

                MessageBox.Show("Especialista cadastrado com sucesso!!");

                panelcadastromedico2.Controls.Clear();
                DashEspecialista novo = new DashEspecialista();
                panelcadastromedico2.Controls.Add(novo);
                novo.Show();



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private Especialista CarregarEspecialistaDoForm()
        {
            //recebe os dados do formulario e joga em uma váriavel da istância medico

            Especialista e = new Especialista();
            try
            {
                e.Usuario = BmtUsuario.Text;
                e.Senha = BmtSenha.Text;
                e.Cpf = MtbCPF.Text;
                e.Rg = MtbRG.Text;
                e.Telefone = MtbTelefone.Text;
                e.Celular = MtbCelular.Text;
                e.Email = MtbEmail.Text;
                e.Sexo = CmbSexo.SelectedIndex.ToString();
                e.Status = CmbStatus.SelectedIndex.ToString();
                e.Obs =  BmtObs.Text;
                e.Idade = CmbIdade.SelectedIndex.ToString();
                e.Areaatuacao = CmbAreaAtuacao.SelectedIndex.ToString();
                e.Especialidade1 = CmbEspecialidade1.SelectedIndex.ToString();
                e.Especialidade2 = CmbEspecialidade2.SelectedIndex.ToString();
                e.Horaatendimentoini = MtbHoraini.Text;
                e.Horaatendimentofim = MtbHorafim.Text;
                e.Tipodocumentomedico = CmbTipoDocumento.SelectedIndex.ToString();
                e.Numerodocumento = MtbNumeroDocumento.Text;
                e.Uf = CmbUF.SelectedIndex.ToString();
                e.Situacao = CmbSituacao.SelectedIndex.ToString();
                e.Tipoinscricao = CmbTipoInscricao.SelectedIndex.ToString();

                e.Atendimentosegunda = CkbSegunda.Checked;
                e.Atendimentoterca = CkbTerca.Checked;
                e.Atendimentoquarta = CkbQuarta.Checked;
                e.Atendimentoquinta = CkbQuinta.Checked;
                e.Atendimentosexta = CkbSexta.Checked;
                e.Atendimentosabado = CkbSabado.Checked;
                e.Atendimentodomingo = CkbDomingo.Checked;

                e.Tipopermissao = CmbTipoPermissao.SelectedIndex.ToString();
                e.Nomecompleto = BmtNome.Text;
                e.Profissao = cmbProfi.SelectedIndex.ToString();

                /*
                //SEXO
                if (RdbMasculino.Checked)
                {
                    m.Sexo = "masculino";
                }
                if (RdbFeminino.Checked)
                {
                    m.Sexo = "feminino";
                }
                */

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            return e;

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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelcadastromedico2.Controls.Clear();
            DashEspecialista novo = new DashEspecialista();
            panelcadastromedico2.Controls.Add(novo);
            novo.Show();

        }

        private void ofd1_FileOk(object sender, CancelEventArgs e)
        {
        }

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
                        pictureBoxMedico pb = new pictureBoxMedico();
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

        

        private void cmbProfi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProfi.Text == "Médico")
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

                CmbAreaAtuacao.Enabled = true;
                CmbEspecialidade1.Enabled = true;
                CmbEspecialidade2.Enabled = true;
                CmbTipoDocumento.Enabled = true;
                MtbNumeroDocumento.Enabled = true;
                CmbUF.Enabled = true;
                CmbSituacao.Enabled = true;
                CmbTipoInscricao.Enabled = true;

            }

            else {
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

    }
}
