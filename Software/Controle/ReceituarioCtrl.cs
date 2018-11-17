using Dados;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class ReceituarioCtrl
    {
        public void InserirReceituario(Receituario _receituario)
        {
            try
            {
                ReceituarioDados dados = new ReceituarioDados();

                dados.InserirReceituario(_receituario);

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
                ReceituarioDados dados = new ReceituarioDados();

                dados.DeletarReceituario(_IdReceituario);
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
                ReceituarioDados dados = new ReceituarioDados();

                dados.AtualizarReceituario(_receituario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public List<Receituario> BuscarTodosReceituarios()
        {
            try
            {
                ReceituarioDados dados = new ReceituarioDados();
                return dados.BuscarTodosReceituarios();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


        public Receituario BuscarReceituarioID(int _IdReceituario)
        {
            try
            {
                ReceituarioDados dados = new ReceituarioDados();
                return dados.BuscarReceituarioID(_IdReceituario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
