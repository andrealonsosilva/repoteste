using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebTeste.Api.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Random _random;
        private readonly string texto;
        private readonly string MSGCAGADA = "Errooou";

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _random = new Random();
            texto = "Teste de decoração de PR_1";
        }

        public void OnGet()
        {

        }
    }
}