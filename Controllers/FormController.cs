using App_GPO.Models;
using System.Diagnostics;
using DocuSign.eSign.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace App_GPO.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            //string[] source = {"Item 1", "Item 2", "Item 3", "Item 4", "Item 5", };
            //SelectList selectlist = new SelectList(source, source[2]);
            //ViewBag.SelectItems = SelectList;
            return View();
        }

        [HttpPost] 
        public IActionResult Check(Form form)
        {
            if(ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");
        }

    }
}
