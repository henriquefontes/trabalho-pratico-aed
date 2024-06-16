using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPratico
{
    internal class Curso
    {
        private string nome;
        private int vagas;
        private List<Candidato> selecionados;
        private Fila filaEspera;
        private double notaCorte;

        public string Nome
        {
            get { return nome; }
        }

        public double NotaCorte
        {
            get { return notaCorte; }
        }

        public Curso(string nome, int vagas)
        {
            this.nome = nome;
            this.vagas = vagas;
            selecionados = new List<Candidato>();
            filaEspera = new Fila(10);
        }

        public bool AdicionarCandidato(Candidato candidato)
        {
            if (selecionados.Count == vagas)
            {
                return false;
            }

            selecionados.Add(candidato);
            notaCorte = candidato.Media;
            return true;
        }

        public void AdicionarCandidatoEspera(Candidato candidato)
        {
            filaEspera.Adicionar(candidato);
        }

        public void PrintarSelecionados(StreamWriter sw)
        {
            foreach (Candidato selecionado in selecionados)
            {
                sw.WriteLine(selecionado);
            }
        }

        public void PrintarListaEspera()
        {
            filaEspera.Printar();
        }

    }
}
