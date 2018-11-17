using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class Prontuario
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int idreceituario;

        public int Idreceituario
        {
            get { return idreceituario; }
            set { idreceituario = value; }
        }

        private int idconsulta;

        public int Idconsulta
        {
            get { return idconsulta; }
            set { idconsulta = value; }
        }

        private int idlaudo;

        public int Idlaudo
        {
            get { return idlaudo; }
            set { idlaudo = value; }
        }

        private String datahistorico;

        public String Datahistorico
        {
            get { return datahistorico; }
            set { datahistorico = value; }
        }

        

        private String informacao;

        public String Informacao
        {
            get { return informacao; }
            set { informacao = value; }
        }

    }
}
