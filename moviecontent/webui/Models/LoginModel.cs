using System.ComponentModel.DataAnnotations;

namespace webui.Models
{
    public class LoginModel
    {
        
        [Required(ErrorMessage = "Lütfen email adresinizi giriniz!")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Lütfen geçerli bir e-posta adresi giriniz!")]
        public string email { get; set; }



          [Required(ErrorMessage = "Lütfen parolanızı giriniz!")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Parolanız en az 6 karakter içermeli")]
        public string password { get; set; }
        
    }
}