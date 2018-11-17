using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Receituario
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private String data;

        public String Data
        {
            get { return data; }
            set { data = value; }
        }
        private String nomepaciente;

        public String Nomepaciente
        {
            get { return nomepaciente; }
            set { nomepaciente = value; }
        }
        private String cpf;

        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private String rg;

        public String Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        private String nomeespecialista;

        public String Nomeespecialista
        {
            get { return nomeespecialista; }
            set { nomeespecialista = value; }
        }

        
        private int idconsulta;

        public int Idconsulta
        {
            get { return idconsulta; }
            set { idconsulta = value; }
        }

        private String obs;

        public String Obs
        {
            get { return obs; }
            set { obs = value; }
        }
        List<Medicamento> listamedicamento;

        public List<Medicamento> Listamedicamento
        {
            get { return listamedicamento; }
            set { listamedicamento = value; }
        }
        List<Exame> listaExame;

        public List<Exame> ListaExame
        {
            get { return listaExame; }
            set { listaExame = value; }
        }
    }
}
