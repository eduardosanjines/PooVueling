using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    /// <summary>
    /// Class of the Calculadora
    /// </summary>
    /// <seealso cref="PooVueling.ICalculadora" />
    /// <seealso cref="System.ICloneable" />
    public class Calculadora : ICalculadora
    {
        /// <summary>
        /// División de num1 y num2.
        /// </summary>
        /// <param name="num1">The num1.</param>
        /// <param name="num2">The num2.</param>
        /// <returns>Resultado de la division</returns>
        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        /// <summary>
        /// Multiplicacions the specified num1.
        /// </summary>
        /// <param name="num1">The num1.</param>
        /// <param name="num2">The num2.</param>
        /// <returns>Resultado de la multiplicación</returns>
        public int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// Restas the specified num1.
        /// </summary>
        /// <param name="num1">The num1.</param>
        /// <param name="num2">The num2.</param>
        /// <returns></returns>
        public int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// Sumas the specified num1.
        /// </summary>
        /// <param name="num1">The num1.</param>
        /// <param name="num2">The num2.</param>
        /// <returns></returns>
        public int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}
