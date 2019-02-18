using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dtFimPagto = new DateTime(2017,02,18);
            DateTime dtCorrente = DateTime.Now;

            TimeSpan diferenca = dtFimPagto - dtCorrente;

            Console.WriteLine(diferenca.Humanize(2));
            Console.WriteLine(diferenca.Humanize(3));
            Console.WriteLine(diferenca.Humanize(4));
            Console.ReadLine();
        }
    }
}
