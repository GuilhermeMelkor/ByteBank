using System;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";


            string texto = "Meu número é: 923423453";

            Match match = Regex.Match(texto, padrao);
            Console.WriteLine(match.Value);


            //string url = "www.bytebank.com/cambio?origem=real&destino=dolar&valor=1500";

            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);

            //Console.WriteLine(extrator.GetValor("origem"));
            //Console.WriteLine(extrator.GetValor("destino"));
            //Console.WriteLine(extrator.GetValor("valor"));


            Console.ReadLine();
        }
    }
}
