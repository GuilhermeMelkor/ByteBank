using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {


            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaGui = new ContaCorrente(111,11111);

            lista.Adicionar(contaGui);
            lista.Adicionar(new ContaCorrente(345, 23462));
            lista.Adicionar(new ContaCorrente(363, 22451));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(345, 23462));
            lista.Adicionar(new ContaCorrente(363, 22451));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.EscreverListaNaTela();
            lista.Remover(contaGui);
            Console.WriteLine("Item removido");
            lista.EscreverListaNaTela();

            //int[] idades = new int[] {15,28,35,50,28};

            //int acumulador = 0;
            //for (int indice = 0; indice < idades.Length; indice++)
            //{
            //    acumulador += idades[indice];
            //}
            //int media = acumulador / idades.Length;
            //Console.WriteLine($"A media eh de {media}");

            Console.ReadLine();
        }
    }
}
