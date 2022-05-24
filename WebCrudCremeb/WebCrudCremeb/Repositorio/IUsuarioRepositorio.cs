using WebCrudCremeb.Models;

namespace WebCrudCremeb.Repositorio
{
    public interface IUsuarioRepositorio
    {
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Adicionar(UsuarioModel usuario);
    }
}
