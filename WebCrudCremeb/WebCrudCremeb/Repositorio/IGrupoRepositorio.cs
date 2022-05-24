using WebCrudCremeb.Models;

namespace WebCrudCremeb.Repositorio
{
    public interface IGrupoRepositorio
    {
        GrupoModel ListarPorId(int id);
        List<GrupoModel> BuscarTodos();
        GrupoModel Adicionar(GrupoModel grupo);
        bool Apagar(int id);
    }
}
