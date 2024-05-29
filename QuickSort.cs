using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPratico
{
    internal class QuickSort
    {
        private static void Swap(Candidato[] array, int i, int j)
        {
            Candidato temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static void Ordenar(Candidato[] array, int esq, int dir)
        {
            int i = esq, j = dir;
            Candidato pivo = array[(esq + dir) / 2];

            while (i <= j)
            {
                while (array[i].Media > pivo.Media)
                    i++;
                while (array[j].Media < pivo.Media)
                    j--;

                if (i <= j)
                {
                    Swap(array, i, j);
                    i++; 
                    j--;
                }
            }
            if (esq < j)
                Ordenar(array, esq, j);
            if (i < dir)
                Ordenar(array, i, dir);
        }
    }
}
