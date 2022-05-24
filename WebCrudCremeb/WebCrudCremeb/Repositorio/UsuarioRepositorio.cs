using WebCrudCremeb.Data;
using WebCrudCremeb.Models;

namespace WebCrudCremeb.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _bancoContext;
        public UsuarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public UsuarioModel ListarPorId(int id)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public List<UsuarioModel> BuscarTodos()
        {
            return _bancoContext.Usuarios.ToList();
        }

        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel usuarioDb = ListarPorId(usuario.Id);

            if(usuarioDb == null)
            {
                throw new Exception("Houve um erro na atualização do usuário");
            }
            else
            {
                usuarioDb.Nome = usuario.Nome;
                usuarioDb.Cpf = usuario.Cpf;
                usuarioDb.Telefone = usuario.Telefone;
                usuarioDb.Email = usuario.Email;
                usuarioDb.Cep = usuario.Cep;
                usuarioDb.Endereco = usuario.Endereco;
                usuarioDb.Ativo = usuario.Ativo;
                usuarioDb.Documento_rg_pdf = usuario.Documento_rg_pdf;
                usuarioDb.Grupo_usuario_id = usuario.Grupo_usuario_id;
            }

            _bancoContext.Usuarios.Update(usuarioDb);
            _bancoContext.SaveChanges();

            return usuarioDb;
        }
    }
}
