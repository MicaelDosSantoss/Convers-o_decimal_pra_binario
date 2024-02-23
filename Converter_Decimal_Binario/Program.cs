using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_Decimal_Binario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Decimal_para_binario d = new Decimal_para_binario();
            string valorFinal = (d.Convert(47));

            Console.WriteLine(valorFinal.Reverse().ToArray());

        }
    }
}
