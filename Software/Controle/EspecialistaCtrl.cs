using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Dados;

namespace Controle
{
    public class EspecialistaCtrl
    {


        public void InserirEspecialista(Especialista _especialista)
        {
            try
            {
                EspecialistaDados dados = new EspecialistaDados();

                dados.InserirEspecialista(_especialista);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public void DeletarEspecialista(int _IdEspecialista)
        {
            try
            {
                EspecialistaDados dados = new EspecialistaDados();

                dados.DeletarEspecialista(_IdEspecialista);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

        public void AtualizarEspecialista(Especialista _especialista)
        {
            try
            {
                EspecialistaDados dados = new EspecialistaDados();

                dados.AtualizarEspecialista(_especialista);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public List<Especialista> BuscarTodosEspecialistas()
        {
            try
            {
                EspecialistaDados dados = new EspecialistaDados();
                return dados.BuscarTodosEspecialistas();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


        public Especialista BuscarEspecialistaID(int _IdEspecialista)
        {
            try
            {
                EspecialistaDados dados = new EspecialistaDados();
                return dados.BuscarEspecialistaID(_IdEspecialista);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public Especialista BuscarLoginUsername(String _nomeusuario)
        {
            try
            {
                EspecialistaDados dao = new EspecialistaDados();
                return dao.BuscarLoginUsername(_nomeusuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Especialista BuscarDadosLogin(String _nome, String _senha)
        {
            try
            {
                EspecialistaDados dao = new EspecialistaDados();
                return dao.BuscarDadosLogin(_nome, _senha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

