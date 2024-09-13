using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion
{
    internal class Numeros
    {
        private List<int> numeros; // Lista para almacenar los números ingresados

        // Constructor que inicializa la lista de números
        public Numeros()
        {
            numeros = new List<int>();
        }

        // Agrega un número a la lista si es no negativo
        public void AddNumero(int numero)
        {
            if (numero >= 0)
            {
                numeros.Add(numero);
            }
        }

        // Retorna la suma de los números en la lista
        public int Suma()
        {
            return numeros.Sum();
        }

        // Retorna el número mayor, o 0 si la lista está vacía
        public int Mayor()
        {
            return numeros.Count > 0 ? numeros.Max() : 0;
        }

        // Retorna el número menor, o 0 si la lista está vacía
        public int Menor()
        {
            return numeros.Count > 0 ? numeros.Min() : 0;
        }

        // Verifica si hay números en la lista
        public bool HayNumeros()
        {
            return numeros.Count > 0;
        }
    }
}
