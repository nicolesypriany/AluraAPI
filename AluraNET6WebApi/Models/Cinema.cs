using System.ComponentModel.DataAnnotations;

namespace AluraNET6WebApi.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatorio")]
        public string Nome { get; set; }


    }
}
