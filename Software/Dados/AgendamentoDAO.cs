using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using System.Data.SqlServerCe;

namespace Dados
{
    public static class AgendamentoDAO
    {
        public static List<Agendamento> BuscarTodos()
        {
   
            List<Agendamento> ListaConsultas = new List<Agendamento>();

            try
            {

             string sql = string.Format("SELECT Id, IdPaciente, IdMedico, Motivo, HorarioAtendimento, Data, Status FROM Consulta");
             SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

              while (data.Read())
              {
                Consulta item = new Consulta();

                item.Id = data.GetInt32(0);
                item.Idpaciente = data.GetInt32(1);
                item.Idmedico = data.GetInt32(2);
                item.Motivo = data.GetString(3);
                item.Horario = data.GetString(4);
                item.Data = data.GetString(5);
                item.Status = data.GetString(6);

                PacienteDados dao = new PacienteDados();
                Paciente paciente = dao.BuscarPacienteID(item.Idpaciente);
    
                 EspecialistaDados daoesp = new EspecialistaDados();
                 Especialista especialista = daoesp.BuscarEspecialistaID(item.Idmedico);

                 Agendamento ag = new Agendamento();

                 ag.Paciente = paciente;
                 ag.Especialista = especialista;

                 ListaConsultas.Add(ag);
            }

            data.Close();
            BancodeDados.FecharConexao();

            }

           catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ListaConsultas;
        }
   }
}

