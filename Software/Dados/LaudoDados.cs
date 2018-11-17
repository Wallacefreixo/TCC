using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using System.Data.SqlServerCe;

namespace Dados
{
    public class LaudoDados
    {
          //Inserir laudo no banco de dados
        public void InserirLaudo(Laudo _laudo)
        {
            try
            {
                string sql = String.Format("INSERT INTO Laudo (IdConsulta, Data, Obs, IdExame) VALUES ('{0}', '{1}', '{2}', '{3}' )",
                    _laudo.Idconsulta,
                    _laudo.Data,
                    _laudo.Obs,
                    _laudo.Idexame
                    );

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
             
        //Deletar medico no banco de dados
        public void DeletarLaudo(int _IdLaudo)
        {
            try
            {
                string sql = String.Format("DELETE FROM Laudo WHERE Id={0}", _IdLaudo);

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            
            }
        
        }

        //Atualizar laudo no banco de dados
        public void AtualizarLaudo(Laudo _laudo)
        {
            try
            {
                string sql = String.Format("UPDATE Laudo SET IdConsulta = '{0}', Data ='{1}', Obs ='{2}', IdExame ='{3}' WHERE Id={4}", 
                    _laudo.Idconsulta,
                    _laudo.Data,
                    _laudo.Obs,
                    _laudo.Idexame, 
                    _laudo.Id);

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //Buscar todos os laudos no banco de dados
        public List<Laudo> BuscarTodosLaudos()
        {
            List<Laudo> ListaLaudos = new List<Laudo>();

            try
            {
                string sql = string.Format("SELECT Laudo.Id, Laudo.IdConsulta, Laudo.Data, Laudo.Obs, Laudo.IdExame, Paciente.Nome, Paciente.Cpf, Paciente.Rg, Especialista.Nome AS Expr1, Exame.Nome AS Expr2 FROM Laudo INNER JOIN Consulta ON Laudo.IdConsulta = Consulta.Id AND Laudo.IdConsulta = Consulta.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id INNER JOIN Exame ON Laudo.IdExame = Exame.Id");
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

                    ListaLaudos.Add(item);
                }

                data.Close();
                BancodeDados.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return ListaLaudos;
        }


        //Buscar um unico laudo pela sua ID
        public Laudo BuscarLaudoID(int _IdLaudo)
        {
            Laudo laudo = null;

            try
            {
                string sql = string.Format("SELECT  Id, IdConsulta, Data, Obs, IdExame FROM Laudo WHERE Id={0}", _IdLaudo);
                SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                while (data.Read())
                {
                    laudo = new Laudo();

                    laudo.Id = data.GetInt32(0);
                    laudo.Idconsulta = data.GetInt32(1);
                    laudo.Data = data.GetString(2);
                    laudo.Obs = data.GetString(3);
                    laudo.Idexame = data.GetInt32(4);

                }

                data.Close();
                BancodeDados.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return laudo;
        }

        
    }
}
   
