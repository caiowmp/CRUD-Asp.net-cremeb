using Microsoft.AspNetCore.Mvc;
using WebCrudCremeb.Models;
using WebCrudCremeb.Repositorio;

namespace WebCrudCremeb.Controllers
{
    public class GrupoController : Controller
    {
        private readonly IGrupoRepositorio _grupoRepositorio;
        public GrupoController(IGrupoRepositorio grupoRepositorio)
        {
            _grupoRepositorio = grupoRepositorio;
        }
        public IActionResult Index()
        {
            //List<GrupoModel> grupos = _grupoRepositorio.BuscarTodos();

            return View(/*/grupos/*/);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            GrupoModel grupo = _grupoRepositorio.ListarPorId(id);
            return View(grupo);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            GrupoModel grupo = _grupoRepositorio.ListarPorId(id);
            return View(grupo);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _grupoRepositorio.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Grupo apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = $"Erro ao apagar o grupo";
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao apagar o grupo, tente novamente!\nErro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(GrupoModel grupo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _grupoRepositorio.Adicionar(grupo);
                    TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(grupo);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao cadastrar o usuário, tente novamente!\nErro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
