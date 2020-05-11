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
    public class AddStyleModel : PageModel
    {
        MAZModaDbContext context = new MAZModaDbContext();
        public void OnGet()
        {

        }
        public void OnPost(Style _style)
        {
            context.Style.Add(_style);
            context.SaveChanges();
        }
        public void Delete(int _Id)
        {
            Style deletedStyle = context.Style.Find(_Id);
            context.Remove(deletedStyle);
            context.SaveChanges();
        }
    }
}