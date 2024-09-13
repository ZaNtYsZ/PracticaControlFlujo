using System;
using System.Collections.Generic;
using System.Linq;

namespace Evaluacion
{
    public class Numeros
    {
        // Propiedad que almacena la lista de números ingresados
        public List<int> ListaNumeros { get; set; }

        // Constructor que inicializa la lista de números
        public Numeros()
        {
            ListaNumeros = new List<int>();
        }

        // Método para sumar todos los números en la lista
        public int SumarNumeros()
        {
            return ListaNumeros.Sum();
        }

        // Método para obtener el número mayor de la lista
        public int ObtenerMayor()
        {
            return ListaNumeros.Max();
        }

        // Método para obtener el número menor de la lista
        public int ObtenerMenor()
        {
            return ListaNumeros.Min();
        }

        // Método para agregar un número a la lista
        public void AgregarNumero(int numero)
        {
            ListaNumeros.Add(numero);
        }
    }
}
