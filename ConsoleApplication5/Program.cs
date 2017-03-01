using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 7, 1, 8, 3 };
            int min = fMin(tab);
            int suma = fSum(tab);
            string wynik = string.Join(", ", fUnikalnosc(tab));
            Console.WriteLine("Minimum = {0}", fMin(tab));
            Console.WriteLine("Maximum = {0}", fMax(tab));
            Console.WriteLine("Suma = {0}", fSum(tab));
            Console.WriteLine("Unikalne = {0}", wynik);
            Console.ReadKey();
        }
        static int fMin(int[] tab)
        {

            int min = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] < min)
                    min = tab[i];
            }
            return min;

        }

        static int fSum(int[] tab)
        {
            int suma = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                suma += tab[i];

            }
            return suma;

        }
        static int fMax(int[] tab)
        {

            int max = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] > max)
                    max = tab[i];
            }
            return max;

        }
        static int[] fUnikalnosc(int[] tab)
        {
            List<int> lista = new List<int>();
            lista.Add(tab[0]);
            for (int i = 1; i < tab.Length; i++)
            {
                if (!lista.Contains(tab[i]))
                    lista.Add(tab[i]);
            }
            return lista.ToArray();
        }
        static int[] fKolumna(int[][] tab, int nrKolumny)
        {
            int[] kolumna = new int[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                kolumna[i] = tab[i][nrKolumny];
            }
            return kolumna;

        }

    }
}
