using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Agendamento
    {
        public Paciente Paciente { get; set;}
        public Especialista Especialista { get; set; }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
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
