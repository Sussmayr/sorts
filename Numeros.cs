using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_Ordenamientos_P1
{
    class Numeros
    {
        private int longitud; //cantidad de datos a ordenar
        private int[] arreglo = new int[1];

    public Numeros() //contructor de la clase
        {
            int a = 0;
            arreglo[0] = a; //auxiliar
            Calcular_Longitud();
        }
        public void Calcular_Longitud()
        {
            longitud = arreglo.Length;
        }
        public int Obtener_Longitud()
        {
            return longitud;
        }

        public int[] obtener_Arreglo()
        {
            //eliminar el primer valor que es 0
            int indexToRemove = 0;
            arreglo = arreglo.Where((source, index) => index != indexToRemove).ToArray();

            return arreglo;
        }

        public void Insertar_Dato(int dato) //insertar valores al arreglo
        {
            //aqui se recibe e incrementa el arreglo
            Array.Resize<int>(ref arreglo, longitud + 1);
            arreglo[longitud] = dato;
            Calcular_Longitud();
        }
    }
}
