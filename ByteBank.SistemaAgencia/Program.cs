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

            idades.AdicionarVarios(1, 8, 78, 45, 49);

            //idades.Add(1);
            //idades.Add(5);
            //idades.Add(68);
            //idades.Add(84);
            //idades.Add(32);
            //idades.Add(48);
            //idades.Add(86);

            //idades.Remove(5);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            Console.ReadLine();
        }
    }
}
