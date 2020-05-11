using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAZModa.Data;
using MAZModa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MAZModa.Pages
{
    public class RecommendStyleModel : PageModel
    {
        MAZModaDbContext context = new MAZModaDbContext();
        public void OnGet()
        {

        }
        
        
    }
}