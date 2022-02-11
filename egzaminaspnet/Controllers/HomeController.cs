using egzaminaspnet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace egzaminaspnet.Controllers
{
    public class HomeController : Controller
    {


        private List<Class> _lista;
        public HomeController()
        {
            _lista = new List<Class>()
            {
                new Class(){Id=1,album="123456",points=10,note="F",data=new DateTime(2022,11,2)},
                 new Class(){Id=2,album="123456",points=50,note="E",data=new DateTime(2022,11,2)},
                  new Class(){Id=3,album="123456",points=65,note="D",data=new DateTime(2022,11,2)},
                   new Class(){Id=4,album="123456",points=75,note="C",data=new DateTime(2022,11,2)}
            };
        }
        public IActionResult Index()



        {
            return View();
        }

        [Route("api/exams")]
        public ActionResult<List<Class>> GetExams()
        {
            return _lista.ToList();
        }



       // public ActionResult<Class> PostExams(Class class){}

    }
}
