using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest_xUnit_ConsoleAPP
{
    public class Calcul
    {
        /// <summary>
        /// Retourne le résultat de l'addition de 2 entiers
        /// </summary>
        /// <param name="nb1">int</param>
        /// <param name="nb2">int</param>
        /// <returns>int</returns>
        public int Addition(int nb1, int nb2)
        {
            checked
            {
                try
                {
                    int result = nb1 + nb2;
                    return result;
                }
                catch
                {
                    throw new OverflowException("Limite de l'entier dépassée");
                }
            }
            
            
        }

        public double Division(int a, int b)
        {
            if(b == 0)
                throw new DivideByZeroException();
            double result = (double)a / b;
            return result;
        }

        public bool EstPair(int nb)
        {
            return nb % 2 == 0;
        }
    }
}
