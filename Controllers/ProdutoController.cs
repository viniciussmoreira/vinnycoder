using Microsoft.AspNetCore.Mvc;
using System;

namespace mvc1.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index(int? pagina, string ordem)
        {
            if (!pagina.HasValue)
                pagina = 1;

            if (string.IsNullOrEmpty(ordem))
                ordem = "Nome";

            return Content(String.Format("pagina={0}&ordem={1}", pagina, ordem));
        }
        public IActionResult Detalhe()
        {
            //return RedirectToAction("Index", "Home",new { pagina = 1, ordem = "nome" });
            //var pessoa = new { ID = 1, Nome = "Vinicius" };
            //return new ObjectResult(pessoa); teste

            return View();
        }

        public IActionResult Edit(int id)
        {
            return Content("Valor do Id = " + id);
        }
    }
}