using App_GPO.Models;
using System.Diagnostics;
using DocuSign.eSign.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing.Constraints;

namespace App_GPO.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] 
        public IActionResult Check(Form form) 
        {
            if(ModelState.IsValid)
            {
                //Сохранение данных в файл
                string fileName = "..\\data.txt";

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine("Заявка на должность: " + Request.Form["Vacancy"]);
                    writer.WriteLine("ФИО: " + Request.Form["FullName"]);
                    writer.WriteLine("Дата рождения: " + Request.Form["Birthday"]);
                    writer.WriteLine("Образование: " + Request.Form["Education"]);
                    writer.WriteLine("Дополнительное образвание: " + Request.Form["AddEducation"]);
                    writer.WriteLine("Опыт работы: " + Request.Form["Experience"]);
                    writer.WriteLine("Email: " + Request.Form["Email"]);
                    writer.WriteLine("Номер телефона: " + Request.Form["PhoneNumber"]);
                    writer.WriteLine("Наличие других компетенций:" + Request.Form["AddInfo"]);
                    writer.WriteLine("Ссылка на социальную сеть:" + Request.Form["Social"]);
                }
            }
            return Content("Резюме отправлено", "form/html");
        }
    }
}
