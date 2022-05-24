using System.ComponentModel.DataAnnotations;

namespace WebCrudCremeb.Models
{
    public class GrupoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite a descrição do grupo")]
        public string Descricao { get; set; }
    }
}
