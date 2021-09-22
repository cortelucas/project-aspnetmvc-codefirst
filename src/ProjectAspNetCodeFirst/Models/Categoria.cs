using System.Collections.Generic;

namespace ProjectAspNetCodeFirst.Models
{
  public class Categoria
  {
    protected Categoria() =>
        Livros = new List<Livro>();

    public Categoria(int iD, string nome) : this()
    {

      this.ID = iD;
      this.Nome = nome;

    }
    public int ID { get; set; }
    public string Nome { get; set; }
    public virtual ICollection<Livro> Livros { get; set; }
  }
}