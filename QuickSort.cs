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

        public static void OrdenarMedia(Candidato[] array, int esq, int dir)
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
                OrdenarMedia(array, esq, j);
            if (i < dir)
                OrdenarMedia(array, i, dir);
        }
        public static void OrdenarRed(Candidato[] array, int esq, int dir)
        {
            int i = esq, j = dir;
            Candidato pivo = array[(esq + dir) / 2];

            while (i <= j)
            {
                while (array[i].NotaRed > pivo.NotaRed)
                    i++;
                while (array[j].NotaRed < pivo.NotaRed)
                    j--;

                if (i <= j)
                {
                    Swap(array, i, j);
                    i++;
                    j--;
                }
            }
            if (esq < j)
                OrdenarRed(array, esq, j);
            if (i < dir)
                OrdenarRed(array, i, dir);
        }
        public static void OrdenarMat(Candidato[] array, int esq, int dir)
        {
            int i = esq, j = dir;
            Candidato pivo = array[(esq + dir) / 2];

            while (i <= j)
            {
                while (array[i].NotaMat > pivo.NotaMat)
                    i++;
                while (array[j].NotaMat < pivo.NotaMat)
                    j--;

                if (i <= j)
                {
                    Swap(array, i, j);
                    i++;
                    j--;
                }
            }
            if (esq < j)
                OrdenarMat(array, esq, j);
            if (i < dir)
                OrdenarMat(array, i, dir);
        }

    }
}
