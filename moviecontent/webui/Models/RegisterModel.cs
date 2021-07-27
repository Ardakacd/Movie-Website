using System.ComponentModel.DataAnnotations;

namespace webui.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz!")]
        [MinLength(2,ErrorMessage ="Adınız geçerli değil(En az 3 harfli olmalı!)")]
        public string firstName { get; set; }
        

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz!")]
        [MinLength(2,ErrorMessage ="Soyadınız geçerli değil(En az 3 harfli olmalı!)")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz!")]
        public string userName { get; set; }


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