using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que el caracter operador sea uno de los cuatro siguientes: + - * /
        /// </summary>
        /// <param name="operador">operador a analizar</param>
        /// <returns>Regresa el mismo operador, o + si es alguno distinto</returns>
        private static string ValidarOperador(char operador)
        {
            switch (operador)
            {
                case '-':
                    return "-";
                case '*':
                    return "*";
                case '/':
                    return "/";
                default:
                    return "+";
            }
        }
        
        /// <summary>
        /// Realiza la operacion con los numeros indicados
        /// </summary>
        /// <param name="numero1">Numero 1</param>
        /// <param name="numero2">Numero 2</param>
        /// <param name="operador">Operador (+ - * /)</param>
        /// <returns>Devuelve el resultado, en formato double</returns>
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            string auxOperador = ValidarOperador(operador.ToCharArray()[0]);
            double resultado;
            switch (auxOperador)
            {
                case "-":
                    resultado = numero1 - numero2;
                    return resultado;
                case "*":
                    resultado = numero1 * numero2;
                    return resultado;
                case "/":
                    resultado = numero1 / numero2;
                    return resultado;
                default:
                    resultado = numero1 + numero2;
                    return resultado;
            }
        }
    }
}
