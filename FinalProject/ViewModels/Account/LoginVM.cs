using System.ComponentModel.DataAnnotations;

namespace FinalProject.ViewModels.Account
{
    public class LoginVM
    {
        [Required]

        public string UserNameorEmail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
