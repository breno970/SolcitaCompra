using Microsoft.AspNetCore.Mvc;
using SolicitaCompra.Models;
using SolicitaCompra.Services;

namespace SolicitaCompra.Controllers
{
    public class ServicoFornecedor : Controller
    {

        private ServicoFornecedorServices _service = new ServicoFornecedorServices();
        public IActionResult Index()
        {
            List<VwServicoFornecedor> oListVwServicoFornecedor = _service.oRepositoryServicoFornecedor.SelecionarTodos();
            return View(oListVwServicoFornecedor);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(ServicoFornecedor model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            
            return RedirectToAction("Index");
        }

    }
}
