using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            // Validación de entradas
            string nombre = txtNombre.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            double nota;
            bool esNotaValida = double.TryParse(txtNota.Text, out nota);
            if (!esNotaValida || nota < 0 || nota > 100)
            {
                MessageBox.Show("Por favor, ingresa una nota válida entre 0 y 100.");
                return;
            }

            // Verificar el límite de estudiantes
            if (estudiantes.Count >= 1000)
            {
                MessageBox.Show("No puedes ingresar más de 1000 estudiantes.");
                return;
            }

            // Agregar el estudiante a la lista
            Estudiante estudiante = new Estudiante(nombre, nota);
            estudiantes.Add(estudiante);

            // Actualizar la lista de estudiantes en el ListBox
            ActualizarListaEstudiantes();

            // Limpiar los campos de entrada
            txtNombre.Clear();
            txtNota.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarListaEstudiantes()
        {
            lstEstudiantes.Items.Clear();
            foreach (var estudiante in estudiantes)
            {
                lstEstudiantes.Items.Add(estudiante.ToString());
            }
        }

        private void btnCalcularResultados_Click(object sender, EventArgs e)
        {
            // Validar si hay al menos un estudiante en la lista
            if (estudiantes.Count == 0)
            {
                MessageBox.Show("No hay estudiantes en la lista.");
                return;
            }

            // Calcular el promedio
            double promedio = estudiantes.Average(est => est.Nota);
            MessageBox.Show($"El promedio de las notas es: {promedio:F2}");

            // Obtener los tres primeros lugares
            var tresPrimeros = estudiantes.OrderByDescending(est => est.Nota).Take(3).ToList();

            string mensaje = "Tres primeros lugares:\n";
            for (int i = 0; i < tresPrimeros.Count; i++)
            {
                mensaje += $"{i + 1}. {tresPrimeros[i].Nombre} - Nota: {tresPrimeros[i].Nota}\n";
            }

            MessageBox.Show(mensaje);
        }
    }
}
