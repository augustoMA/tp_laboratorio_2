using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            if (operador != "-" && operador != "/" && operador != "*")
            {
                operador = "+";
            }

            return operador;
        }

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double aux = 0;

            operador = ValidarOperador(operador);

            switch (operador)
            {
                case "+":
                    aux = num1 + num2;
                    break;
                case "-":
                    aux = num1 - num2;
                    break;
                case "/":
                    aux = num1 / num2;
                    break;
                case "*":
                    aux = num1 * num2;
                    break;
                default:
                    aux = 0;
                    break;
            }

            return aux;
        }
    }

    public class Numero
    {
        private double numero;

        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        public Numero() : this(0)
        {

        }

        public Numero(double numDbl)
        {
            this.numero = numDbl;
        }

        public Numero(string numStr)
        {
            this.SetNumero = numStr;
        }

        private static double ValidarNumero(string numero)
        {
            double aux = 0;

            double.TryParse(numero, out aux);

            return aux;
        }

        public static string BinarioDecimal(string numBinario)
        {
            double aux = 0;
            string auxR = "";
            int i;

            for (i = numBinario.Length; i > 0; i--)
            {
                if (numBinario[i - 1] == 49)
                {
                    aux += Math.Pow(2, numBinario.Length - i);
                }
            }

            if (aux >= 0)
            {
                auxR = aux.ToString();
            }
            else
            {
                auxR = "El valor no es valido";
            }

            return auxR;
        }

        public static string DecimalBinario(string numDecimal)
        {
            double aux = 0;

            aux = Numero.ValidarNumero(numDecimal);

            return Numero.DecimalBinario(aux);
        }

        public static string DecimalBinario(double numDecimal)
        {
            string aux = "";

            if (numDecimal > 0)
            {
                while (numDecimal >= 1)
                {
                    if (numDecimal % 2 == 0)
                    {
                        aux = "0" + aux;
                    }
                    else
                    {
                        aux = "1" + aux;
                    }

                    numDecimal = (int)numDecimal / 2;
                }
            }
            else if (numDecimal == 0)
            {
                aux = "0";
            }
            else
            {
                aux = "El valor no es valido";
            }

            return aux;
        }

        public static double operator -(Numero num1, Numero num2)
        {
            double aux = 0;

            aux = num1.numero - num2.numero;

            return aux;
        }

        public static double operator +(Numero num1, Numero num2)
        {
            double aux = 0;

            aux = num1.numero + num2.numero;

            return aux;
        }

        public static double operator /(Numero num1, Numero num2)
        {
            double aux = 0;

            if (num2.numero != 0)
            {
                aux = num1.numero / num2.numero;
            }

            return aux;
        }

        public static double operator *(Numero num1, Numero num2)
        {
            double aux = 0;

            aux = num1.numero * num2.numero;

            return aux;
        }
    }
}
