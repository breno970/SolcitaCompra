using Microsoft.AspNetCore.Mvc;
using SolicitaCompra.Models;
using SolicitaCompra.Services;

namespace SolicitaCompra.Controllers
{
    
  
    public class ServicosController : Controller
    {
        private ServicoServices oServicoServices = new ServicoServices();

        public IActionResult Index()
        {
            List<Servicos> oListServicos = oServicoServices.oRepositoryServicos.SelecionarTodos();
            return View(oListServicos);
        }

        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Create(Servicos model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oServicoServices.oRepositoryServicos.Incluir(model);

            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            Servicos oServicos = oServicoServices.oRepositoryServicos.SelecionarPk(id);
            return View(oServicos);
        }

        public IActionResult Edit(int id)
        {
            Servicos oServicos = oServicoServices.oRepositoryServicos.SelecionarPk(id);
            return View(oServicos);
            
        }

        [HttpPost]
        public IActionResult Edit(Servicos model)
        {
            Servicos oServicos = oServicoServices.oRepositoryServicos.Alterar(model);
            int id = oServicos.Id;

            return RedirectToAction("Details", new  { id });

        }

        public IActionResult Delete(int id) 
        {

            oServicoServices.oRepositoryServicos.Excluir(id);
            return RedirectToAction("index");

        }



    }
}
