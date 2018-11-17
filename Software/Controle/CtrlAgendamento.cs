using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Negocio;

namespace Controle
{
    public class CtrlAgendamento
    {
        public static List<Agendamento> BuscarTodos()
        {
            try
            {
              return AgendamentoDAO.BuscarTodos();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
