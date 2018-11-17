using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Dados;

namespace Controle
{
    public class PacienteCtrl
    { 
        

        public void InserirPaciente(Paciente _paciente)
        {
            try
            {
                PacienteDados dados = new PacienteDados();

                dados.InserirPaciente(_paciente);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public void DeletarPaciente(int _IdPaciente)
        {
            try
            {
                PacienteDados dados = new PacienteDados();

                dados.DeletarPaciente(_IdPaciente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

        public void AtualizarPaciente(Paciente _paciente)
        {
            try
            {
                PacienteDados dados = new PacienteDados();

                dados.AtualizarPaciente(_paciente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public List<Paciente> BuscarTodosPacientes()
        {
            try
            {
                PacienteDados dados = new PacienteDados();
                return dados.BuscarTodosPacientes();
               

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


        public Paciente BuscarPacienteID(int _IdPaciente)
        {
            try
            {
                PacienteDados dados = new PacienteDados();
                return dados.BuscarPacienteID(_IdPaciente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


       
    }
}
