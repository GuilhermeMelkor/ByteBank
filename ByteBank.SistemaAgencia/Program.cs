using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> idades = new Lista<int>();

            idades.AdicionarVarios(1, 15, 51, 56);
            idades.Remover(15);
            idades.EscreverListaNaTela();
            Lista<string> cursos = new Lista<string>();
            cursos.AdicionarVarios("C# Parte 1", "C# Parte 2", "C# Parte 3");
            cursos.EscreverListaNaTela();

            Lista<ContaCorrente> contas = new Lista<ContaCorrente>();
            contas.AdicionarVarios(new ContaCorrente(124, 54354), new ContaCorrente(201, 44354));
            contas.EscreverListaNaTela();

            //ListaDeContaCorrente lista = new ListaDeContaCorrente();

            //ContaCorrente contaGui = new ContaCorrente(111, 11111);

            //lista.AdicionarVarios(
            //    new ContaCorrente(100, 40010),
            //    new ContaCorrente(101, 40011),
            //    new ContaCorrente(102, 40012),
            //    new ContaCorrente(103, 40013)
            //);
            //lista.EscreverListaNaTela();
            //lista.Remover(contaGui);
            //Console.WriteLine("Item removido");
            //lista.EscreverListaNaTela();

            //for (int i = 0; i < lista.tamanho; i++)
            //{
            //    ContaCorrente conta = lista[i];
            //    Console.WriteLine($"{conta.Agencia}/{conta.Numero}");
            //}

            Console.ReadLine();
        }
    }
}
