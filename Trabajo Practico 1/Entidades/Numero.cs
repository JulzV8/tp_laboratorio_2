using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos

        private double numero;
        #endregion

        #region Propiedades

        public string SetNumero
        {
            set
            {
                double valor = 0;
                valor = ValidarNumero(value);
                if (valor != 0)
                {
                    this.numero = valor;
                } 
            }
        }
        #endregion

        #region Constructores

        public Numero()
        {
            numero = 0;
        }

        public Numero(double numero): this()
        {
            this.numero = numero;
        }

        public Numero(string strNumero): this()
        {
            this.SetNumero = strNumero;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Valida que la cadena sea un numero
        /// </summary>
        /// <param name="strNumero">cadena a analizar</param>
        /// <returns>Devuelve el numero en formato double, 0 si no es un numero valido</returns>
        private double ValidarNumero(string strNumero)
        {
            double miNumero = 0;
            Double.TryParse(strNumero, out miNumero);
            return miNumero;

        }

        /// <summary>
        /// Verifica que la cadena sea binaria
        /// </summary>
        /// <param name="binario">cadena</param>
        /// <returns>devuelve TRUE/FALSE</returns>
        private bool EsBinaria(string binario)
        {
            bool resultado = true;
            foreach (var item in binario)
            {
                if(item != '0' && item != '1')
                {
                    resultado = false;
                    break;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Pasa la cadena, si es posible, de binario a decimal
        /// </summary>
        /// <param name="binario"> cadena</param>
        /// <returns>Devuelve cadena decimal. "Valor Invalido" fallo</returns>
        public string BinarioDecimal(string binario)
        {
            int auxNumero;
            if(binario != "0" && EsBinaria(binario))
            {
                auxNumero = Convert.ToInt32(binario, 2);
                return Convert.ToString(auxNumero);
            }
            else
            {
                return "Valor Inválido";
            }
        }

        /// <summary>
        /// Pasa el numero de decimal a binario
        /// </summary>
        /// <param name="numero">double</param>
        /// <returns>Devuelve binario como cadena. 0 si fallo</returns>
        public string DecimalBinario(double numero)
        {
            int auxNumero = Convert.ToInt32(numero);
            if(auxNumero<0)
            {
                auxNumero = auxNumero * -1;
            }
            string resultado = Convert.ToString(auxNumero, 2);
            return resultado;
        }

        /// <summary>
        /// Pasa una cadena decimal a binario
        /// </summary>
        /// <param name="numero">cadena del numero</param>
        /// <returns>devuelve cadena con el numero, Valor Invalido si fallo</returns>
        public string DecimalBinario(string numero)
        {
            int auxNumero = 0;
            Int32.TryParse(numero, out auxNumero);
            if(auxNumero != 0)
            {
                return DecimalBinario(auxNumero);
            }
            else
            {
                return "Valor Inválido";
            }
        }
        #endregion

        #region Operadores

        public static double operator +(Numero num1, Numero num2)
        {
            double numero1 = num1.numero;
            double numero2 = num2.numero;
            return numero1 + numero2;
        }

        public static double operator -(Numero num1, Numero num2)
        {
            double numero1 = num1.numero;
            double numero2 = num2.numero;
            return numero1 - numero2;
        }

        public static double operator /(Numero num1, Numero num2)
        {
            double numero1 = num1.numero;
            double numero2 = num2.numero;
            return numero1 / numero2;
        }

        public static double operator *(Numero num1, Numero num2)
        {
            double numero1 = num1.numero;
            double numero2 = num2.numero;
            if(numero2 != 0)
            {
                return numero1 * numero2;
            }
            else
            {
                return double.MinValue;
            }
        }
        #endregion

    }
}
