using System;

namespace ProjectAspNetCodeFirst.Models
{
    public class Livro
    {
        public Livro() =>
            DataEntrada = DateTime.Now;

        public Livro(int iD, int categoriaID, string titulo, string autor, int quantidade, decimal preco, DateTime dataEntrada) : this()
        {
            this.ID = iD;
            this.CategoriaID = categoriaID;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Quantidade = quantidade;
            this.Preco = preco;
            this.DataEntrada = dataEntrada;
               
        }
        
        public int ID { get; set; }
        public int CategoriaID { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataEntrada { get; set; }
        public Categoria Categoria { get; set; }
    }
}