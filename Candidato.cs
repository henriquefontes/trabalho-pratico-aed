using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPratico
{
    internal class Candidato
    {
        private string nome;
        private double notaRed, notaMat, notaLing, media;
        private int cursoUm, cursoDois;

        public Candidato(string nome, double notaRed, double notaMat, double notaLing, int cursoUm, int cursoDois)
        {
            this.nome = nome;
            this.notaRed = notaRed;
            this.notaMat = notaMat;
            this.notaLing = notaLing;
            this.cursoUm = cursoUm;
            this.cursoDois = cursoDois;

            media = Math.Round((notaRed + notaMat + notaLing) / 3d, 2);
        }

        public string Nome { get { return nome; } }
        public double NotaRed { get { return notaRed; } }
        public double NotaMat { get { return notaMat; } }
        public double NotaLing { get { return notaLing; } }
        public double Media { get { return media; } }
        public int CursoUm { get { return cursoUm; } }
        public int CursoDois { get { return cursoDois; } }

        public override string ToString()
        {
            return $"{nome} {media.ToString("N2")} {notaRed} {notaMat} {notaLing}";
        }
    }
}
