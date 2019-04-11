using ByteBank.Modelos;
using System;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padrao = "[0-9]{4,5}-?[0-9]{4}";


            //string texto = "Meu número é: 923423453";

            //Match match = Regex.Match(texto, padrao);
            //Console.WriteLine(match.Value);


            //string url = "www.bytebank.com/cambio?origem=real&destino=dolar&valor=1500";

            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);

            //Console.WriteLine(extrator.GetValor("origem"));
            //Console.WriteLine(extrator.GetValor("destino"));
            //Console.WriteLine(extrator.GetValor("valor"));


            ContaCorrente contaCorrente = new ContaCorrente(342, 37652);
            Console.WriteLine(contaCorrente);

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            if (carlos_1.CPF.Equals(carlos_2.CPF))
            {
                Console.WriteLine("São iguais!");
            }


            Console.ReadLine();
        }
    }
}
