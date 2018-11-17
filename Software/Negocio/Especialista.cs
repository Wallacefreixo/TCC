using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class Especialista
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
        private String status;

        public String Status
        {
            get { return status; }
            set { status = value; }
        }
        private String obs;

        public String Obs
        {
            get { return obs; }
            set { obs = value; }
        }
        private String idade;

        public String Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        private String areaatuacao;

        public String Areaatuacao
        {
            get { return areaatuacao; }
            set { areaatuacao = value; }
        }
        private String especialidade1;

        public String Especialidade1
        {
            get { return especialidade1; }
            set { especialidade1 = value; }
        }
        private String especialidade2;

        public String Especialidade2
        {
            get { return especialidade2; }
            set { especialidade2 = value; }
        }
        private String horaatendimentoini;

        public String Horaatendimentoini
        {
            get { return horaatendimentoini; }
            set { horaatendimentoini = value; }
        }
        private String horaatendimentofim;

        public String Horaatendimentofim
        {
            get { return horaatendimentofim; }
            set { horaatendimentofim = value; }
        }
        private String tipodocumentomedico;

        public String Tipodocumentomedico
        {
            get { return tipodocumentomedico; }
            set { tipodocumentomedico = value; }
        }
        private String numerodocumento;

        public String Numerodocumento
        {
            get { return numerodocumento; }
            set { numerodocumento = value; }
        }
        private String uf;

        public String Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        private String situacao;

        public String Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }
        private String tipoinscricao;

        public String Tipoinscricao
        {
            get { return tipoinscricao; }
            set { tipoinscricao = value; }
        }
        private String img;

        public String Img
        {
            get { return img; }
            set { img = value; }
        }
        private bool atendimentosegunda;

        public bool Atendimentosegunda
        {
            get { return atendimentosegunda; }
            set { atendimentosegunda = value; }
        }
        private bool atendimentoterca;

        public bool Atendimentoterca
        {
            get { return atendimentoterca; }
            set { atendimentoterca = value; }
        }

        private bool atendimentoquarta;

        public bool Atendimentoquarta
        {
            get { return atendimentoquarta; }
            set { atendimentoquarta = value; }
        }
        private bool atendimentoquinta;

        public bool Atendimentoquinta
        {
            get { return atendimentoquinta; }
            set { atendimentoquinta = value; }
        }
        private bool atendimentosexta;

        public bool Atendimentosexta
        {
            get { return atendimentosexta; }
            set { atendimentosexta = value; }
        }
        private bool atendimentosabado;

        public bool Atendimentosabado
        {
            get { return atendimentosabado; }
            set { atendimentosabado = value; }
        }
        private bool atendimentodomingo;

        public bool Atendimentodomingo
        {
            get { return atendimentodomingo; }
            set { atendimentodomingo = value; }
        }
        private String tipopermissao;

        public String Tipopermissao
        {
            get { return tipopermissao; }
            set { tipopermissao = value; }
        }
        private String nomecompleto;

        public String Nomecompleto
        {
            get { return nomecompleto; }
            set { nomecompleto = value; }
        }
        private String profissao;

        public String Profissao
        {
            get { return profissao; }
            set { profissao = value; }
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
