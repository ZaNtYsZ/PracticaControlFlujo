using System;
using System.Linq;

public class GestorNotas
{
    private const int MaxNotas = 1000;
    private double[] notas = new double[MaxNotas];
    private int cantidadNotas = 0;

    // Método para agregar una nota
    public bool AgregarNota(double nota)
    {
        if (cantidadNotas < MaxNotas && nota >= 0 && nota <= 100)
        {
            notas[cantidadNotas] = nota;
            cantidadNotas++;
            return true;
        }
        return false;
    }

    // Método para obtener el promedio de las notas
    public double ObtenerPromedio()
    {
        if (cantidadNotas > 0)
        {
            return notas.Take(cantidadNotas).Average();
        }
        return 0;
    }

    // Método para obtener los tres primeros lugares
    public double[] ObtenerPrimerosLugares()
    {
        return notas.Take(cantidadNotas).OrderByDescending(n => n).Take(3).ToArray();
    }
}
