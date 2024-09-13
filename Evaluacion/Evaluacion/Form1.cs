using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        Numeros numeros = new Numeros(); // Instanciar la clase Numeros

        public Form1()
        {
            InitializeComponent();
        }

        // Evento para agregar números a la lista cuando se presiona el botón "Agregar"
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero;

            // Validar si el número ingresado es un número entero
            if (int.TryParse(txtNumero.Text, out numero))
            {
                if (numero >= 0)
                {
                    numeros.AgregarNumero(numero);  // Agregar el número a la lista
                    lstNumeros.Items.Add(numero);   // Mostrarlo en el ListBox
                    txtNumero.Clear();              // Limpiar el TextBox
                }
                else
                {
                    // Mostrar resultados si se ingresa un número negativo
                    MessageBox.Show("Número negativo ingresado. Se detendrá la entrada y se mostrarán los resultados.");
                    MostrarResultados();
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa un número válido.");
            }
        }

        // Método para mostrar los resultados (suma, mayor y menor)
        private void MostrarResultados()
        {
            if (numeros.ListaNumeros.Count > 0)
            {
                lblSuma.Text = "Suma: " + numeros.SumarNumeros().ToString();
                lblMayor.Text = "Mayor: " + numeros.ObtenerMayor().ToString();
                lblMenor.Text = "Menor: " + numeros.ObtenerMenor().ToString();
            }
            else
            {
                MessageBox.Show("No se han ingresado números válidos.");
            }
        }

        // Evento opcional para mostrar los resultados manualmente
        private void btnMostrarResultados_Click(object sender, EventArgs e)
        {
            MostrarResultados();
        }
    }

    internal class Numeros
    {
    }
}
