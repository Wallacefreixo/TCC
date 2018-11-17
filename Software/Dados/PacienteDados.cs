using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using System.Data.SqlServerCe;

namespace Dados
{
    public class PacienteDados //Objeto de acesso a dados
    {
       
        //Inserir paciente no banco de dados
        public void InserirPaciente(Paciente _paciente)
        {
            try
            {
                string sql = String.Format("INSERT INTO Paciente (Usuario, Senha, Nome, Telefone, Celular, Cpf, Rg, Idade, TipoSanguineo, TipoConvenio, NumeroPlano, DataValidadePlano, Endereco, Cidade, Estado, EspecialPaciente, Sexo, EstadoCivil, NomePai, NomeMae, Obs, Email) VALUES ('{0}', '{1}', '{2}', '{3}' , '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}' , '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}')",
                    _paciente.Usuario,
                    _paciente.Senha,
                    _paciente.NomeCompleto,
                    _paciente.Telefone,
                    _paciente.Celular, 
                    _paciente.Cpf, 
                    _paciente.Rg,
                    _paciente.Idade, 
                    _paciente.Tiposanguineo,
                    _paciente.Tipoconvenio,
                    _paciente.Nplanodesaude,
                    _paciente.Datavalidadeplano,
                    _paciente.Endereco, 
                    _paciente.Cidade,
                    _paciente.Estado,
                    _paciente.Pacienteespecial,
                    _paciente.Sexo,
                    _paciente.Estadocivil,
                    _paciente.Nomepai,
                    _paciente.Nomemae,
                    _paciente.Obs,
                    _paciente.Email);

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
             
        //Deletar paciente no banco de dados
        public void DeletarPaciente(int _IdPaciente)
        {
            try
            {
                string sql = String.Format("DELETE FROM Paciente WHERE Id={0}", _IdPaciente);

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            
            }
        
        }

        //Atualizar paciente no banco de dados
        public void AtualizarPaciente(Paciente _paciente)
        {
            try
            {
                string sql = String.Format("UPDATE Paciente SET Usuario='{0}', Senha='{1}', Nome ='{2}', Telefone ='{3}', Celular ='{4}', Cpf ='{5}', Rg ='{6}', Idade ='{7}', TipoSanguineo ='{8}', TipoConvenio='{9}',  NumeroPlano ='{10}', DataValidadePlano='{11}', Endereco ='{12}', Cidade ='{13}', Estado ='{14}', EspecialPaciente ='{15}', Sexo ='{16}', EstadoCivil ='{17}',NomePai='{18}', NomeMae='{19}', Obs='{20}', Email='{21}' WHERE Id ={22}",
                     _paciente.Usuario,
                    _paciente.Senha,
                    _paciente.NomeCompleto,
                    _paciente.Telefone,
                    _paciente.Celular, 
                    _paciente.Cpf, 
                    _paciente.Rg,
                    _paciente.Idade, 
                    _paciente.Tiposanguineo,
                    _paciente.Tipoconvenio,
                    _paciente.Nplanodesaude,
                    _paciente.Datavalidadeplano,
                    _paciente.Endereco, 
                    _paciente.Cidade,
                    _paciente.Estado,
                    _paciente.Pacienteespecial,
                    _paciente.Sexo,
                    _paciente.Estadocivil,
                    _paciente.Nomepai,
                    _paciente.Nomemae,
                    _paciente.Obs,
                    _paciente.Email,
                    _paciente.Id);

                BancodeDados.ExecutarSQLAlter(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //Buscar todos os pacientes no banco de dados
        public List<Paciente> BuscarTodosPacientes()
        {
            List<Paciente> ListaPacientes = new List<Paciente>();

            try
            {
                string sql = string.Format("SELECT Id, Usuario, Senha, Nome, Telefone, Celular, Cpf, Rg, Idade, TipoSanguineo, TipoConvenio, NumeroPlano, DataValidadePlano, Endereco, Cidade, Estado, EspecialPaciente, Sexo, EstadoCivil, NomePai, NomeMae, Obs, Email FROM Paciente");
                SqlCeDataReader data = BancodeDados.ExecutarSelect(sql);

                while (data.Read())
                {
                    Paciente item = new Paciente();

                    item.Id = data.GetInt32(0);
                    item.Usuario = data.GetString(1);
                    item.Senha = data.GetString(2);
                    item.NomeCompleto = data.GetString(3);
                    item.Telefone = data.GetString(4);
                    item.Celular = data.GetString(5);
                    item.Cpf = data.GetString(6);
                    item.Rg = data.GetString(7);
                    item.Idade = data.GetString(8);
                    item.Tiposanguineo = data.GetString(9);
                    item.Tipoconvenio = data.GetString(10);
                    item.Nplanodesaude = data.GetString(11);
                    item.Datavalidadeplano = data.GetString(12);
                    item.Endereco = data.GetString(13);
                    item.Cidade = data.GetString(14);
                    item.Estado = data.GetString(15);
                    item.Pacienteespecial = data.GetBoolean(16);
                    item.Sexo = data.GetString(17);
                    item.Estadocivil = data.GetString(18);
                    item.Nomepai = data.GetString(19);
                    item.Nomemae = data.GetString(20);
                    item.Obs = data.GetString(21);
                    item.Email = data.GetString(22);



                    ListaPacientes.Add(item);
                }

                data.Close();
                BancodeDados.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return ListaPacientes;
        }


        //Buscar um unico paciente pela sua ID
        public Paciente BuscarPacienteID(int _IdPaciente)
        {
            Paciente paciente = null;

            try
            {

                string sql = string.Format("SELECT Id, Usuario, Senha, Nome, Telefone, Celular, Cpf, Rg, Idade, TipoSanguineo, TipoConvenio, NumeroPlano, DataValidadePlano, Endereco, Cidade, Estado, EspecialPaciente, Sexo, EstadoCivil, NomePai, NomeMae, Obs, Email FROM Paciente WHERE Id={0}", _IdPaciente);
                SqlCeDataReader data = BancodeDados.Executar2Select(sql);

                while (data.Read())
                {
                    paciente = new Paciente();

                    paciente.Id = data.GetInt32(0);
                    paciente.Usuario = data.GetString(1);
                    paciente.Senha = data.GetString(2);
                    paciente.NomeCompleto = data.GetString(3);
                    paciente.Telefone = data.GetString(4);
                    paciente.Celular = data.GetString(5);
                    paciente.Cpf = data.GetString(6);
                    paciente.Rg = data.GetString(7);
                    paciente.Idade = data.GetString(8);
                    paciente.Tiposanguineo = data.GetString(9);
                    paciente.Tipoconvenio = data.GetString(10);
                    paciente.Nplanodesaude = data.GetString(11);
                    paciente.Datavalidadeplano = data.GetString(12);
                    paciente.Endereco = data.GetString(13);
                    paciente.Cidade = data.GetString(14);
                    paciente.Estado = data.GetString(15);
                    paciente.Pacienteespecial = data.GetBoolean(16);
                    paciente.Sexo = data.GetString(17);
                    paciente.Estadocivil = data.GetString(18);
                    paciente.Nomepai = data.GetString(19);
                    paciente.Nomemae = data.GetString(20);
                    paciente.Obs = data.GetString(21);
                    paciente.Email = data.GetString(22);
                }

                data.Close();
                BancodeDados.Fechar2Conexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return paciente;
        }



        public void AtualizarPaciente()
        {
            throw new NotImplementedException();
        }
    }
}
