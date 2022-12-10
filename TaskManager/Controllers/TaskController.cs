using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace TaskManager.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public TaskController(TaskManagerDbcontext context)
        {

        }

        protected void ButtonDelete(object sender, EventArgs e)
        {


        }
        protected void ButtonAdd(object sender, EventArgs e)
        {


        }
    }
}
