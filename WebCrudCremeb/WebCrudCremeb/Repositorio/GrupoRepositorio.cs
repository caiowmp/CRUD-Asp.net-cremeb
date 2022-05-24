using WebCrudCremeb.Data;
using WebCrudCremeb.Models;

namespace WebCrudCremeb.Repositorio
{
    public class GrupoRepositorio : IGrupoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public GrupoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public GrupoModel ListarPorId(int id)
        {
            return _bancoContext.Grupos.FirstOrDefault(x => x.Id == id);
        }

        public List<GrupoModel> BuscarTodos()
        {
            return _bancoContext.Grupos.ToList();
        }

        public GrupoModel Adicionar(GrupoModel grupo)
        {
            _bancoContext.Grupos.Add(grupo);
            _bancoContext.SaveChanges();
            return grupo;
        }

        public GrupoModel Atualizar(GrupoModel grupo)
        {
            GrupoModel grupoDb = ListarPorId(grupo.Id);

            if (grupoDb == null)
            {
                throw new Exception("Houve um erro na atualização do usuário");
            }

            grupoDb.Descricao = grupo.Descricao;

            _bancoContext.Grupos.Update(grupoDb);
            _bancoContext.SaveChanges();

            return grupoDb;
        }

        public bool Apagar(int id)
        {
            GrupoModel grupoDb = ListarPorId(id);

            if (grupoDb == null)
            {
                throw new Exception("Houve um erro na deleção do grupo");
            }

            _bancoContext.Grupos.Remove(grupoDb);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
