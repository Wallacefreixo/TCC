using Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ConsultaDados
    {
        //Inserir laudo no banco de dados
        public void InserirConsulta(Consulta _consulta)
        {
            try
            {
                string sql = String.Format("INSERT INTO Consulta (IdPaciente, IdMedico, Motivo, HorarioAtendimento, Data, Status) VALUES ('{0}', '{1}', '{2}', '{3}' , '{4}', '{5}')",
                    _consulta.Idpaciente,
                    _consulta.Idmedico,
                    _consulta.Motivo,
                    _consulta.Horario,
                    _consulta.Data,
                    _consulta.Status);

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //Deletar medico no banco de dados
        public void DeletarConsulta(int _IdConsulta)
        {
            try
            {
                string sql = String.Format("DELETE FROM Consulta WHERE Id={0}", _IdConsulta);

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

        //Atualiza Consulta no banco de dados
        public void AtualizarConsulta(Consulta _consulta)
        {
            try
            {
                string sql = String.Format("UPDATE Consulta SET IdPaciente ='{0}', IdMedico ='{1}', Motivo ='{2}', HorarioAtendimento ='{3}', Data ='{4}', Status ='{5}' WHERE Id={6}",
                    _consulta.Idpaciente,
                    _consulta.Idmedico,
                    _consulta.Motivo,
                    _consulta.Horario,
                    _consulta.Data,
                    _consulta.Status,
                    _consulta.Id);

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


        //Buscar todos os laudos no banco de dados
        public List<Consulta> BuscarTodasConsultas()
        {
            List<Consulta> ListaConsultas = new List<Consulta>();

            try
            {
                string sql = string.Format("SELECT Consulta.Id, Consulta.IdPaciente, Consulta.IdMedico, Consulta.Motivo, Consulta.HorarioAtendimento, Consulta.Data, Consulta.Status, Paciente.Nome, Especialista.Nome, Especialista.Especialidade1 FROM Consulta INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id");
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
                    item.Nomepaciente = data.GetString(7);
                    item.Medicoresp = data.GetString(8);
                    item.Tipoconsulta = data.GetString(9);

                    ListaConsultas.Add(item);

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


        //Buscar um unico laudo pela sua ID
        public Consulta BuscarConsultaID(int _IdConsulta)
        {
            Consulta consulta = null;

            try
            {
                string sql = string.Format("SELECT Id, IdPaciente, IdMedico, Motivo, HorarioAtendimento, Data, Status FROM Consulta WHERE Id={0}", _IdConsulta);
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

                }

                data.Close();
                BancodeDados.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return consulta;
        }
    }
}

