using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Paciente
    {
        #region Variáveis e Propriedades do Paciente
    
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private String usuario;

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private String senha;

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }
       
        private String nomecompleto;

        public String NomeCompleto
        {
            get { return nomecompleto; }
            set { nomecompleto = value; }
        }

        private String telefone;

        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private String celular;

        public String Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
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

        private String idade;

        public String Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        private String peso;

        public String Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        private String tiposanguineo;

        public String Tiposanguineo
        {
            get { return tiposanguineo; }
            set { tiposanguineo = value; }
        }

        private String tipoconvenio;

        public String Tipoconvenio
        {
            get { return tipoconvenio; }
            set { tipoconvenio = value; }
        }

        private String nplanodesaude;

        public String Nplanodesaude
        {
            get { return nplanodesaude; }
            set { nplanodesaude = value; }
        }
        private String datavalidadeplano;

        public String Datavalidadeplano
        {
            get { return datavalidadeplano; }
            set { datavalidadeplano = value; }
        }

        private bool pacienteespecial;

        public bool Pacienteespecial
        {
            get { return pacienteespecial; }
            set { pacienteespecial = value; }
        }

 
        private String endereco;

        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        private String estado;

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private String cidade;

        public String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        private String sexo;

        public String Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        private String estadocivil;

        public String Estadocivil
        {
            get { return estadocivil; }
            set { estadocivil = value; }
        }
        private String nomepai;

        public String Nomepai
        {
            get { return nomepai; }
            set { nomepai = value; }
        }
        private String nomemae;

        public String Nomemae
        {
            get { return nomemae; }
            set { nomemae = value; }
        }
        private String obs;

        public String Obs
        {
            get { return obs; }
            set { obs = value; }
        }

        List<Consulta> listaconsulta;

        internal List<Consulta> Listaconsulta
        {
            get { return listaconsulta; }
            set { listaconsulta = value; }
        }

        #endregion

    }
}
