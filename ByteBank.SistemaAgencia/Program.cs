using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "www.bytebank.com/cambio?origem=real&destino=dolar&valor=1500";

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);

            Console.WriteLine(extrator.GetValor("origem"));
            Console.WriteLine(extrator.GetValor("destino"));
            Console.WriteLine(extrator.GetValor("valor"));


            Console.ReadLine();
        }
    }
}
