using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectos
{
    public partial class FormImplementacionHilos : Form
    {
        public FormImplementacionHilos()
        {
            InitializeComponent();
        }
        private int sumaTotal = 0;
        private object lockObject = new object();


    
    private void CalcularPrimos(object rango)
        {
            (int inicio, int fin) = ((int, int))rango;
            int suma = 0;
            for (int i = inicio; i <= fin; i++)
            {
                if (EsPrimo(i))
                    suma += i;
            }
            lock (lockObject)
            {
                sumaTotal += suma;
            }
        }

        private bool EsPrimo(int numero)
        {
            if (numero < 2) return false;
            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumero.Text, out int N) || N <= 0)
            {
                MessageBox.Show("Ingrese un número válido.");
                return;
            }
            if (!int.TryParse(txtHilos.Text, out int M) || M <= 0)
            {
                MessageBox.Show("Ingrese un número de hilos válido.");
                return;
            }

            // Ejecucion secuencial
            sumaTotal = 0;
            Stopwatch swSecuencial = Stopwatch.StartNew();
            for (int i = 1; i <= N; i++)
            {
                if (EsPrimo(i))
                    sumaTotal += i;
            }
            swSecuencial.Stop();
            int sumaSecuencial = sumaTotal;
            double tiempoSecuencial = (double)swSecuencial.ElapsedTicks / Stopwatch.Frequency * 1000;//convercion a milisegundos

            //Ejecucion concurrente
            sumaTotal = 0;
            int rango = N / M;
            Thread[] hilos = new Thread[M];
            Stopwatch swConcurrente = Stopwatch.StartNew();

            for (int i = 0; i < M; i++)
            {
                int inicio = i * rango + 1;
                int fin = (i == M - 1) ? N : inicio + rango - 1;
                hilos[i] = new Thread(CalcularPrimos);
                hilos[i].Start((inicio, fin));
            }

            // Esperar a que los hilos terminen
            foreach (var hilo in hilos)
            {
                hilo.Join();
            }

            swConcurrente.Stop();
            int sumaConcurrente = sumaTotal;
            double tiempoConcurrente = (double)swConcurrente.ElapsedTicks / Stopwatch.Frequency * 1000;

            // Resultados
            lblResultado.Text = $"Suma de primos (Secuencial): {sumaSecuencial} - (Concurrente): {sumaConcurrente}";
            lblTiempo.Text = $"Tiempo (Secuencial): {tiempoSecuencial} ms - (Concurrente): {tiempoConcurrente} ms";
        }
    }
}