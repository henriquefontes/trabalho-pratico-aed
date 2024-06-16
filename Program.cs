namespace TrabalhoPratico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Curso> cursos = new Dictionary<int, Curso>();

            StreamReader sr = new StreamReader("entrada.txt");

            string[] quantidades = sr.ReadLine().Split(";");
            int quantidadeCursos = int.Parse(quantidades[0]);
            int quantidadeCandidatos = int.Parse(quantidades[1]);

            Candidato[] candidatos = new Candidato[quantidadeCandidatos];

            for (int i = 0; i < quantidadeCursos; i++)
            {
                string[] dados = sr.ReadLine().Split(";");

                int codigo = int.Parse(dados[0]);
                string nome = dados[1];
                int vagas = int.Parse(dados[2]);

                cursos.Add(codigo, new Curso(nome, vagas));
            }

            for (int i = 0; i < quantidadeCandidatos; i++)
            {
                string[] dados = sr.ReadLine().Split(";");

                string nome = dados[0];
                double notaRed = double.Parse(dados[1]);
                double notaMat = double.Parse(dados[2]);
                double notaLing = double.Parse(dados[3]);
                int cursoUm = int.Parse(dados[4]);
                int cursoDois = int.Parse(dados[5]);

                candidatos[i] = (new Candidato(nome, notaRed, notaMat, notaLing, cursoUm, cursoDois));
            }

            sr.Close();

            QuickSort.OrdenarMat(candidatos, 0, candidatos.Length - 1);
            QuickSort.OrdenarRed(candidatos, 0, candidatos.Length - 1);
            QuickSort.OrdenarMedia(candidatos, 0, candidatos.Length - 1);

            for (int i = 0; i < candidatos.Length; i++)
            {
                Candidato candidato = candidatos[i];
                Curso cursoUm = cursos[candidato.CursoUm];
                Curso cursoDois = cursos[candidato.CursoDois];

                if (!cursoUm.AdicionarCandidato(candidato))
                {
                    if (cursoDois.AdicionarCandidato(candidato))
                    {
                        cursoUm.AdicionarCandidatoEspera(candidato);
                    } else
                    {
                        cursoUm.AdicionarCandidatoEspera(candidato);
                        cursoDois.AdicionarCandidatoEspera(candidato);
                    }
                }
            }

            StreamWriter sw = new StreamWriter("saida.txt");

            foreach (KeyValuePair<int, Curso> entry in cursos)
            {
                Curso curso = entry.Value;

                sw.WriteLine($"{curso.Nome} {curso.NotaCorte}");

                sw.WriteLine("Selecionados");
                curso.PrintarSelecionados(sw);

                sw.WriteLine("Fila de Espera");
                curso.PrintarListaEspera(sw);

                sw.WriteLine();
            }

            sw.Close();
        }
    }
}
