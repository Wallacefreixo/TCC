using Dados;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class ProntuarioCtrl
    {

        public void InserirProntuario(Prontuario _prontuario)
        {
            try
            {
                ProntuarioDados dados = new ProntuarioDados();

                dados.InserirProntuario(_prontuario);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public void DeletarProntuario(int _IdProntuario)
        {
            try
            {
                ProntuarioDados dados = new ProntuarioDados();

                dados.DeletarProntuario(_IdProntuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

        public void AtualizarProntuario(Prontuario _prontuario)
        {
            try
            {
                ProntuarioDados dados = new ProntuarioDados();

                dados.AtualizarProntuario(_prontuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public List<Prontuario> BuscarTodosProntuarios()
        {
            try
            {
                ProntuarioDados dados = new ProntuarioDados();
                return dados.BuscarTodosProntuarios();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


        public Prontuario BuscarProntuarioID(int _IdProntuario)
        {
            try
            {
                ProntuarioDados dados = new ProntuarioDados();
                return dados.BuscarProntuarioID(_IdProntuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
