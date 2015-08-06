using LojaWebEF.DAO;
using LojaWebEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaWebEF.Controllers
{
  public class ProdutosController : Controller
  {
    private ProdutosDAO dao;

    public ProdutosController(ProdutosDAO dao)
    {
      this.dao = dao;
    }

    public ActionResult Index()
    {
      return View(this.dao.Lista());
    }

    public ActionResult Form()
    {
      return View();
    }

    public ActionResult Adiciona(Produto produto)
    {
      this.dao.Adiciona(produto);
      return RedirectToAction("Index");
    }

    public ActionResult Remove(int id)
    {
      this.dao.Remove(this.dao.BuscaPorId(id));
      return RedirectToAction("Index");
    }

    public ActionResult Visualiza(int id)
    {
      Produto p = this.dao.BuscaPorId(id);
      return View(p);
    }

    public ActionResult Atualiza(Produto produto)
    {
      this.dao.Atualiza(produto);
      return RedirectToAction("Index");
    }

    public ActionResult ProdutosComPrecoMinimo(decimal? preco)
    {
      ViewBag.Preco = preco;
      IEnumerable<Produto> produtos = new List<Produto>();
      return View(produtos);
    }

    public ActionResult ProdutosDaCategoria(string nomeCategoria)
    {
      ViewBag.NomeCategoria = nomeCategoria;
      IEnumerable<Produto> produtos = new List<Produto>();
      return View(produtos);
    }

    public ActionResult ProdutosDaCategoriaComPrecoMinimo(decimal? preco, string nomeCategoria)
    {
      ViewBag.Preco = preco;
      ViewBag.NomeCategoria = nomeCategoria;
      IEnumerable<Produto> produtos = new List<Produto>();
      return View(produtos);
    }

    public ActionResult BuscaDinamica(decimal? preco, string nomeCategoria, string nome)
    {
      ViewBag.Preco = preco;
      ViewBag.Nome = nome;
      ViewBag.NomeCategoria = nomeCategoria;

      IEnumerable<Produto> produtos = new List<Produto>();
      return View(produtos);
    }
    public ActionResult ListaPaginada(int? pagina)
    {
      int paginaAtual = pagina.GetValueOrDefault(1);
      ViewBag.Pagina = paginaAtual;
      IEnumerable<Produto> produtos = new List<Produto>();
      return View(produtos);
    }
  }
}
