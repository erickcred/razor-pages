using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyRazorApp.Pages
{
    public class Index : PageModel
    {
        public List<Category> Categories { get; set; } = new();

        public async Task OnGet()
        {
            
            // await Task.Delay(5000);
            for (int i = 0; i <= 100; i++)
            {
                this.Categories.Add(new Category(i, $"Categoria {i}", (i * 2.95M)));
            }
        }

        public void OnPost()
        {

        }
    }
}

public record Category(
    int Id,
    string Title,
    decimal Price
);
