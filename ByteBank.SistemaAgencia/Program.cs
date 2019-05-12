using ByteBank.Modelos;
using System;
using System.Collections.Generic;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var idades = new List<int>();

            idades.AdicionarVarios(1, 5, 14, 25, 38, 61);
            idades.Sort();

            var nomes = new List<string>() {
                "Adoniran", "Jimi Hendrix", "ABBA", "Ozzy"
            };
            nomes.Sort();

            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(234,243243),
                new ContaCorrente(234,243244),
                new ContaCorrente(456,234567),
                new ContaCorrente(345,245677)
            };
            contas.Sort(new ComparadorContaCorrentePorAgencia());

            foreach (var conta in contas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }


            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
            foreach (var item in idades)
            {
                Console.WriteLine(item);
            }




            Console.ReadLine();
        }
    }
}
