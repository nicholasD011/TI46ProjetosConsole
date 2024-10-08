using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha um exercicío da lista01: ");
           
            Lista01 lista01 = new Lista01();

            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    lista01.Exercicio01();
                    break;
                    case 2:
                    lista01.Exercicio02();
                    break;
                    case 3:
                    lista01.Exercicio03();
                    break;
                    case 4:
                    lista01.Exercicio04();
                    break;
                    case 5:
                    lista01.Exercicio05();
                    break;
                    case 6:
                    lista01.Exercicio06();
                    break;
                    case 7:
                    lista01.Exercicio07();
                    break;
                    case 8:
                    lista01.Exercicio08();
                    break;
                    case 9:
                    lista01.Exercicio09();
                    break;
                    case 10:
                    lista01.Exercicio10();
                    break;
                    
                    

            }


        }
    }
}
