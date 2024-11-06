using System.ComponentModel.DataAnnotations;

namespace AluraNET6WebApi.Data.Dtos
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatorio.")]
        public string Nome { get; set; }
    }
}
