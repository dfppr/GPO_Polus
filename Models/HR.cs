
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace App_GPO.Models
{
    public class HR {
        [Display(Name = "Сортировка:")]
        public string? Sort { get; set; }
    }
}
