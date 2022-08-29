using System.ComponentModel.DataAnnotations;

namespace ASP_Identity.Models
{
    public class User
    {
        [Required]
        [Display(Name = "Nombre *")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Apellidos *")]
        public string Apellidos { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo laboral *")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
        public string ConfirmPassword { get; set; }
    }
}
