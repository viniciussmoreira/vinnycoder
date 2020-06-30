using Microsoft.AspNetCore.Mvc;

namespace mvc1.Controllers
{
    public class ProdutoController : Controller
    {
        public string Index()
        {
            var https = HttpContext.Request.IsHttps;
            var caminho = HttpContext.Request.Path;
            var status = HttpContext.Response.StatusCode;
            var conexao = HttpContext.Connection.ToString();

            return "Index da Produto\r\n" + https + "\r\n" + caminho + "\r\n" + status + "\r\n" + conexao;
        }

        public IActionResult Detalhe()
        {
            //return RedirectToAction("Index", "Home",new { pagina = 1, ordem = "nome" });
            //var pessoa = new { ID = 1, Nome = "Vinicius" };
            //return new ObjectResult(pessoa); teste

            return View();                                                                                                                                                  
        }
    }
}