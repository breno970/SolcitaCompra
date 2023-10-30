using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SolicitaCompra;
using SolicitaCompra.Models;
using SolicitaCompra.Services;


namespace SolicitaCompra.Controllers
{
    public class FornecedorController : Controller
    {
        private FornecedorServices oFornecedorServices = new FornecedorServices();

        public IActionResult Index()
        {
            List<Fornecedores> oListFornecedores = oFornecedorServices.oRepositoryFornecedor.SelecionarTodos();
            return View(oListFornecedores);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Fornecedores model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oFornecedorServices.oRepositoryFornecedor.Incluir(model);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Fornecedores oFornecedores = oFornecedorServices.oRepositoryFornecedor.SelecionarPk(id);
            return View(oFornecedores);
        }

        public IActionResult Edit(int id)
        {
            Fornecedores oFornecedores = oFornecedorServices.oRepositoryFornecedor.SelecionarPk(id);
            return View(oFornecedores);

        }

        [HttpPost]
        public IActionResult Edit(Fornecedores model)
        {
            Fornecedores oFornecedores = oFornecedorServices.oRepositoryFornecedor.Alterar(model);
            int id = oFornecedores.Id;

            return RedirectToAction("Details", new { id });

        }

        public IActionResult Delete(int id)
        {

            oFornecedorServices.oRepositoryFornecedor.Excluir(id);
            return RedirectToAction("index");

        }



    }
}

