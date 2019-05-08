using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {


            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaGui = new ContaCorrente(111, 11111);

            lista.AdicionarVarios(
                new ContaCorrente(100, 40010),
                new ContaCorrente(101, 40011),
                new ContaCorrente(102, 40012),
                new ContaCorrente(103, 40013)
            );
            //lista.EscreverListaNaTela();
            //lista.Remover(contaGui);
            //Console.WriteLine("Item removido");
            //lista.EscreverListaNaTela();

            for (int i = 0; i < lista.tamanho; i++)
            {
                ContaCorrente conta = lista[i];
                Console.WriteLine($"{conta.Agencia}/{conta.Numero}");
            }

            Console.ReadLine();
        }
    }
}
