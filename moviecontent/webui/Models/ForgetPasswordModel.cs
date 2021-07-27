using System.ComponentModel.DataAnnotations;

namespace webui.Models
{
    public class ForgetPasswordModel
    {
        public string token { get; set; }



        [Required(ErrorMessage = "Lütfen email adresinizi giriniz!")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Lütfen geçerli bir e-posta adresi giriniz!")]
        public string email { get; set; }

        [Required(ErrorMessage = "Lütfen parolanızı giriniz!")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Parolanız en az 6 karakter içermeli")]
        public string password { get; set; }

        [Required(ErrorMessage = "Lütfen parolanızı tekrardan giriniz !")]
        [DataType(DataType.Password)]
        [Compare("password",ErrorMessage ="Girdiğiniz parola ile eşleşmiyor")]

        public string rePassword { get; set; }
    }
        
    }
