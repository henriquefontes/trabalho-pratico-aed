using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPratico
{
    internal class Fila
    {
        private Candidato[] vetor;
        int primeiro, ultimo;

        public Fila(int tamanho)
        {
            vetor = new Candidato[tamanho + 1];
            primeiro = ultimo = 0;
        }

        public void Adicionar(Candidato elemento)
        {
            if ((ultimo + 1) % vetor.Length != primeiro)
            {
                vetor[ultimo] = elemento;
                ultimo = (ultimo + 1) % vetor.Length;
            }
        }

        public void Printar()
        {
            for (int i = primeiro; i != ultimo; i = (primeiro + 1) % vetor.Length)
            {
                Candidato candidato = vetor[i];

                Console.WriteLine($"{candidato.Nome} {candidato.Media} {candidato.NotaRed} {candidato.NotaMat} {candidato.NotaLing}");
            }
        }
    }
}
