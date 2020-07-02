using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvc_core.Controllers
{
    [Route("[controller]/[action]")]
    [Route("")]
    public class TesteController : Controller
    {
        public IActionResult Index()
        {

            @ViewData["msg"] = "Sou a Index do TesteController";

            ViewData["data"] = new DateTime(2020, 10, 30);
            ViewData["endereco"] = new Endereco()
            {
                Nome = "Vinicius",
                Cidade = "Santos",
                Estado = "Sp",
                Rua = "Pastor Alb. Augusto"
            };


            return View();
    }
}
}
