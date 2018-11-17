using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using System.Data.SqlServerCe;

namespace Dados
{
    public class EspecialistaDados
    {
         //Inserir especialista no banco de dados
        public void InserirEspecialista(Especialista _especialistas)
        {
            try
            {
                string sql = String.Format("INSERT INTO Especialista (Usuario, Senha, Cpf, Rg, Telefone, Celular, Email, Sexo, Status, Obs, Idade, AreaAtuacao, Especialidade1, Especialidade2, HoraAtendimentoIni, HoraAtendimentoFim, TipoDocumentoMedico, NumeroDocumento, Uf, Situacao, TipoInscricao, AtendimentoSegunda, AtendimentoTerca, AtendimentoQuarta, AtendimentoQuinta, AtendimentoSexta, AtendimentoSabado, AtendimentoDomingo, TipoPermissao, Nome, Profissao ) VALUES ('{0}', '{1}', '{2}', '{3}' , '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}' , '{12}','{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}','{26}', '{27}', '{28}', '{29}', '{30}')", 
                    _especialistas.Usuario, 
                    _especialistas.Senha,
                    _especialistas.Cpf, 
                    _especialistas.Rg, 
                    _especialistas.Telefone, 
                    _especialistas.Celular, 
                    _especialistas.Email,  
                    _especialistas.Sexo,
                    _especialistas.Status,
                    _especialistas.Obs, 
                    _especialistas.Idade, 
                    _especialistas.Areaatuacao,
                    _especialistas.Especialidade1,
                    _especialistas.Especialidade2, 
                    _especialistas.Horaatendimentoini, 
                    _especialistas.Horaatendimentofim,
                    _especialistas.Tipodocumentomedico,
                    _especialistas.Numerodocumento, 
                    _especialistas.Uf, 
                    _especialistas.Situacao,
                    _especialistas.Tipoinscricao, 
                    _especialistas.Atendimentosegunda,
                    _especialistas.Atendimentoterca,
                    _especialistas.Atendimentoquarta, 
                    _especialistas.Atendimentoquinta, 
                    _especialistas.Atendimentosexta,
                    _especialistas.Atendimentosabado, 
                    _especialistas.Atendimentodomingo,
                    _especialistas.Tipopermissao, 
                    _especialistas.Nomecompleto, 
                    _especialistas.Profissao
                    );

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
             
        //Deletar especialista no banco de dados
        public void DeletarEspecialista(int _IdEspecialista)
        {
            try
            {
                string sql = String.Format("DELETE FROM Especialista WHERE Id={0}", _IdEspecialista);

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            
            }
        
        }

        //Atualizar especialista no banco de dados
        public void AtualizarEspecialista(Especialista _especialistas)
        {
            try
            {
                string sql = String.Format("UPDATE Especialista SET Usuario ='{0}', Senha ='{1}', Cpf ='{2}', Rg ='{3}' , Telefone ='{4}', Celular ='{5}', Email ='{6}',  Sexo ='{7}', Status ='{8}', Obs ='{9}', Idade ='{10}', AreaAtuacao ='{11}' , Especialidade1 ='{12}', Especialidade2 ='{13}', HoraAtendimentoIni ='{14}', HoraAtendimentoFim ='{15}', TipoDocumentoMedico ='{16}', NumeroDocumento ='{17}', Uf ='{18}', Situacao ='{19}', TipoInscricao ='{20}', AtendimentoSegunda ='{21}', AtendimentoTerca ='{22}', AtendimentoQuarta ='{23}', AtendimentoQuinta ='{24}', AtendimentoSexta ='{25}', AtendimentoSabado ='{26}', AtendimentoDomingo ='{27}', TipoPermissao ='{28}', Nome ='{29}', Profissao ='{30}' WHERE Id={31}",
                    _especialistas.Usuario, 
                    _especialistas.Senha,
                    _especialistas.Cpf, 
                    _especialistas.Rg, 
                    _especialistas.Telefone, 
                    _especialistas.Celular, 
                    _especialistas.Email,  
                    _especialistas.Sexo,
                    _especialistas.Status,
                    _especialistas.Obs, 
                    _especialistas.Idade, 
                    _especialistas.Areaatuacao,
                    _especialistas.Especialidade1,
                    _especialistas.Especialidade2, 
                    _especialistas.Horaatendimentoini, 
                    _especialistas.Horaatendimentofim,
                    _especialistas.Tipodocumentomedico,
                    _especialistas.Numerodocumento, 
                    _especialistas.Uf, 
                    _especialistas.Situacao,
                    _especialistas.Tipoinscricao, 
                    _especialistas.Atendimentosegunda,
                    _especialistas.Atendimentoterca,
                    _especialistas.Atendimentoquarta, 
                    _especialistas.Atendimentoquinta, 
                    _especialistas.Atendimentosexta,
                    _especialistas.Atendimentosabado, 
                    _especialistas.Atendimentodomingo,
                    _especialistas.Tipopermissao, 
                    _especialistas.Atendimentosexta,
                    _especialistas.Nomecompleto, 
                    _especialistas.Profissao,
                    _especialistas.Id
                    );

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //Buscar todos os especialistas no banco de dados
        public List<Especialista> BuscarTodosEspecialistas()
        {
            List<Especialista> ListaEspecialista = new List<Especialista>();

            try
            {
                string sql = string.Format("SELECT Id, Usuario, Senha, Cpf, Rg, Telefone, Celular, Email, Sexo, Status, Obs, Idade, AreaAtuacao, Especialidade1, Especialidade2, HoraAtendimentoIni, HoraAtendimentoFim, TipoDocumentoMedico, NumeroDocumento, Uf, Situacao, TipoInscricao, AtendimentoSegunda, AtendimentoTerca, AtendimentoQuarta, AtendimentoQuinta, AtendimentoSexta, AtendimentoSabado, AtendimentoDomingo, TipoPermissao, Nome, Profissao FROM Especialista");
                SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                while (data.Read())
                {
                    Especialista item = new Especialista();

                    item.Id = data.GetInt32(0);
                    item.Usuario = data.GetString(1);
                    item.Senha = data.GetString(2);
                    item.Cpf = data.GetString(3);
                    item.Rg = data.GetString(4);
                    item.Telefone = data.GetString(5);
                    item.Celular = data.GetString(6);
                    item.Email = data.GetString(7);
                    item.Sexo = data.GetString(8);
                    item.Status = data.GetString(9);
                    item.Obs = data.GetString(10);
                    item.Idade = data.GetString(11);
                    item.Areaatuacao = data.GetString(12);
                    item.Especialidade1 = data.GetString(13);
                    item.Especialidade2 = data.GetString(14);
                    item.Horaatendimentoini = data.GetString(15);
                    item.Horaatendimentofim = data.GetString(16);
                    item.Tipodocumentomedico = data.GetString(17);
                    item.Numerodocumento = data.GetString(18);
                    item.Uf = data.GetString(19);
                    item.Situacao = data.GetString(20);
                    item.Tipoinscricao = data.GetString(21);
                    item.Atendimentosegunda = data.GetBoolean(22);
                    item.Atendimentoterca = data.GetBoolean(23);
                    item.Atendimentoquarta = data.GetBoolean(24);
                    item.Atendimentoquinta = data.GetBoolean(25);
                    item.Atendimentosexta = data.GetBoolean(26);
                    item.Atendimentosabado = data.GetBoolean(27);
                    item.Atendimentodomingo = data.GetBoolean(28);
                    item.Tipopermissao = data.GetString(29);
                    item.Nomecompleto = data.GetString(30);
                    item.Profissao = data.GetString(31);

                    ListaEspecialista.Add(item);
                }

                data.Close();
                BancodeDados.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return ListaEspecialista;
        }


        //Buscar um unico Medico pela sua ID
        public Especialista BuscarEspecialistaID(int _IdEspecialista)
        {
            Especialista especialista = null;

            try
            {
                string sql = string.Format("SELECT Id, Usuario, Senha, Cpf, Rg, Telefone, Celular, Email, Sexo, Status, Obs, Idade, AreaAtuacao, Especialidade1, Especialidade2, HoraAtendimentoIni, HoraAtendimentoFim, TipoDocumentoMedico, NumeroDocumento, Uf, Situacao, TipoInscricao, AtendimentoSegunda, AtendimentoTerca, AtendimentoQuarta, AtendimentoQuinta, AtendimentoSexta, AtendimentoSabado, AtendimentoDomingo, TipoPermissao, Nome, Profissao FROM Especialista WHERE Id={0}", _IdEspecialista);
                SqlCeDataReader data = BancodeDados.Executar2Select(sql);

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


                }

                data.Close();
                BancodeDados.Fechar2Conexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return especialista;
        }

        public Especialista BuscarLoginUsername(String _nome)
        {
            Especialista e = null;
            try
            {
                String SQL = String.Format("SELECT Id, Usuario, TipoPermissao, Nome FROM Especialista WHERE Usuario='{0}'", _nome);
                SqlCeDataReader data = BancodeDados.ExecutarSelect(SQL);

                if (data.Read())
                {
                    e = new Especialista();

                    e.Id = data.GetInt32(0);
                    e.Usuario = data.GetString(1);
                    e.Tipopermissao = data.GetString(2);
                    e.Nomecompleto = data.GetString(3);

                }
                data.Close();
                BancodeDados.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return e;
        }

        public Especialista BuscarDadosLogin(String _nome, String _senha)
        {
            Especialista e = null;
            try
            {
                String SQL = String.Format("SELECT Id, Usuario, TipoPermissao, Nome FROM Especialista WHERE Usuario='{0}' AND Senha='{1}'", _nome, _senha);
                SqlCeDataReader data = BancodeDados.ExecutarSelect(SQL);

                if (data.Read())
                {
                    e = new Especialista();

                    e.Id = data.GetInt32(0);
                    e.Usuario = data.GetString(1);
                    e.Tipopermissao = data.GetString(2);
                    e.Nomecompleto = data.GetString(3);

                }
                data.Close();
                BancodeDados.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return e;
        }

    }
}
   
