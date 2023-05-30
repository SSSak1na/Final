using System.ComponentModel.DataAnnotations;

namespace FinalProject.ViewModels.Account
{
    public class RegisterVM
    {

        [Required]
        [MaxLength(15)]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string Surname { get; set; }
        [Required]
        public string Username { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string CheckPassword { get; set; }

    }
}
