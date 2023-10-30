using Microsoft.AspNetCore.Mvc;
using SolicitaCompra.Models;
using SolicitaCompra.Services;

namespace SolicitaCompra.Controllers
{
    
  
    public class ProdutosController : Controller
    {
        private ProdutoServices oProdutoServices = new ProdutoServices();

        public IActionResult Index()
        {
            List<Produtos> oListProdutos = oProdutoServices.oRepositoryProdutos.SelecionarTodos();
            return View(oListProdutos);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Produtos model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oProdutoServices.oRepositoryProdutos.Incluir(model);

            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            Produtos oProdutos = oProdutoServices.oRepositoryProdutos.SelecionarPk(id);
            return View(oProdutos);
        }

        public IActionResult Edit(int id)
        {
            Produtos oProdutos = oProdutoServices.oRepositoryProdutos.SelecionarPk(id);
            return View(oProdutos);
            
        }

        [HttpPost]
        public IActionResult Edit(Produtos model)
        {
            Produtos oProdutos = oProdutoServices.oRepositoryProdutos.Alterar(model);
            int id = oProdutos.Id;

            return RedirectToAction("Details", new  { id });

        }

        public IActionResult Delete(int id) 
        {

            oProdutoServices.oRepositoryProdutos.Excluir(id);
            return RedirectToAction("index");

        }



    }
}
