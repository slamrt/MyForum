using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
