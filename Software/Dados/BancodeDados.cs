using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public static class BancodeDados // classe do tipo static, não precisa instanciar
    {
        // cria as variaveis e instancias de endereco do banco de dados
        static SqlCeConnection conn = new SqlCeConnection();
        static SqlCeConnection conn2 = new SqlCeConnection();
        static string strConn = @"Data Source=C:\Users\Wallace\Contacts\Desktop\Projeto Teste implementação\Bancodedados.sdf;Password=123";

        // Abre a conexão do banco
        public static void AbrirConexao()
        {
            try
            {
                conn.ConnectionString = strConn;

                if (conn != null)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                      conn.Open();
                    }

                }
                else
                {
                    conn = new SqlCeConnection();
                    conn.Open();
                }
            }
            catch(Exception ex)
            {
              throw new Exception(ex.Message);
            }
  
         }

        public static void Abrir2Conexao()
        {
            try
            {
                conn2.ConnectionString = strConn;

                if (conn2 != null)
                {
                    if (conn2.State == ConnectionState.Closed)
                    {
                        conn2.Open();
                    }

                }
                else
                {
                    conn2 = new SqlCeConnection();
                    conn2.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        // fecha a conexão do banco
        public static void FecharConexao()
        {
            try
            {
                if (conn != null)
                {
                    if (conn.State == ConnectionState.Open)
                    {
                      conn.Close();
                    }

                }
            }
            catch(Exception ex)
            {
              throw new Exception(ex.Message);
            }
        }

        public static void Fechar2Conexao()
        {
            try
            {
                if (conn2 != null)
                {
                    if (conn2.State == ConnectionState.Open)
                    {
                        conn2.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consulta ao banco 
        public static SqlCeDataReader ExecutarSelect(String _sql)
        {
            try
            {
                AbrirConexao();

                //SqlCeComand é um padrão do sql server, caso seja outro banco de dados. ex Oracle, esse padrão muda
                SqlCeCommand comando = new SqlCeCommand(_sql, conn);

                SqlCeDataReader data = comando.ExecuteReader();

                return data;

            }
            catch(Exception ex)
            {
                BancodeDados.FecharConexao();
                throw new Exception(ex.Message);
            }
        }

        public static SqlCeDataReader Executar2Select(String _sql)
        {
            try
            {
                Abrir2Conexao();

                //SqlCeComand é um padrão do sql server, caso seja outro banco de dados. ex Oracle, esse padrão muda
                SqlCeCommand comando = new SqlCeCommand(_sql, conn2);

                SqlCeDataReader data = comando.ExecuteReader();

                return data;

            }
            catch (Exception ex)
            {
                BancodeDados.Fechar2Conexao();
                throw new Exception(ex.Message);
            }
        }

        //Alteração do banco
        public static int ExecutarSQLAlter(string _sql)
        {
            int linhasAfetadas = 0;

            try
            {
                AbrirConexao();

                SqlCeCommand comando = new SqlCeCommand(_sql, conn);

                linhasAfetadas = comando.ExecuteNonQuery();

                BancodeDados.FecharConexao();
            }
            catch (Exception ex)
            {
                BancodeDados.FecharConexao();
                throw new Exception(ex.Message);
            }

          return linhasAfetadas;
        }
     }
}