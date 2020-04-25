using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Paciente;

namespace Pacientes
{
    public class Pessoas
    {

        #region ATRIBUTOS
        const int MAX = 10;
        static Pessoa[] pess;
        static int numPessoas = 0;
        #endregion

        #region Construtores

        static Pessoas()
        {
            pess = new Pessoa[MAX];
        }
        #endregion

        #region INDEXADORES

        public Pessoa this[int i]
        {
            get { if (i < MAX) return pess[i]; return null; }
            set { if (i < MAX) pess[i] = value; numPessoas++; }     
        }


        public Pessoa this[string nome]
        {
            get { return VerificaPessoa(nome); }       

        }

        #endregion

        #region Funcoes Auxiliares

        public static bool ExistePessoa(string nome)
        {
            for (int i = 0; i < numPessoas; i++)
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

            if (numPessoas >= MAX) return 0;

            if (ExistePessoa(p.Nome)) return 0;


            pess[numPessoas++] = p;
            return 1;
        }

        public static Pessoa GetPessoa(int id)
        {
            for (int i = 0; i < numPessoas; i++)
            {
                if (pess[i] != null && pess[i].Idade == id) return pess[i];
            }
            return null;
        }

        public static Pessoa VerificaPessoa(string nome)
        {
            for (int i = 0; i < numPessoas; i++)
            {
                if (pess[i] != null && pess[i].Nome.CompareTo(nome) == 0)
                {
                    return pess[i];
                }
            }
            return null;
        }
        #endregion

        #region Metodos

        public static void ContabilizarCasosTotais(Pessoa[] pess)
        {
            int contador = 0;

            for (int i = 0; i < numPessoas; i++)
            {
                if (pess[i].Infetado)
                {
                    contador++;
                }
            }

            Console.WriteLine("\nNumero total de infetados: {0}\n", contador);
        }

        public static void ContabilizarCasosPorRegiao(Pessoa[] pess, string regiao)
        {
            int contador = 0;

            for (int i = 0; i < numPessoas ; i++)
            {
                bool result = String.Equals(pess[i].Regiao, regiao, StringComparison.OrdinalIgnoreCase);
                
                if (result)
                {
                    Console.WriteLine(pess[i].ToString());

                    if (pess[i].Infetado){
                        contador++;
                    }
                    
                }
            }
            Console.WriteLine("\nNumero total de infetados na Região {0}: {1}\n",regiao, contador);
        }

        public static void ContabilizarCasosPorIdade(Pessoa[] pess, int idade)
        {
            int contador = 0;
            int aux = 0;

            for (int i = 0; i < numPessoas; i++)
            {
                aux = pess[i].Idade;

                

                if (aux == idade)
                {
                    Console.WriteLine(pess[i].ToString());
                    if (pess[i].Infetado)
                    {
                        contador++;
                    }

                }
            }
            Console.WriteLine("\nNumero total de infetados com {0} anos: {1}\n", idade, contador);
        }

        public static void ContabilizarCasosPorSexo(Pessoa[] pess, bool sexo)
        {

            int contador = 0;
            string aux, aux2;

            if (sexo) aux = "Feminino";
            else aux = "Masculino";




            for (int i = 0; i < numPessoas; i++)
            {

                if (pess[i].Sexo) aux2 = "Feminino";
                else aux2 = "Masculino";


                bool result = String.Equals(aux, aux2, StringComparison.OrdinalIgnoreCase);

                if (result)
                {
                    Console.WriteLine(pess[i].ToString());

                    if (pess[i].Infetado)
                    {
                        contador++;
                    }

                }
            }
            Console.WriteLine("\nNumero total de infetados do sexo {0}: {1}\n", aux, contador);


        }


        #endregion




    }


}
