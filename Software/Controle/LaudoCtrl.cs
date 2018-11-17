using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Dados;

namespace Controle
{
    public class LaudoCtrl
    {


        public void InserirLaudo(Laudo _laudo)
        {
            try
            {
                LaudoDados dados = new LaudoDados();

                dados.InserirLaudo(_laudo);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public void DeletarLaudo(int _IdLaudo)
        {
            try
            {
                LaudoDados dados = new LaudoDados();

                dados.DeletarLaudo(_IdLaudo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

        public void AtualizarLaudo(Laudo _laudo)
        {
            try
            {
                LaudoDados dados = new LaudoDados();

                dados.AtualizarLaudo(_laudo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public List<Laudo> BuscarTodosLaudos()
        {
            try
            {
                LaudoDados dados = new LaudoDados();
                return dados.BuscarTodosLaudos();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


        public Laudo BuscarLaudoID(int _IdLaudo)
        {
            try
            {
                LaudoDados dados = new LaudoDados();
                return dados.BuscarLaudoID(_IdLaudo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
