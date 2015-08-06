using LojaWebEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWebEF.DAO
{
  public class ProdutosDAO
  {
    private EntidadesContext contexto;

    public ProdutosDAO(EntidadesContext contexto)
    {
      this.contexto = contexto;
    }

    public void Adiciona(Produto produto)
    {
      contexto.Produtos.Add(produto);
      contexto.SaveChanges();
    }

    public void Remove(Produto produto)
    {
      contexto.Produtos.Remove(produto);
      contexto.SaveChanges();
    }

    public void Atualiza(Produto produto)
    {
      contexto.Entry<Produto>(produto).State = System.Data.EntityState.Modified;
      contexto.SaveChanges();
    }

    public Produto BuscaPorId(int id)
    {
      Produto p = new Produto();
      p = contexto.Produtos.Find(id);
      return p;
    }

    public IEnumerable<Produto> Lista()
    {
      return contexto.Produtos.ToList();
    }

    public IEnumerable<Produto> ProdutosComPrecoMaiorDoQue(decimal? preco)
    {
      return new List<Produto>();
    }

    public IEnumerable<Produto> ProdutosDaCategoria(string nomeCategoria)
    {
      return new List<Produto>();
    }

    public IEnumerable<Produto> ProdutosDaCategoriaComPrecoMaiorDoQue(decimal? preco, string nomeCategoria)
    {
      return new List<Produto>();
    }

    public IEnumerable<Produto> ListaPaginada(int paginaAtual)
    {
      return new List<Produto>();
    }

    public IEnumerable<Produto> BuscaPorPrecoCategoriaENome(decimal? preco, string nomeCategoria, string nome)
    {
      return new List<Produto>();
    }
  }
}