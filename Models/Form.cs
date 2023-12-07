using System.ComponentModel.DataAnnotations;

namespace App_GPO.Models
{
    public class Form
    {
        [Display(Name = "ФИО")]
        [Required(ErrorMessage = "Заполните поле")]
        public string? FullName { get; set; }

        [Display(Name = "Возраст")]
        [Required(ErrorMessage = "Заполните поле")]
        public int Age { get; set; }

        [Display(Name = "Образование")]
        [Required(ErrorMessage = "Заполните поле")]
        public string? Education { get; set; }

        [Display(Name = "Дополнительное образование (курсы повышения квалицикации, профессиональная переподготовка)")]
        [Required(ErrorMessage = "Заполните поле")]
        public string? AddEducation { get; set; }

        [Display(Name = "Компетенции")]
        [Required(ErrorMessage = "Заполните поле")]
        public string? Competence { get; set; }

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
