using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        private Numeros numeros;

        public Form1()
        {
            InitializeComponent();
            numeros = new Numeros(); // Inicializa la clase Numeros
        }

        // Evento del botón Agregar, ejecutado cuando el usuario agrega un número
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero;

            // Verifica si el texto ingresado es un número válido
            if (int.TryParse(txtNumero.Text, out numero))
            {
                // Si el número es negativo, muestra los resultados
                if (numero < 0)
                {
                    Resultados();
                }
                else
                {
                    // Agrega el número a la lista y limpia el campo de texto
                    numeros.AddNumero(numero);
                    txtNumero.Clear();
                    txtNumero.Focus();
                }
            }
            else
            {
                // Si no es válido, muestra un mensaje de error
                MessageBox.Show("Ingrese un número válido.");
                txtNumero.Clear();
                txtNumero.Focus();
            }
        }

        // Método para mostrar la suma, el mayor y el menor de los números
        private void Resultados()
        {
            // Verifica si hay números ingresados
            if (numeros.HayNumeros())
            {
                int suma = numeros.Suma();   // Calcula la suma de los números
                int mayor = numeros.Mayor(); // Obtiene el número mayor
                int menor = numeros.Menor(); // Obtiene el número menor

                // Muestra los resultados en la etiqueta
                lblResultados.Text = $"Suma de los números: {suma}\nNúmero Mayor: {mayor}\nNúmero Menor: {menor}";
            }
            else
            {
                lblResultados.Text = "No hay números registrados."; // Mensaje si no hay números
            }
        }

        // Eventos para manejar clics en etiquetas y cambios en el TextBox
        private void lblResultado_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void txtNumero_TextChanged(object sender, EventArgs e) { }
        private void lblResultados_Click(object sender, EventArgs e) { }
    }
}

