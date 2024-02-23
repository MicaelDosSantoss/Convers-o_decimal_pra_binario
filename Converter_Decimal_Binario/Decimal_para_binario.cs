using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_Decimal_Binario
{
    internal class Decimal_para_binario
    {
        public int valor;
        private int arm;
        private int conta;
        private string valor_convert;

        public string Convert(int value)
        {
            arm = value % 2;
            Console.WriteLine("valor da conta: " + value + " Resto: " + arm);

            valor_convert = arm.ToString();

            do {
                conta = value / 2;
                arm = conta % 2;
                Console.WriteLine("valor da conta: "+conta+" Resto: "+ arm);
                valor_convert += arm.ToString();
                value = conta;
            } while (conta / 2 != 0);

            return valor_convert;
        }

    }
}
