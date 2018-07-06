using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    /// <summary>
    /// Interface Calculadora
    /// </summary>
    public interface ICalculadora
    {
        /// <summary>
        /// Sumas the specified num1 and num2.
        /// </summary>
        /// <param name="num1">The num1.</param>
        /// <param name="num2">The num2.</param>
        /// <returns></returns>
        int Suma(int num1, int num2);
        /// <summary>
        /// Restas the specified num1 and num2.
        /// </summary>
        /// <param name="num1">The num1.</param>
        /// <param name="num2">The num2.</param>
        /// <returns></returns>
        int Resta(int num1, int num2);
        /// <summary>
        /// Multiplicacions the specified num1 and num2.
        /// </summary>
        /// <param name="num1">The num1.</param>
        /// <param name="num2">The num2.</param>
        /// <returns></returns>
        int Multiplicacion(int num1, int num2);
        /// <summary>
        /// Divisions the specified num1 and num2.
        /// </summary>
        /// <param name="num1">The num1.</param>
        /// <param name="num2">The num2.</param>
        /// <returns></returns>
        int Division(int num1, int num2);
    }
}
