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
    public partial class DashRelatórios : UserControl
    {

        //Atributos
        private Receituario receituario;
        private Laudo laudo;

        public DashRelatórios()
        {
            InitializeComponent();
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
            }
            if (cbmFiltrar.Text == "RG")
            {
                txtPesquisar.Mask = "00.000.000-0";
                txtPesquisar.Text = "";
            }
            if (cbmFiltrar.Text == "Data")
            {
                txtPesquisar.Mask = "00/00/0000";
                txtPesquisar.Text = "";

            }
            if (cbmFiltrar.Text == "")
            {
                txtPesquisar.Mask = "";
                txtPesquisar.Text = "";
                cmbtipodocumento.Text = null;

            }
        }

        private void btnVisualizarDados_Click(object sender, EventArgs e)
        {
            GpbReceituario.Visible = true;
            labelVisualizarReceituario.Visible = true;
            btnImprimiReceita.Visible = true;
            labelimprimirReceita.Visible = true;
            btnVoltarReceita.Visible = true;

            GpbReceituario.Enabled = false;
            txtPesquisar.Visible = false;
            DtvReceitas.Visible = false;
            label.Visible = false;
            textopacienteReceitúario.Visible = false;
            cbmFiltrar.Visible = false;
            cmbtipodocumento.Visible = false;
            labeldocumento.Visible = false;
            btnBuscar.Visible = false;
            BtnAtualizarReceita.Visible = false;
            BtnDeletarReceita.Visible = false;
            btnDadosReceita.Visible = false;
            labelAtt.Visible = false;
            labeldeletar.Visible = false;
            labelvisualizar.Visible = false;

            int id = int.Parse(DtvReceitas.SelectedRows[0].Cells[0].Value.ToString());

            ReceituarioCtrl controle = new ReceituarioCtrl();

            this.receituario = controle.BuscarReceituarioID(id);
            // Metodo para carregar paciente do form
            CarregarFormDeReceituario(this.receituario);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            // desativa caso seja Receituario
            limpaFormularioReceita();
            GpbReceituario.Enabled = false;
            GpbReceituario.Visible = false;
            labelVisualizarReceituario.Visible = false;
            btnImprimiReceita.Visible = false;
            labelimprimirReceita.Visible = false;
            btnVoltarReceita.Visible = false;

            GpbReceituario.Enabled = true;
            txtPesquisar.Visible = true;
            DtvReceitas.Visible = true;
            label.Visible = true;
            textopacienteReceitúario.Visible = true;
            cbmFiltrar.Visible = true;
            cmbtipodocumento.Visible = true;
            labeldocumento.Visible = true;
            btnBuscar.Visible = true;
            BtnAtualizarReceita.Visible = true;
            BtnDeletarReceita.Visible = true;
            btnDadosReceita.Visible = true;
            labelAtt.Visible = true;
            labeldeletar.Visible = true;
            labelvisualizar.Visible = true;   
        }
        private void limpaFormularioLaudo()
        {

            bmtidconsulta2.Text = "";
            mtbdata2.Text = "";
            BmtObs2.Text = "";
            cmbexame2.SelectedItem = null;


        }
        private void limpaFormularioReceita()
        {
            bmtidconsulta.Text = "";
            mtbdata.Text = "";
            bmtObs.Text = "";

            ListMed2.Items.Clear();
            ListEx2.Items.Clear();
            ListMed1.Items.Clear();
            ListEx1.Items.Clear();

        }
        private void CarregarGrid()
        {
            try
            {
                DtvReceitas.Rows.Clear();

                /*
            List<Agendamento> listaAgendamentos = CtrlAgendamento.BuscarTodos();

            foreach (Agendamento ag in listaAgendamentos)
            {
                DtvConsultas.Rows.Add(ag.Id, ag.Paciente.NomeCompleto, ag.Especialista.Nomecompleto, ag.Especialista.Especialidade1, ag.Data, ag.Horario);
            }
             */

                ReceituarioCtrl controle = new ReceituarioCtrl();

                List<Receituario> listaReceitas = controle.BuscarTodosReceituarios();

                foreach (Receituario r in listaReceitas)
                {
                    DtvReceitas.Rows.Add(r.Id, r.Nomepaciente,r.Cpf, r.Rg, r.Nomeespecialista, r.Data, r.Obs);
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("ERRO: " + ex.Message);
            }
        }
        private void CarregarGrid2()
        {
            try
            {
                DtvLaudo.Rows.Clear();

                /*
            List<Agendamento> listaAgendamentos = CtrlAgendamento.BuscarTodos();

            foreach (Agendamento ag in listaAgendamentos)
            {
                DtvConsultas.Rows.Add(ag.Id, ag.Paciente.NomeCompleto, ag.Especialista.Nomecompleto, ag.Especialista.Especialidade1, ag.Data, ag.Horario);
            }
             */

                LaudoCtrl controle = new LaudoCtrl();

                List<Laudo> listaLaudo = controle.BuscarTodosLaudos();

                foreach (Laudo l in listaLaudo)
                {
                    DtvLaudo.Rows.Add(l.Id, l.Nomepaciente, l.Cpfpaciente, l.Rgpaciente, l.Medicoresp, l.Data,l.Nomeexame, l.Obs);
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

       private void DashRelatórios_Load(object sender, EventArgs e)
       {
           CarregarGrid();
       }

       private void BtnAtualizar_Click(object sender, EventArgs e)
       {
               GpbReceituario.Enabled = true;   
               GpbReceituario.Visible = true;
               btnSalvaralteracaoReceita.Visible = true;
               btnCancelarReceita.Visible = true;
               labelAtualizarReceituario.Visible = true;

               txtPesquisar.Visible = false;
               labelVisualizarReceituario.Visible = false;
               DtvReceitas.Visible = false;
               label.Visible = false;
               textopacienteReceitúario.Visible = false;
               cbmFiltrar.Visible = false;
               cmbtipodocumento.Visible = false;
               labeldocumento.Visible = false;
               btnBuscar.Visible = false;
               BtnAtualizarReceita.Visible = false;
               BtnDeletarReceita.Visible = false;
               btnDadosReceita.Visible = false;
               labelAtt.Visible = false;
               labeldeletar.Visible = false;
               labelvisualizar.Visible = false;

               int id = int.Parse(DtvReceitas.SelectedRows[0].Cells[0].Value.ToString());

               ReceituarioCtrl controle = new ReceituarioCtrl();

               this.receituario = controle.BuscarReceituarioID(id);
               // Metodo para carregar paciente do form
               CarregarFormDeReceituario(this.receituario);

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
       private void CarregarFormDeReceituario(Receituario _receituario)
       {
           try
           {
               bmtidconsulta.Text = _receituario.Idconsulta.ToString();
               mtbdata.Text = _receituario.Data;
               bmtObs.Text = _receituario.Obs;
              // ListMed2.SelectedIndex = List<Medicamento>Receituario.Listamedicamento;
            //   ListEx2.SelectedIndex = List<Exame> Receituario.Listamedicamento;
             

           }
           catch (Exception ex)
           {
               MessageBox.Show("ERRO: " + ex.Message);
           }


       }
       private void CarregarFormDeLaudo(Laudo _laudo)
       {
           try
           {
               bmtidconsulta2.Text = _laudo.Idconsulta.ToString();
               mtbdata2.Text = _laudo.Data;
               BmtObs2.Text = _laudo.Obs;
               bmtidexame.Text = _laudo.Idexame.ToString();

           }
           catch (Exception ex)
           {
               MessageBox.Show("ERRO: " + ex.Message);
           }


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

       private void btnCancelarReceita_Click(object sender, EventArgs e)
       {
           GpbReceituario.Visible = false;
           btnSalvaralteracaoReceita.Visible = false;
           btnCancelarReceita.Visible = false;
           labelAtualizarReceituario.Visible = false;

           txtPesquisar.Visible = true;
           DtvReceitas.Visible = true;
           label.Visible = true;
           textopacienteReceitúario.Visible = true;
           cbmFiltrar.Visible = true;
           cmbtipodocumento.Visible = true;
           labeldocumento.Visible = true;
           btnBuscar.Visible = true;
           BtnAtualizarReceita.Visible = true;
           BtnDeletarReceita.Visible = true;
           btnDadosReceita.Visible = true;
           labelAtt.Visible = true;
           labeldeletar.Visible = true;
           labelvisualizar.Visible = true;

           limpaFormularioReceita();
       }

       private void BtnDeletarReceita_Click(object sender, EventArgs e)
       {
           int id = (int)DtvReceitas.CurrentRow.Cells[0].Value;
           if (MessageBox.Show("Deseja deletar o receituário de id = " + id + "?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
           {

               try
               {
                   ReceituarioCtrl controle = new ReceituarioCtrl();
                   controle.DeletarReceituario(id);


               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERRO: " + ex.Message);
               }
               CarregarGrid();
           }
       }

       private void btnSalvaralteracaoReceita_Click(object sender, EventArgs e)
       {
           try
           {
               ReceituarioCtrl controle = new ReceituarioCtrl();

               receituario.Idconsulta = int.Parse(bmtidconsulta.Text);
               receituario.Data = mtbdata.Text;
               receituario.Obs = bmtObs.Text;
              // receituario.Listamedicamento = List < Medicamento > receituario.Listamedicamento;
              // receituario.ListaExame = List < Exame > receituario.ListaExame;
         

               controle.AtualizarReceituario(receituario);
           }
           catch (Exception ex)
           {
               MessageBox.Show("ERRO: " + ex.Message);
           }


           MessageBox.Show("Receituário atualizado com sucesso!");
           limpaFormularioReceita();
           CarregarGrid();


           GpbReceituario.Visible = false;
           btnSalvaralteracaoReceita.Visible = false;
           btnCancelarReceita.Visible = false;
           labelAtualizarReceituario.Visible = false;

           txtPesquisar.Visible = true;
           DtvReceitas.Visible = true;
           label.Visible = true;
           textopacienteReceitúario.Visible = true;
           cbmFiltrar.Visible = true;
           cmbtipodocumento.Visible = true;
           labeldocumento.Visible = true;
           btnBuscar.Visible = true;
           BtnAtualizarReceita.Visible = true;
           BtnDeletarReceita.Visible = true;
           btnDadosReceita.Visible = true;
           labelAtt.Visible = true;
           labeldeletar.Visible = true;
           labelvisualizar.Visible = true;
       }

       private void btnImprimiReceita_Click(object sender, EventArgs e)
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

       private void btnimprimirLaudo_Click(object sender, EventArgs e)
       {
           if (printDialogLaudo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
           {
               printDocumentLaudo.PrinterSettings = printDialogLaudo.PrinterSettings;
               printDocumentLaudo.Print();
           }
       }

       private void btnBuscar_Click(object sender, EventArgs e)
       {

           if (cbmFiltrar.Text == "Data" && cmbtipodocumento.Text == "Laudo")
           {
               DtvReceitas.Visible = false;
               textopacienteReceitúario.Visible = false;
               BtnAtualizarReceita.Visible = false;
               BtnDeletarReceita.Visible = false;
               btnDadosReceita.Visible = false;
               labelAtt.Visible = false;
               labeldeletar.Visible = false;
               labelvisualizar.Visible = false;


               btnAtualizarLaudo.Visible = true;
               btnDeletarLaudo.Visible = true;
               BtnVisualizarLaudo.Visible = true;
               labelAttLaudo.Visible = true;
               labelDelLaudo.Visible = true;
               labelDadosLaudo.Visible = true;
               labelRelLaudos.Visible = true;
               DtvLaudo.Visible = true;

               try
               {
                   DtvLaudo.Rows.Clear();

                   string sql = string.Format("SELECT Laudo.Id, Laudo.IdConsulta, Laudo.Data, Laudo.Obs, Laudo.IdExame, Paciente.Nome, Paciente.Cpf, Paciente.Rg, Especialista.Nome AS Expr1, Exame.Nome AS Expr2 FROM Laudo INNER JOIN Consulta ON Laudo.IdConsulta = Consulta.Id AND Laudo.IdConsulta = Consulta.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id INNER JOIN Exame ON Laudo.IdExame = Exame.Id WHERE Laudo.Data LIKE '%" + txtPesquisar.Text + "%'");
                   SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                   while (data.Read())
                   {
                       Laudo item = new Laudo();

                       item.Id = data.GetInt32(0);
                       item.Idconsulta = data.GetInt32(1);
                       item.Data = data.GetString(2);
                       item.Obs = data.GetString(3);
                       item.Idexame = data.GetInt32(4);
                       item.Nomepaciente = data.GetString(5);
                       item.Cpfpaciente = data.GetString(6);
                       item.Rgpaciente = data.GetString(7);
                       item.Medicoresp = data.GetString(8);
                       item.Nomeexame = data.GetString(9);

                       DtvLaudo.Rows.Add(item.Id, item.Nomepaciente, item.Cpfpaciente, item.Rgpaciente, item.Medicoresp, item.Data, item.Nomeexame, item.Obs);
                   }

                   data.Close();
                   BancodeDados.FecharConexao();

               }
               catch (Exception ex)
               {
                   throw new Exception(ex.Message);
               }

           }
           else if (cbmFiltrar.Text == "Data" && cmbtipodocumento.Text == "Receituário")
               {
                   DtvReceitas.Visible = true;
                   textopacienteReceitúario.Visible = true;
                   BtnAtualizarReceita.Visible = true;
                   BtnDeletarReceita.Visible = true;
                   btnDadosReceita.Visible = true;
                   labelAtt.Visible = true;
                   labeldeletar.Visible = true;
                   labelvisualizar.Visible = true;


                   btnAtualizarLaudo.Visible = false;
                   btnDeletarLaudo.Visible = false;
                   BtnVisualizarLaudo.Visible = false;
                   labelAttLaudo.Visible = false;
                   labelDelLaudo.Visible = false;
                   labelDadosLaudo.Visible = false;
                   labelRelLaudos.Visible = false;
                   DtvLaudo.Visible = false;

                   try
                   {
                       DtvReceitas.Rows.Clear();
                       string sql = string.Format("SELECT Receituario.Id, Receituario.Data, Receituario.Obs, Receituario.IdConsulta, Paciente.Nome, Paciente.Cpf, Paciente.Rg, Especialista.Nome AS Expr1 FROM  Receituario INNER JOIN Consulta ON Receituario.IdConsulta = Consulta.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id WHERE Receituario.Data LIKE '%" + txtPesquisar.Text + "%'");
                       SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                       while (data.Read())
                       {
                           Receituario item = new Receituario();

                           item.Id = data.GetInt32(0);
                           item.Data = data.GetString(1);
                           item.Obs = data.GetString(2);
                           item.Idconsulta = data.GetInt32(3);
                           item.Nomepaciente = data.GetString(4);
                           item.Cpf = data.GetString(5);
                           item.Rg = data.GetString(6);
                           item.Nomeespecialista = data.GetString(7);

                           DtvReceitas.Rows.Add(item.Id, item.Nomepaciente, item.Cpf, item.Rg, item.Nomeespecialista, item.Data, item.Obs);
                       }

                       data.Close();
                       BancodeDados.FecharConexao();

                   }
                   catch (Exception ex)
                   {
                       throw new Exception(ex.Message);
                   }

           }
           else if (cbmFiltrar.Text == "CPF" && cmbtipodocumento.Text == "Laudo")
           {
               DtvReceitas.Visible = false;
               textopacienteReceitúario.Visible = false;
               BtnAtualizarReceita.Visible = false;
               BtnDeletarReceita.Visible = false;
               btnDadosReceita.Visible = false;
               labelAtt.Visible = false;
               labeldeletar.Visible = false;
               labelvisualizar.Visible = false;


               btnAtualizarLaudo.Visible = true;
               btnDeletarLaudo.Visible = true;
               BtnVisualizarLaudo.Visible = true;
               labelAttLaudo.Visible = true;
               labelDelLaudo.Visible = true;
               labelDadosLaudo.Visible = true;
               labelRelLaudos.Visible = true;
               DtvLaudo.Visible = true;

               try
               {
                   DtvLaudo.Rows.Clear();

                   string sql = string.Format("SELECT Laudo.Id, Laudo.IdConsulta, Laudo.Data, Laudo.Obs, Laudo.IdExame, Paciente.Nome, Paciente.Cpf, Paciente.Rg, Especialista.Nome AS Expr1, Exame.Nome AS Expr2 FROM Laudo INNER JOIN Consulta ON Laudo.IdConsulta = Consulta.Id AND Laudo.IdConsulta = Consulta.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id INNER JOIN Exame ON Laudo.IdExame = Exame.Id WHERE Paciente.Cpf LIKE '%" + txtPesquisar.Text + "%'");
                   SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                   while (data.Read())
                   {
                       Laudo item = new Laudo();

                       item.Id = data.GetInt32(0);
                       item.Idconsulta = data.GetInt32(1);
                       item.Data = data.GetString(2);
                       item.Obs = data.GetString(3);
                       item.Idexame = data.GetInt32(4);
                       item.Nomepaciente = data.GetString(5);
                       item.Cpfpaciente = data.GetString(6);
                       item.Rgpaciente = data.GetString(7);
                       item.Medicoresp = data.GetString(8);
                       item.Nomeexame = data.GetString(9);

                       DtvLaudo.Rows.Add(item.Id, item.Nomepaciente, item.Cpfpaciente, item.Rgpaciente, item.Medicoresp, item.Data, item.Nomeexame, item.Obs);
                   }

                   data.Close();
                   BancodeDados.FecharConexao();

               }
               catch (Exception ex)
               {
                   throw new Exception(ex.Message);
               }

           }
           else if (cbmFiltrar.Text == "Nome Completo" && cmbtipodocumento.Text == "Laudo")
           {
               DtvReceitas.Visible = false;
               textopacienteReceitúario.Visible = false;
               BtnAtualizarReceita.Visible = false;
               BtnDeletarReceita.Visible = false;
               btnDadosReceita.Visible = false;
               labelAtt.Visible = false;
               labeldeletar.Visible = false;
               labelvisualizar.Visible = false;


               btnAtualizarLaudo.Visible = true;
               btnDeletarLaudo.Visible = true;
               BtnVisualizarLaudo.Visible = true;
               labelAttLaudo.Visible = true;
               labelDelLaudo.Visible = true;
               labelDadosLaudo.Visible = true;
               labelRelLaudos.Visible = true;
               DtvLaudo.Visible = true;

               try
               {
                   DtvLaudo.Rows.Clear();

                   string sql = string.Format("SELECT Laudo.Id, Laudo.IdConsulta, Laudo.Data, Laudo.Obs, Laudo.IdExame, Paciente.Nome, Paciente.Cpf, Paciente.Rg, Especialista.Nome AS Expr1, Exame.Nome AS Expr2 FROM Laudo INNER JOIN Consulta ON Laudo.IdConsulta = Consulta.Id AND Laudo.IdConsulta = Consulta.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id INNER JOIN Exame ON Laudo.IdExame = Exame.Id WHERE Paciente.Nome LIKE '%" + txtPesquisar.Text + "%'");
                   SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                   while (data.Read())
                   {
                       Laudo item = new Laudo();

                       item.Id = data.GetInt32(0);
                       item.Idconsulta = data.GetInt32(1);
                       item.Data = data.GetString(2);
                       item.Obs = data.GetString(3);
                       item.Idexame = data.GetInt32(4);
                       item.Nomepaciente = data.GetString(5);
                       item.Cpfpaciente = data.GetString(6);
                       item.Rgpaciente = data.GetString(7);
                       item.Medicoresp = data.GetString(8);
                       item.Nomeexame = data.GetString(9);

                       DtvLaudo.Rows.Add(item.Id, item.Nomepaciente, item.Cpfpaciente, item.Rgpaciente, item.Medicoresp, item.Data, item.Nomeexame, item.Obs);
                   }

                   data.Close();
                   BancodeDados.FecharConexao();
               }
               catch (Exception ex)
               {
                   throw new Exception(ex.Message);
               }

           }
           else if (cbmFiltrar.Text == "RG" && cmbtipodocumento.Text == "Laudo")
           {
               DtvReceitas.Visible = false;
               textopacienteReceitúario.Visible = false;
               BtnAtualizarReceita.Visible = false;
               BtnDeletarReceita.Visible = false;
               btnDadosReceita.Visible = false;
               labelAtt.Visible = false;
               labeldeletar.Visible = false;
               labelvisualizar.Visible = false;


               btnAtualizarLaudo.Visible = true;
               btnDeletarLaudo.Visible = true;
               BtnVisualizarLaudo.Visible = true;
               labelAttLaudo.Visible = true;
               labelDelLaudo.Visible = true;
               labelDadosLaudo.Visible = true;
               labelRelLaudos.Visible = true;
               DtvLaudo.Visible = true;

               try
               {
                   DtvLaudo.Rows.Clear();

                   string sql = string.Format("SELECT Laudo.Id, Laudo.IdConsulta, Laudo.Data, Laudo.Obs, Laudo.IdExame, Paciente.Nome, Paciente.Cpf, Paciente.Rg, Especialista.Nome AS Expr1, Exame.Nome AS Expr2 FROM Laudo INNER JOIN Consulta ON Laudo.IdConsulta = Consulta.Id AND Laudo.IdConsulta = Consulta.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id INNER JOIN Exame ON Laudo.IdExame = Exame.Id WHERE Paciente.Rg LIKE '%" + txtPesquisar.Text + "%'");
                   SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                   while (data.Read())
                   {
                       Laudo item = new Laudo();

                       item.Id = data.GetInt32(0);
                       item.Idconsulta = data.GetInt32(1);
                       item.Data = data.GetString(2);
                       item.Obs = data.GetString(3);
                       item.Idexame = data.GetInt32(4);
                       item.Nomepaciente = data.GetString(5);
                       item.Cpfpaciente = data.GetString(6);
                       item.Rgpaciente = data.GetString(7);
                       item.Medicoresp = data.GetString(8);
                       item.Nomeexame = data.GetString(9);

                       DtvLaudo.Rows.Add(item.Id, item.Nomepaciente, item.Cpfpaciente, item.Rgpaciente, item.Medicoresp, item.Data, item.Nomeexame, item.Obs);
                   }

                   data.Close();
                   BancodeDados.FecharConexao();

               }
               catch (Exception ex)
               {
                   throw new Exception(ex.Message);
               }

           }
       
           else if (cbmFiltrar.Text == "CPF" && cmbtipodocumento.Text == "Receituário")
           {
               DtvReceitas.Visible = true;
               textopacienteReceitúario.Visible = true;
               BtnAtualizarReceita.Visible = true;
               BtnDeletarReceita.Visible = true;
               btnDadosReceita.Visible = true;
               labelAtt.Visible = true;
               labeldeletar.Visible = true;
               labelvisualizar.Visible = true;


               btnAtualizarLaudo.Visible = false;
               btnDeletarLaudo.Visible = false;
               BtnVisualizarLaudo.Visible = false;
               labelAttLaudo.Visible = false;
               labelDelLaudo.Visible = false;
               labelDadosLaudo.Visible = false;
               labelRelLaudos.Visible = false;
               DtvLaudo.Visible = false;

               try
               {
                   DtvReceitas.Rows.Clear();
                   string sql = string.Format("SELECT Receituario.Id, Receituario.Data, Receituario.Obs, Receituario.IdConsulta, Paciente.Nome, Paciente.Cpf, Paciente.Rg, Especialista.Nome AS Expr1 FROM  Receituario INNER JOIN Consulta ON Receituario.IdConsulta = Consulta.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id WHERE Paciente.Cpf LIKE '%" + txtPesquisar.Text + "%'");
                   SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                   while (data.Read())
                   {
                       Receituario item = new Receituario();

                       item.Id = data.GetInt32(0);
                       item.Data = data.GetString(1);
                       item.Obs = data.GetString(2);
                       item.Idconsulta = data.GetInt32(3);
                       item.Nomepaciente = data.GetString(4);
                       item.Cpf = data.GetString(5);
                       item.Rg = data.GetString(6);
                       item.Nomeespecialista = data.GetString(7);

                       DtvReceitas.Rows.Add(item.Id, item.Nomepaciente, item.Cpf, item.Rg, item.Nomeespecialista, item.Data, item.Obs);
                   }

                   data.Close();
                   BancodeDados.FecharConexao();

               }
               catch (Exception ex)
               {
                   throw new Exception(ex.Message);
               }

           }
 
           else if (cbmFiltrar.Text == "Nome Completo" && cmbtipodocumento.Text == "Receituário")
           {
               DtvReceitas.Visible = true;
               textopacienteReceitúario.Visible = true;
               BtnAtualizarReceita.Visible = true;
               BtnDeletarReceita.Visible = true;
               btnDadosReceita.Visible = true;
               labelAtt.Visible = true;
               labeldeletar.Visible = true;
               labelvisualizar.Visible = true;


               btnAtualizarLaudo.Visible = false;
               btnDeletarLaudo.Visible = false;
               BtnVisualizarLaudo.Visible = false;
               labelAttLaudo.Visible = false;
               labelDelLaudo.Visible = false;
               labelDadosLaudo.Visible = false;
               labelRelLaudos.Visible = false;
               DtvLaudo.Visible = false;

               try
               {
                   DtvReceitas.Rows.Clear();
                   string sql = string.Format("SELECT Receituario.Id, Receituario.Data, Receituario.Obs, Receituario.IdConsulta, Paciente.Nome, Paciente.Cpf, Paciente.Rg, Especialista.Nome AS Expr1 FROM  Receituario INNER JOIN Consulta ON Receituario.IdConsulta = Consulta.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id WHERE Paciente.Nome LIKE '%" + txtPesquisar.Text + "%'");
                   SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                   while (data.Read())
                   {
                       Receituario item = new Receituario();

                       item.Id = data.GetInt32(0);
                       item.Data = data.GetString(1);
                       item.Obs = data.GetString(2);
                       item.Idconsulta = data.GetInt32(3);
                       item.Nomepaciente = data.GetString(4);
                       item.Cpf = data.GetString(5);
                       item.Rg = data.GetString(6);
                       item.Nomeespecialista = data.GetString(7);

                       DtvReceitas.Rows.Add(item.Id, item.Nomepaciente, item.Cpf, item.Rg, item.Nomeespecialista, item.Data, item.Obs);
                   }

                   data.Close();
                   BancodeDados.FecharConexao();

               }
               catch (Exception ex)
               {
                   throw new Exception(ex.Message);
               }

           }
           else if (cbmFiltrar.Text == "RG" && cmbtipodocumento.Text == "Receituário")
           {
               DtvReceitas.Visible = true;
               textopacienteReceitúario.Visible = true;
               BtnAtualizarReceita.Visible = true;
               BtnDeletarReceita.Visible = true;
               btnDadosReceita.Visible = true;
               labelAtt.Visible = true;
               labeldeletar.Visible = true;
               labelvisualizar.Visible = true;


               btnAtualizarLaudo.Visible = false;
               btnDeletarLaudo.Visible = false;
               BtnVisualizarLaudo.Visible = false;
               labelAttLaudo.Visible = false;
               labelDelLaudo.Visible = false;
               labelDadosLaudo.Visible = false;
               labelRelLaudos.Visible = false;
               DtvLaudo.Visible = false;

               try
               {
                   DtvReceitas.Rows.Clear();
                   string sql = string.Format("SELECT Receituario.Id, Receituario.Data, Receituario.Obs, Receituario.IdConsulta, Paciente.Nome, Paciente.Cpf, Paciente.Rg, Especialista.Nome AS Expr1 FROM  Receituario INNER JOIN Consulta ON Receituario.IdConsulta = Consulta.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id WHERE Paciente.Rg LIKE '%" + txtPesquisar.Text + "%'");
                   SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                   while (data.Read())
                   {
                       Receituario item = new Receituario();

                       item.Id = data.GetInt32(0);
                       item.Data = data.GetString(1);
                       item.Obs = data.GetString(2);
                       item.Idconsulta = data.GetInt32(3);
                       item.Nomepaciente = data.GetString(4);
                       item.Cpf = data.GetString(5);
                       item.Rg = data.GetString(6);
                       item.Nomeespecialista = data.GetString(7);

                       DtvReceitas.Rows.Add(item.Id, item.Nomepaciente, item.Cpf, item.Rg, item.Nomeespecialista, item.Data, item.Obs);
                   }

                   data.Close();
                   BancodeDados.FecharConexao();

               }
               catch (Exception ex)
               {
                   throw new Exception(ex.Message);
               }

           }
          
         
           else if (cmbtipodocumento.Text == "Laudo")
           {
               CarregarGrid2();
               DtvReceitas.Visible = false;
               textopacienteReceitúario.Visible = false;
               BtnAtualizarReceita.Visible = false;
               BtnDeletarReceita.Visible = false;
               btnDadosReceita.Visible = false;
               labelAtt.Visible = false;
               labeldeletar.Visible = false;
               labelvisualizar.Visible = false;


               btnAtualizarLaudo.Visible = true;
               btnDeletarLaudo.Visible = true;
               BtnVisualizarLaudo.Visible = true;
               labelAttLaudo.Visible = true;
               labelDelLaudo.Visible = true;
               labelDadosLaudo.Visible = true;
               labelRelLaudos.Visible = true;
               DtvLaudo.Visible = true;

              
           
           
           }
           else  if (cmbtipodocumento.Text == "Receituário")
           {
               CarregarGrid();
               DtvReceitas.Visible = true;
               textopacienteReceitúario.Visible = true;
               BtnAtualizarReceita.Visible = true;
               BtnDeletarReceita.Visible = true;
               btnDadosReceita.Visible = true;
               labelAtt.Visible = true;
               labeldeletar.Visible = true;
               labelvisualizar.Visible = true;


               btnAtualizarLaudo.Visible = false; 
               btnDeletarLaudo.Visible = false; 
               BtnVisualizarLaudo.Visible = false;
               labelAttLaudo.Visible = false; 
               labelDelLaudo.Visible = false; 
               labelDadosLaudo.Visible = false; 
               labelRelLaudos.Visible = false; 
               DtvLaudo.Visible = false;

           }
           else if(cmbtipodocumento.Text == "")
           {
               CarregarGrid();
               DtvReceitas.Visible = true;
               textopacienteReceitúario.Visible = true;
               BtnAtualizarReceita.Visible = true;
               BtnDeletarReceita.Visible = true;
               btnDadosReceita.Visible = true;
               labelAtt.Visible = true;
               labeldeletar.Visible = true;
               labelvisualizar.Visible = true;


               btnAtualizarLaudo.Visible = false;
               btnDeletarLaudo.Visible = false;
               BtnVisualizarLaudo.Visible = false;
               labelAttLaudo.Visible = false; 
               labelDelLaudo.Visible = false; 
               labelDadosLaudo.Visible = false; 
               labelRelLaudos.Visible = false; 
               DtvLaudo.Visible = false;

           }
       }

       private void btnAtualizarLaudo_Click(object sender, EventArgs e)
       {
           GpbLaudo.Enabled = true;
           GpbLaudo.Visible = true;
           BtnSalvarAlteracoesLaudo.Visible = true;
           BtnCancelarLaudo.Visible = true;
           txtAttLaudo.Visible = true;

           labelRelLaudos.Visible = false;
           txtPesquisar.Visible = false;
           DtvLaudo.Visible = false;
           label.Visible = false;
           textopacienteReceitúario.Visible = false;
           cbmFiltrar.Visible = false;
           cmbtipodocumento.Visible = false;
           labeldocumento.Visible = false;
           btnBuscar.Visible = false;
           btnAtualizarLaudo.Visible = false;
           btnDeletarLaudo.Visible = false;
           BtnVisualizarLaudo.Visible = false;
           labelAttLaudo.Visible = false;
           labelDelLaudo.Visible = false;
           labelDadosLaudo.Visible = false;
           labelRelLaudos.Visible = false; 

           int id = int.Parse(DtvLaudo.SelectedRows[0].Cells[0].Value.ToString());

           LaudoCtrl controle = new LaudoCtrl();

           this.laudo = controle.BuscarLaudoID(id);
           // Metodo para carregar paciente do form
           CarregarFormDeLaudo(this.laudo);

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

       private void cmbexame2_SelectedIndexChanged(object sender, EventArgs e)
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

       private void btnDeletarLaudo_Click(object sender, EventArgs e)
       {

           int id = (int)DtvLaudo.CurrentRow.Cells[0].Value;
           if (MessageBox.Show("Deseja deletar o laudo de id = " + id + "?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
           {

               try
               {
                   LaudoCtrl controle = new LaudoCtrl();

                   controle.DeletarLaudo(id);

               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERRO: " + ex.Message);
               }
               CarregarGrid2();
           }
       }

       private void BtnVisualizarLaudo_Click(object sender, EventArgs e)
       {
         
           GpbLaudo.Visible = true;
           txtDadosLaudo.Visible = true;
           btnimprimirLaudo.Visible = true;
           labelimprimirLaudo.Visible = true;
           btnVoltarLaudo.Visible = true;

           GpbLaudo.Enabled = false;
           labelRelLaudos.Visible = false;
           txtPesquisar.Visible = false;
           DtvLaudo.Visible = false;
           label.Visible = false;
           cbmFiltrar.Visible = false;
           cmbtipodocumento.Visible = false;
           labeldocumento.Visible = false;
           btnBuscar.Visible = false;
           btnAtualizarLaudo.Visible = false;
           btnDeletarLaudo.Visible = false;
           BtnVisualizarLaudo.Visible = false;
           labelAttLaudo.Visible = false;
           labelDelLaudo.Visible = false;
           labelDadosLaudo.Visible = false;
 

           int id = int.Parse(DtvLaudo.SelectedRows[0].Cells[0].Value.ToString());

           LaudoCtrl controle = new LaudoCtrl();

           this.laudo = controle.BuscarLaudoID(id);
           // Metodo para carregar paciente do form
           CarregarFormDeLaudo(this.laudo);

       }

       private void BtnCancelarLaudo_Click(object sender, EventArgs e)
       {
           GpbLaudo.Enabled = false;
           GpbLaudo.Visible = false;
           BtnSalvarAlteracoesLaudo.Visible = false;
           BtnCancelarLaudo.Visible = false;
           txtAttLaudo.Visible = false;
           textopacienteReceitúario.Visible = false;

           labelRelLaudos.Visible = true;
           txtPesquisar.Visible = true;
           DtvLaudo.Visible = true;
           label.Visible = true;
           cbmFiltrar.Visible = true;
           cmbtipodocumento.Visible = true;
           labeldocumento.Visible = true;
           btnBuscar.Visible = true;
           btnAtualizarLaudo.Visible = true;
           btnDeletarLaudo.Visible = true;
           BtnVisualizarLaudo.Visible = true;
           labelAttLaudo.Visible = true;
           labelDelLaudo.Visible = true;
           labelDadosLaudo.Visible = true;
           labelRelLaudos.Visible = true; 
       }

       private void BtnSalvarAlteracoesLaudo_Click(object sender, EventArgs e)
       {
           try
           {
               LaudoCtrl controle = new LaudoCtrl();

               laudo.Idconsulta = int.Parse(bmtidconsulta2.Text);
               laudo.Data = mtbdata2.Text;
               laudo.Obs = BmtObs2.Text;
               laudo.Idexame = int.Parse(bmtidexame.Text);


               controle.AtualizarLaudo(laudo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("ERRO: " + ex.Message);
           }


           MessageBox.Show("Laudo atualizado com sucesso!");
           limpaFormularioReceita();
           CarregarGrid2();

           GpbLaudo.Enabled = false;
           GpbLaudo.Visible = false;
           BtnSalvarAlteracoesLaudo.Visible = false;
           BtnCancelarLaudo.Visible = false;
           txtAttLaudo.Visible = false;

           labelRelLaudos.Visible = true;
           txtPesquisar.Visible = true;
           DtvLaudo.Visible = true;
           label.Visible = true;
           cbmFiltrar.Visible = true;
           cmbtipodocumento.Visible = true;
           labeldocumento.Visible = true;
           btnBuscar.Visible = true;
           btnAtualizarLaudo.Visible = true;
           btnDeletarLaudo.Visible = true;
           BtnVisualizarLaudo.Visible = true;
           labelAttLaudo.Visible = true;
           labelDelLaudo.Visible = true;
           labelDadosLaudo.Visible = true;
           labelRelLaudos.Visible = true; 
       }

       private void btnVoltarLaudo_Click(object sender, EventArgs e)
       {
           // desativa caso seja laudo
           limpaFormularioLaudo();

           GpbLaudo.Visible = false;
           txtDadosLaudo.Visible = false;
           btnimprimirLaudo.Visible = false;
           labelimprimirLaudo.Visible = false;
           btnVoltarLaudo.Visible = false;

           GpbLaudo.Enabled = true;
           labelRelLaudos.Visible = true;
           txtPesquisar.Visible = true;
           DtvLaudo.Visible = true;
           label.Visible = true;
           cbmFiltrar.Visible = true;
           cmbtipodocumento.Visible = true;
           labeldocumento.Visible = true;
           btnBuscar.Visible = true;
           btnAtualizarLaudo.Visible = true;
           btnDeletarLaudo.Visible = true;
           BtnVisualizarLaudo.Visible = true;
           labelAttLaudo.Visible = true;
           labelDelLaudo.Visible = true;
           labelDadosLaudo.Visible = true;
           labelRelLaudos.Visible = true;
       }

       
       
    }
}
