using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_Ordenamientos_P1
{
    public partial class BurbujaMejorada : Form
    {
        Numeros Datos = new Numeros();
        int[] Arreglo_numeros;
        public BurbujaMejorada()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //validaciones
            try
            {
                int num = Convert.ToInt32(txtNum.Text);
                if (num <= 0)
                {
                    MessageBox.Show("ingrese un valor positivo");
                }
                else
                {
                    Datos.Insertar_Dato(num);
                    MessageBox.Show("Agregado");
                    txtNum.Clear();
                    txtNum.Select();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese solo numeros enteros");
                txtNum.Clear();
                txtNum.Select();
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            txtDesordenado.Clear();
            txtOrdenadaAscen.Clear();
            txtOrdenadaDescen.Clear();

            Arreglo_numeros = Datos.obtener_Arreglo();

            if (Arreglo_numeros.Length == 0)
            {
                MessageBox.Show("debe ingresar valores antes de ordenar");
            }
            else
            {
                Stopwatch sw1 = new Stopwatch(); // Creación del Stopwatch.

                foreach (int num in Arreglo_numeros)
                {
                    txtDesordenado.Text += num + Environment.NewLine + " ";
                }

                sw1.Start(); // Iniciar la medición.
                Burbuja_Acendente(Arreglo_numeros);
                sw1.Stop(); // Detener la medición.

                foreach (int num in Arreglo_numeros)
                {
                    txtOrdenadaAscen.Text += num + Environment.NewLine + " ";
                }

                Burbuja_Decendente(Arreglo_numeros);
                foreach (int num in Arreglo_numeros)
                {
                    txtOrdenadaDescen.Text += num + Environment.NewLine + " ";
                }

                //imprime la medición en label
                this.lblTime1.Text = sw1.Elapsed.ToString();
            }
        }

        public static void Burbuja_Decendente(int[] lista)
        {
            int i;
            int bandera = 1;
            //Iteramos, de mayor a menor
            for (i = 0; i <= lista.Length - 1 && bandera == 1; i++)
            {
                bandera = 0;
                for (int j = 0; j < lista.Length - i - 1; j++)
                {
                    if (lista[j] < lista[j + 1])
                    {
                        bandera = 1;
                        int tem = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = tem;
                    }
                }
            }
        }

        public static void Burbuja_Acendente(int[] lista)
        {
            int t;
            int bandera = 1;
            for (int a = 1; a < lista.Length && bandera == 1; a++)
            {
                bandera = 0;
                for (int b = lista.Length - 1; b >= a; b--)
                {
                    if (lista[b - 1] > lista[b])
                    {
                        bandera = 1;
                        t = lista[b - 1];
                        lista[b - 1] = lista[b];
                        lista[b] = t;
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //regresar al menu anterior
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void BurbujaMejorada_Load(object sender, EventArgs e)
        {
            lblTime1.Text = "0";
        }

    }
}
