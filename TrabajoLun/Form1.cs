using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics; 
using System.Linq; 
using System.Windows.Forms;

namespace TrabajoLun
{
    public partial class Form1 : Form
    {

        private List<int> Numeros;

        public Form1()
        {
            InitializeComponent();
 
            Numeros = new List<int>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Aqui se generan 500,000 números aleatorios
            // se puede cambiar a 1,000,000 y 5,000,000 para probar o lo que sea

            int cantidad = 1000000;

            lstNumeros.DataSource = null;
            lstNumeros.Items.Clear();
            Numeros = null;
            GC.Collect();

            Numeros = new List<int>(cantidad);
            Random rnd = new Random();

            for (int i = 0; i < cantidad; i++)
            {
                Numeros.Add(rnd.Next(1, cantidad * 2));
            }

            ActualizarListaVisual(); 

            this.Text = $"Datos en memoria: {cantidad:N0}";
            lblTiempo.Text = "Tiempo: Lista generada.";
        }


        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
  
            // Con 500,000 datos tardaría hora y ahora con 5M ni se diga dilataria días por eso tiene ese limite para que no se pegue.

            if (Numeros.Count > 500000)
            {
                MessageBox.Show("\nSelection Sort es demasiado lento para esta cantidad de datos.\n" +
                                "\nLa aplicación se congelaría.\n" +
                                "\nUsa Merge Sort o reduce la cantidad de datos a menos de 20,000.\n",
                                "Protección de Algoritmo");
                return;
            }

            Stopwatch sw = Stopwatch.StartNew();

       
            int n = Numeros.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (Numeros[j] < Numeros[min_idx])
                        min_idx = j;
                }
                int temp = Numeros[min_idx];
                Numeros[min_idx] = Numeros[i];
                Numeros[i] = temp;
            }

            sw.Stop();
            ActualizarListaVisual();
            lblTiempo.Text = $"Selection Sort: {sw.ElapsedMilliseconds} ms";
            MessageBox.Show("Ordenado con Selection Sort");
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {

            try
            {
                Stopwatch sw = Stopwatch.StartNew();

                Numeros = MergeSort(Numeros);

                sw.Stop();
                ActualizarListaVisual();
                lblTiempo.Text = $"Merge Sort: {sw.ElapsedMilliseconds} ms";
                MessageBox.Show("Ordenado con Merge Sort");
            }
            catch (StackOverflowException)
            {
                MessageBox.Show("Error: La recursividad fue demasiado profunda para la memoria de la pila (Stack).");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }


        private List<int> MergeSort(List<int> lista)
        {
            if (lista.Count <= 1) return lista;
            int mid = lista.Count / 2;
            List<int> left = lista.GetRange(0, mid);
            List<int> right = lista.GetRange(mid, lista.Count - mid);
            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>(left.Count + right.Count);
            int i = 0, j = 0;
            while (i < left.Count && j < right.Count)
            {
                if (left[i] <= right[j]) result.Add(left[i++]);
                else result.Add(right[j++]);
            }
            while (i < left.Count) result.Add(left[i++]);
            while (j < right.Count) result.Add(right[j++]);
            return result;
        }


        private void btnJumpSearch_Click(object sender, EventArgs e)
        {

            Numeros.Sort();
            ActualizarListaVisual(); 

            int x;
            if (int.TryParse(txtBuscar.Text, out x))
            {
                Stopwatch sw = Stopwatch.StartNew();
                int index = JumpSearch(Numeros, x);
                sw.Stop();

                lblTiempo.Text = $"Jump Search: {sw.ElapsedTicks} ticks";
                MostrarResultado(index, x);
            }
        }

        private int JumpSearch(List<int> arr, int x)
        {
            int n = arr.Count;
            int step = (int)Math.Sqrt(n);
            int prev = 0;
            while (arr[Math.Min(step, n) - 1] < x)
            {
                prev = step;
                step += (int)Math.Sqrt(n);
                if (prev >= n) return -1;
            }
            while (arr[prev] < x)
            {
                prev++;
                if (prev == Math.Min(step, n)) return -1;
            }
            if (arr[prev] == x) return prev;
            return -1;
        }

        private void btnInterpolation_Click(object sender, EventArgs e)
        {
            Numeros.Sort();
            ActualizarListaVisual();

            int x;
            if (int.TryParse(txtBuscar.Text, out x))
            {
                Stopwatch sw = Stopwatch.StartNew();
                int index = InterpolationSearch(Numeros, x);
                sw.Stop();

                lblTiempo.Text = $"Interpolation: {sw.ElapsedTicks} ticks";
                MostrarResultado(index, x);
            }
        }

        private int InterpolationSearch(List<int> sortedList, int x)
        {
            int lo = 0;
            int hi = sortedList.Count - 1;
            while (lo <= hi && x >= sortedList[lo] && x <= sortedList[hi])
            {
                if (lo == hi) return sortedList[lo] == x ? lo : -1;

                long pos = lo + (((long)(hi - lo) * (x - sortedList[lo])) / (sortedList[hi] - sortedList[lo]));

                if (sortedList[(int)pos] == x) return (int)pos;
                if (sortedList[(int)pos] < x) lo = (int)pos + 1;
                else hi = (int)pos - 1;
            }
            return -1;
        }

        private void ActualizarListaVisual()
        {
       
            lstNumeros.DataSource = null;

            if (Numeros.Count > 10000000)
            {
                // Si hay muchos datos, solo se muestran los primeros 10000
                // Usando .Take(10000)
                lstNumeros.DataSource = Numeros.Take(10000).ToList();
            }
            else
            {
                // Si son poquitos, mostramos todo
                lstNumeros.DataSource = Numeros;
            }
        }

        private void MostrarResultado(int index, int valorBuscado)
        {
            if (index != -1)
            {
                // Si el índice encontrado está dentro de los primeros 10000, lo seleccionamos en la lista visual
                if (index < 10000000)
                {
                    lstNumeros.SelectedIndex = index;
                }

                MessageBox.Show($"\nEl número {valorBuscado} está en la posición (índice): {index}\n" +
                                $"\nla lista visual solo muestra los primeros 1000\n");
            }
            else
            {
                MessageBox.Show("Numero no encontrado.");
            }
        }

        private void lstNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
