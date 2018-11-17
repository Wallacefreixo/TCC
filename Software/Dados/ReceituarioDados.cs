using Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ReceituarioDados
    {
        public void InserirReceituario(Receituario _receituario)
        {
            try
            {
                    string sql = String.Format("INSERT INTO Receituario (Data, Obs, IdConsulta) VALUES ('{0}', '{1}', '{2}')",
                    _receituario.Data,
                    _receituario.Obs,
                    _receituario.Idconsulta
                    );

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public void DeletarReceituario(int _IdReceituario)
        {
            try
            {
                string sql = String.Format("DELETE FROM Receituario WHERE Id={0}", _IdReceituario);

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

        public void AtualizarReceituario(Receituario _receituario)
        {
            try
            {
                string sql = String.Format("UPDATE Receituario SET Data ='{0}', Obs ='{1}', IdConsulta ='{2}' WHERE Id={3}",
                    _receituario.Data,
                    _receituario.Obs,
                    _receituario.Idconsulta,
                    _receituario.Id
                    );

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


        public List<Receituario> BuscarTodosReceituarios()
        {
            List<Receituario> Listareceituarios = new List<Receituario>();

            try
            {
                string sql = string.Format("SELECT Receituario.Id, Receituario.Data, Receituario.Obs, Receituario.IdConsulta, Paciente.Nome, Paciente.Cpf, Paciente.Rg, Especialista.Nome AS Expr1 FROM  Receituario INNER JOIN Consulta ON Receituario.IdConsulta = Consulta.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id");
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

                    Listareceituarios.Add(item);

                }

                data.Close();
                BancodeDados.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return Listareceituarios;
        }


        public Receituario BuscarReceituarioID(int _IdReceituario)
        {
            Receituario receituario = null;

            try
            {
                string sql = string.Format("SELECT Id, Data, Obs, IdConsulta FROM Receituario  WHERE Id={0}", _IdReceituario);
                SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                while (data.Read())
                {
                    receituario = new Receituario();

                    receituario.Id = data.GetInt32(0);
                    receituario.Data = data.GetString(1);
                    receituario.Obs = data.GetString(2);
                    receituario.Idconsulta = data.GetInt32(3);

                }

                data.Close();
                BancodeDados.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return receituario;
        }

    }
}
