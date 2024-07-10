/*
    Software para testar Entradas e Saídas da Linguagem C#
    Caio Teraoka
    09/07/2024

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradasSaidas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string anoNascimento;
            string anoAtual;

            Console.Write("Digite seu nome: ");
            userName = Console.ReadLine();
            Console.Write("Digite o ano em que você nasceu: ");
            anoNascimento = Console.ReadLine();
            Console.Write("Digite o ano atual: ");
            anoAtual = Console.ReadLine();

            Console.WriteLine($"Bem-vindo(a), {userName}!, sua idade é {int.Parse(anoAtual) - int.Parse(anoNascimento)} anos");

            Console.ReadLine();
        } // end Main
    }// end class
} // end namespace
