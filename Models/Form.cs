using DocuSign.eSign.Model;
using System.ComponentModel.DataAnnotations;

namespace App_GPO.Models
{
    public class Form
    {
        [Display(Name = "ФИО")]
        [Required(ErrorMessage = "Заполните поле")]
        public string? FullName { get; set; }

        [Display(Name = "Дата рождения")]
        [Required(ErrorMessage = "Заполните поле")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Образование")]
        [Required(ErrorMessage = "Заполните поле")]
        public string? Education { get; set; }

        [Display(Name = "Дополнительное образование")]
        [Required(ErrorMessage = "Заполните поле")]
        public string? AddEducation { get; set; }

        [Display(Name = "Опыт работы")]
        [Required(ErrorMessage = "Заполните поле")]
        public string? Experience { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Заполните поле")]
        public string? Email { get; set; }

        [Display(Name = "Номер телефона")]
        [Required(ErrorMessage = "Заполните поле")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "Дополнительная информация")]
        public string? AddInfo { get; set; }
    }

}
