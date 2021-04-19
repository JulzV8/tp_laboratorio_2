using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Boton Convertir Decimal a Binario. LLama a la funcion de Entidades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Entidades.Numero num1 = new Entidades.Numero(lblResultado.Text);
            lblResultado.Text = num1.DecimalBinario(lblResultado.Text);

        }

        /// <summary>
        /// Boton de cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?","ATENCION",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }

        /// <summary>
        /// Boton Convertir a Decimal. Llama a la funcion de Entidades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Entidades.Numero num1 = new Entidades.Numero(lblResultado.Text);
            lblResultado.Text = num1.BinarioDecimal(lblResultado.Text);           
        }

        /// <summary>
        /// Boton Limpiar. Llama a la funcion Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Boton Operar. Llama a la funcion Operar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string num1 = txtNumero1.Text;
            string num2 = txtNumero2.Text;
            string operador = cmbOperador.Text;
            if (operador == "")
                operador = "+";
            double resultadoDeLaCuenta = Math.Round(Operar(num1, num2, operador),3);
            string respuesta = resultadoDeLaCuenta.ToString();
            lblResultado.Text = respuesta;
        }

        /// <summary>
        /// Funcion Operar. Llama a la funcion Operar de Entidades
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Entidades.Numero num1 = new Entidades.Numero(numero1);
            Entidades.Numero num2 = new Entidades.Numero(numero2);
            return Entidades.Calculadora.Operar(num1, num2, operador);
        }

        /// <summary>
        /// Funcion que vacia el texto de los controladores
        /// </summary>
        private void Limpiar()
        {
            string vacio = "";
            txtNumero1.Text = vacio;
            txtNumero2.Text = vacio;
            cmbOperador.Text = vacio;
            lblResultado.Text = "0";
        }
    }
}
