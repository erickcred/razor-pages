using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyRazorApp.Pages
{
  public class Categories : PageModel
  {
    public List<Category> ListCategory { get; set; } = new();

    public void OnGet(int skip = 0, int take = 10)
    {
      var temp = new List<Category>();
      for (int i = 0; i <= 100; i++)
      {
        temp.Add(new Category(i, $"Categoria {i}", (i * 2.95M)));
      }
      
      this.ListCategory = temp.Skip(skip).Take(take).ToList();
    }

    
  }
}

public record Category(
  int Id,
  string Title,
  decimal Price
);
