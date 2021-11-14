using System.ComponentModel.DataAnnotations;

namespace PlantManagment.Web.Models
{
    public class AccountViewModel
    {
        [Required(ErrorMessage = "Не указан логин")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Не указан пароль")]
        public string Password { get; set; }
        
    }
}
