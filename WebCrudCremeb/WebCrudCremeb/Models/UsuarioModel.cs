namespace WebCrudCremeb.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public int Cep { get; set; }
        public string Endereco { get; set; }
        public bool Ativo { get; set; }
        public string Documento_rg_pdf { get; set; }
        public int Grupo_usuario_id { get; set; }
    }
}
