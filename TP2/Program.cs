using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paciente;
using Pacientes;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {

            const int MAX = 10;
            int numPessoa = 0;
            string opcaoReg;
            int opcaoIdade;
            int opcaoSexo;

            Pessoa[] pess = new Pessoa[MAX];


            Pessoa p1 = new Pessoa("Carlos", 18, 180, 69, "Guimaraes", "Norte", false, false);
            Pessoa p2 = new Pessoa("Diogo", 20 , 182, 95, "Viana do Castelo", "Norte", false, false);
            Pessoa p3 = new Pessoa("Zé", 55, 200, 140, "Algarve", "Sul", true, false);
            Pessoa p4 = new Pessoa("Maria", 25, 165, 64, "Porto", "Sul", true, true);
            Pessoa p5 = new Pessoa("Rita", 18, 165, 59, "Bairro", "Centro", true, true);


            if (Pessoas.InserePessoa(p1) == 1)
            {
                pess[numPessoa] = p1;
                numPessoa++;
            }
            if (Pessoas.InserePessoa(p2) == 1)
            {
                pess[numPessoa] = p2;
                numPessoa++;
            }
            if (Pessoas.InserePessoa(p3) == 1)
            {
                pess[numPessoa] = p3;
                numPessoa++;
            }
            if (Pessoas.InserePessoa(p4) == 1)
            {
                pess[numPessoa] = p4;
                numPessoa++;
            }
            if (Pessoas.InserePessoa(p5) == 1)
            {
                pess[numPessoa] = p5;
                numPessoa++;
            }


            Console.WriteLine("\tFICHA DE PACIENTES\n");
            Console.WriteLine(pess[0].ToString() +pess[1].ToString() +pess[2].ToString() + pess[3].ToString() + pess[4].ToString());

            Pessoas.ContabilizarCasosTotais(pess);
            Console.WriteLine("Indique a região que pretende contabilizar: ");
            opcaoReg = Console.ReadLine();
            Pessoas.ContabilizarCasosPorRegiao(pess, opcaoReg);

            Console.WriteLine("Indique a idade que pretende contabilizar: ");
            opcaoIdade = int.Parse(Console.ReadLine());
            Pessoas.ContabilizarCasosPorIdade(pess, opcaoIdade);

            Console.WriteLine("Indique o sexo que pretende contabilizar: ");
            Console.WriteLine("1 - Feminino | 2 - Masculino");
            opcaoSexo = int.Parse(Console.ReadLine());
            if (opcaoSexo == 1) Pessoas.ContabilizarCasosPorSexo(pess, true);
            else Pessoas.ContabilizarCasosPorSexo(pess, false);






            Console.ReadKey();



        }
    }
}
