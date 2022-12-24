using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SorteioAPI.Models
{
    public class Participante
    {
        //[JsonIgnore]
        public int Id { get; set; }

        [Required, MaxLength(250)]
        public string Nome{ get; set; }

        [MaxLength(13)]
        public string? Telefone{ get; set; }

        [Required, MaxLength(11)]
        public string Cpf{ get; set; }

        [Required, MaxLength(250)]
        public string Email{ get; set; }

        //[JsonIgnore]
        public string Num_gerado { get; set; }
    }
}
