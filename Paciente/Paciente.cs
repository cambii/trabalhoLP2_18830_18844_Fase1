using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Paciente
{
    public class Pessoa
    {
        #region Atributos

        int idade;
        int altura;
        int peso;
        string nome;
        string morada;
        string regiao;
        bool infetado;
        string aux, aux2;
        bool sexo;


        #endregion

        #region Atributos de Classe

        const int MAX = 10;
        static Pessoa[] pess = new Pessoa[MAX];
        static int numPess = 0;

        #endregion

        #region Metodos de Classe

        public static bool ExistePessoa(string nome)
        {
            for (int i = 0; i < numPess; i++)
            {
                if (pess[i].Nome.CompareTo(nome) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static int InserePessoa(Pessoa p)
        {
            
            if (numPess >= MAX) return 0;

            if (ExistePessoa(p.Nome)) return 0;

            pess[numPess++] = p;
            return 1;
        }

        #endregion


        #region Construtores

        public Pessoa(string nome, int idade, int altura, int peso, string morada, string regiao, bool infetado, bool sexo)
        {
            this.idade = idade;
            this.nome = nome;
            this.morada = morada;
            this.regiao = regiao;
            this.altura = altura;
            this.peso = peso;
            this.infetado = infetado;
            this.sexo = sexo;
        }

        #endregion

        #region Propriedades

        public int Idade
        {
            get { return idade; }
            set { if (value > 0) idade = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        public string Regiao
        {
            get { return regiao; }
            set { regiao = value; }
        }

        public int Altura
        {
            get { return altura; }
            set { if (value > 0) idade = value; }
        }

        public int Peso
        {
            get { return peso; }
            set { if (value > 0) idade = value; }
        }

        public bool Infetado
        {
            get { return infetado; }
            set { infetado = value; }
        }

        public bool Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }


        #endregion


        #region OVERRIDES

        public override bool Equals(Object obj)
        {
            return (this.nome == ((Pessoa)obj).nome);
        }

        public override string ToString()
        {
            if (infetado) aux = "Infetado";

            else aux = "Não infetado";

            if (sexo) aux2 = "Feminino";

            else aux2 = "Masculino";

                return string.Format("\tNome -> {0} \n \tIdade -> {1} \n \tAltura -> {2}cm \n \tPeso -> {3}kg \n \tMorada -> {4} \n \tRegião -> {5} \n \tStatus -> {6} \n \tSexo -> {7}\n \n", Nome, Idade, Altura, Peso, Morada, Regiao, aux, aux2);
        }
        #endregion
    }


}
