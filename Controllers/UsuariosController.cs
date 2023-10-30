using Microsoft.AspNetCore.Mvc;
using SolicitaCompra.Models;
using SolicitaCompra.Services;

namespace SolicitaCompra.Controllers
{
    
  
    public class UsuariosController : Controller
    {
        private UsuarioServices oUsuarioServices = new UsuarioServices();

        public IActionResult Index()
        {
            List<Usuarios> oListUsuarios = oUsuarioServices.oRepositoryUsuarios.SelecionarTodos();
            return View(oListUsuarios);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Usuarios model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oUsuarioServices.oRepositoryUsuarios.Incluir(model);

            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            Usuarios oUsuarios = oUsuarioServices.oRepositoryUsuarios.SelecionarPk(id);
            return View(oUsuarios);
        }

        public IActionResult Edit(int id)
        {
            Usuarios oUsuarios = oUsuarioServices.oRepositoryUsuarios.SelecionarPk(id);
            return View(oUsuarios);

        }

        [HttpPost]
        public IActionResult Edit(Usuarios model)
        {
            Usuarios oUsuarios = oUsuarioServices.oRepositoryUsuarios.Alterar(model);
            int id = oUsuarios.Id;

            return RedirectToAction("Details", new  { id });

        }

        public IActionResult Delete(int id) 
        {

            oUsuarioServices.oRepositoryUsuarios.Excluir(id);
            return RedirectToAction("index");

        }



    }
}
