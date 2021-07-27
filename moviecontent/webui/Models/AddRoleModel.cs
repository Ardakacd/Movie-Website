using System.ComponentModel.DataAnnotations;

namespace webui.Models
{
    public class AddRoleModel
    {

        [Required(ErrorMessage ="Lütfen rol adını giriniz.")]
        [MinLength(3,ErrorMessage ="Rol en az 3 harfli olmalıdır.")]
        public string RoleName { get; set; }
    }
}