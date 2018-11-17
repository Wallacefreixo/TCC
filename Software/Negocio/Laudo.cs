using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Laudo
    {
       /* NÃO VOU USAR CHAVE ESTRANGEIRAS
        Consulta dados;

        internal Consulta Dados
        {
            get { return dados; }
            set { dados = value; }
        }
       */
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int idconsulta;

        public int Idconsulta
        {
            get { return idconsulta; }
            set { idconsulta = value; }
        }

        private String nomepaciente;

        public String Nomepaciente
        {
            get { return nomepaciente; }
            set { nomepaciente = value; }
        }


        private String cpfpaciente;

        public String Cpfpaciente
        {
            get { return cpfpaciente; }
            set { cpfpaciente = value; }
        }
        private String rgpaciente;

        public String Rgpaciente
        {
            get { return rgpaciente; }
            set { rgpaciente = value; }
        }

        private int idexame;

        public int Idexame
        {
            get { return idexame; }
            set { idexame = value; }
        }


        private String medicoresp;

        public String Medicoresp
        {
            get { return medicoresp; }
            set { medicoresp = value; }
        }

        private String data;

        public String Data
        {
            get { return data; }
            set { data = value; }
        }
        private String nomeexame;

        public String Nomeexame
        {
            get { return nomeexame; }
            set { nomeexame = value; }
        }

        private String obs;

        public String Obs
        {
            get { return obs; }
            set { obs = value; }
        }



    }
}
