using Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ProntuarioDados
    {
        //Inserir laudo no banco de dados
        public void InserirProntuario(Prontuario _prontuario)
        {
            try
            {
                string sql = String.Format("INSERT INTO Prontuario (IdReceituario, IdLaudo, IdConsulta, DataHistorico, Inf) VALUES ('{0}', '{1}', '{2}', '{3}' , '{4}')",
                    _prontuario.Idreceituario,
                    _prontuario.Idlaudo,
                    _prontuario.Idconsulta,
                    _prontuario.Datahistorico,
                    _prontuario.Informacao
                    );

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //Deletar medico no banco de dados
        public void DeletarProntuario(int _IdProntuario)
        {
            try
            {
                string sql = String.Format("DELETE FROM Prontuario WHERE Id={0}", _IdProntuario);

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

        //Atualiza Consulta no banco de dados
        public void AtualizarProntuario(Prontuario _prontuario)
        {
            try
            {
                string sql = String.Format("UPDATE Consulta SET IdReceituario ='{0}', IdLaudo ='{1}', IdConsulta ='{2}', DataHistorico ='{3}', Inf ='{4}' WHERE Id={5}",
                    _prontuario.Idreceituario,
                    _prontuario.Idlaudo,
                    _prontuario.Idconsulta,
                    _prontuario.Datahistorico,
                    _prontuario.Informacao,
                    _prontuario.Id
                    );

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


        //Buscar todos os laudos no banco de dados
        public List<Prontuario> BuscarTodosProntuarios()
        {
            List<Prontuario> Listaprontuarios = new List<Prontuario>();

            try
            {
                string sql = string.Format("SELECT Id, IdReceituario, IdLaudo, IdConsulta, DataHistorico, Inf FROM Prontuario");
                SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                while (data.Read())
                {
                    Prontuario item = new Prontuario();

                    item.Id = data.GetInt32(0);
                    item.Idreceituario = data.GetInt32(1);
                    item.Idlaudo = data.GetInt32(2);
                    item.Idconsulta = data.GetInt32(3);
                    item.Datahistorico = data.GetString(4);
                    item.Informacao = data.GetString(5);

                    Listaprontuarios.Add(item);

                }

                data.Close();
                BancodeDados.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return Listaprontuarios;
        }


        //Buscar um unico laudo pela sua ID
        public Prontuario BuscarProntuarioID(int _IdProntuario)
        {
            Prontuario prontuario = null;

            try
            {
                string sql = string.Format("SELECT IdReceituario, IdLaudo, IdConsulta, DataHistorico, Inf FROM Prontuario WHERE Id={0}", _IdProntuario);
                SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                while (data.Read())
                {
                    prontuario = new Prontuario();

                    prontuario.Id = data.GetInt32(0);
                    prontuario.Idreceituario = data.GetInt32(1);
                    prontuario.Idlaudo = data.GetInt32(2);
                    prontuario.Idconsulta = data.GetInt32(3);
                    prontuario.Datahistorico = data.GetString(4);
                    prontuario.Informacao = data.GetString(5);

                }

                data.Close();
                BancodeDados.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return prontuario;
        }
    }
}
