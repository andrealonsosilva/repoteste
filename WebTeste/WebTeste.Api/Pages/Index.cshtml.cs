using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebTeste.Api.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Random _random;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _random = new Random();
        }

        public void OnGet()
        {

        }
    }
}