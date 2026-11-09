namespace ClassesObjetos
{
    public class Livro
    {
        public string? Titulo {get; set;}
        public string? Autor {get; set;}
        public int NumeroPaginas {get; set;}

        public Livro()
        {
            Titulo = "Sem título";
            Autor = "Desonhecido";
            NumeroPaginas = 0;
        }

         public Livro(string titulo)
        {
            Titulo = titulo;
        }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public Livro(string titulo, string autor, int numeroPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
        }

        public void ExibirDados()
        {
            Console.WriteLine("\n--- Sobre o livro ---");
            Console.WriteLine($"  Título: {Titulo}");
            Console.WriteLine($"  Autor: {Autor}");
            Console.WriteLine($"  Páginas: {NumeroPaginas}");
        }
    }
}