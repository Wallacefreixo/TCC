using Dados;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class ConsultaCtrl
    {
        public void InserirConsulta(Consulta _consulta)
        {
            try
            {
                ConsultaDados dados = new ConsultaDados();

                dados.InserirConsulta(_consulta);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public void DeletarConsulta(int _IdConsulta)
        {
            try
            {
                ConsultaDados dados = new ConsultaDados();

                dados.DeletarConsulta(_IdConsulta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

        public void AtualizarConsulta(Consulta _consulta)
        {
            try
            {
                ConsultaDados dados = new ConsultaDados();

                dados.AtualizarConsulta(_consulta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public List<Consulta> BuscarTodasConsultas()
        {
            try
            {
                ConsultaDados dados = new ConsultaDados();
                return dados.BuscarTodasConsultas();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


        public Consulta BuscarConsultaID(int _IdConsulta)
        {
            try
            {
                ConsultaDados dados = new ConsultaDados();
                return dados.BuscarConsultaID(_IdConsulta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
      

    }
}
