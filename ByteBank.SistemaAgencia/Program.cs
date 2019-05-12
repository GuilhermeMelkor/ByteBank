using ByteBank.Modelos;
using System;
using System.Collections.Generic;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            idades.AdicionarVarios(1, 5, 14, 25, 38, 61);

            List<string> nomes = new List<string>();
            nomes.AdicionarVarios("Adoniran", "Jimi Hendrix");

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            Console.ReadLine();
        }
    }
}
