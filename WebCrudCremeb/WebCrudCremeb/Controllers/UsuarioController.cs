using Microsoft.AspNetCore.Mvc;
using WebCrudCremeb.Models;
using WebCrudCremeb.Repositorio;

namespace WebCrudCremeb.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            List<UsuarioModel> usuarios = _usuarioRepositorio.BuscarTodos();
                
            return View(usuarios);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            UsuarioModel usuario = _usuarioRepositorio.ListarPorId(id);
            return View(usuario);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            UsuarioModel usuario = _usuarioRepositorio.ListarPorId(id);
            return View(usuario);
        }

        public IActionResult Apagar(int id)
        {
            _usuarioRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioRepositorio.Adicionar(usuario);
                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        [HttpPost]
        public IActionResult Alterar(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioRepositorio.Atualizar(usuario);
                return RedirectToAction("Index");
            }

            return View("Editar",usuario);
        }
    }
}
