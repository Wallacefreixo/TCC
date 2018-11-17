using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Consulta
    {
      /* NÃO VOU USAR CHAVE ESTRANGEIRAS  
        
       Medicos medico;

        public Medicos Medico
        {
            get { return medico; }
            set { medico = value; }
        }
        Paciente paciente;

        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        } */

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int idpaciente;

        public int Idpaciente
        {
            get { return idpaciente; }
            set { idpaciente = value; }
        }
        private int idmedico;

        public int Idmedico
        {
            get { return idmedico; }
            set { idmedico = value; }
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
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        private String celular;

        public String Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        private String telefone;

        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private String tipoconsulta;

        public String Tipoconsulta
        {
            get { return tipoconsulta; }
            set { tipoconsulta = value; }
        }



        private String medicoresp;

        public String Medicoresp
        {
            get { return medicoresp; }
            set { medicoresp = value; }
        }

        private String motivo;

        public String Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        private String data;

        public String Data
        {
            get { return data; }
            set { data = value; }
        }
        private String horario;

        public String Horario
        {
            get { return horario; }
            set { horario = value; }
        }
    
        private String status;

        public String Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
