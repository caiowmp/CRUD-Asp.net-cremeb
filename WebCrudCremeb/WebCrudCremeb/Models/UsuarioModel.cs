using System.ComponentModel.DataAnnotations;

namespace WebCrudCremeb.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Digite o nome do usuário")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Digite o CPF do usuário")]
        public string Cpf { get; set; }
        
        [Required(ErrorMessage = "Digite o telefone do usuário")]
        //Telefone está em formato inteiro
        //[Phone(ErrorMessage = "O celular informado não é válido")]
        public int Telefone { get; set; }
        
        [Required(ErrorMessage = "Digite o email do usuário")]
        [EmailAddress(ErrorMessage = "O email informado não é válido")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Digite o CEP do usuário")]
        public int Cep { get; set; }
        
        [Required(ErrorMessage = "Digite o endereco do usuário")]
        public string Endereco { get; set; }
        
        //Ativo é obtido por meio de uma caixinha de verificação
        //[Required(ErrorMessage = "Marque se o usuário está ativo ou não")]
        public bool Ativo { get; set; }
        
        [Required(ErrorMessage = "Envie o Documento RG do usuário")]
        public string Documento_rg_pdf { get; set; }
        
        [Required(ErrorMessage = "Digite o grupo do usuário")]
        public int Grupo_usuario_id { get; set; }
    }
}
