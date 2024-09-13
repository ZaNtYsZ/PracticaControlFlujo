using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public partial class Form1 : Form
{
    private GestorNotas gestorNotas = new GestorNotas();

    public Form1()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    // Evento para agregar notas a la lista cuando se presiona el botón "Agregar Nota"
    private void btnAgregarNota_Click(object sender, EventArgs e)
    {
        double nota;

        // Validar si la nota ingresada es un número decimal
        if (double.TryParse(txtNota.Text, out nota))
        {
            if (gestorNotas.AgregarNota(nota))
            {
                txtNota.Clear(); // Limpiar el TextBox
            }
            else
            {
                MessageBox.Show("La nota debe estar entre 0 y 100 o se ha alcanzado el máximo de notas permitidas.");
            }
        }
        else
        {
            MessageBox.Show("Por favor ingresa una nota válida.");
        }
    }

    // Método para mostrar los resultados (promedio y los tres primeros lugares)
    private void MostrarResultados()
    {
        double promedio = gestorNotas.ObtenerPromedio();
        var mejoresNotas = gestorNotas.ObtenerPrimerosLugares();

        lblPromedio.Text = "Promedio: " + promedio.ToString("F2");
        lblPrimerLugar.Text = "1er Lugar: " + (mejoresNotas.Length > 0 ? mejoresNotas[0].ToString("F2") : "N/A");
        lblSegundoLugar.Text = "2do Lugar: " + (mejoresNotas.Length > 1 ? mejoresNotas[1].ToString("F2") : "N/A");
        lblTercerLugar.Text = "3er Lugar: " + (mejoresNotas.Length > 2 ? mejoresNotas[2].ToString("F2") : "N/A");
    }

    // Evento para mostrar los resultados cuando se presiona el botón "Mostrar Resultados"
    private void btnMostrarResultados_Click(object sender, EventArgs e)
    {
        MostrarResultados();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
    private System.Windows.Forms.TextBox txtNota;
    private System.Windows.Forms.Label lblPromedio;
    private System.Windows.Forms.Label lblPrimerLugar;
    private System.Windows.Forms.Label lblSegundoLugar;
    private System.Windows.Forms.Label lblTercerLugar;

}
