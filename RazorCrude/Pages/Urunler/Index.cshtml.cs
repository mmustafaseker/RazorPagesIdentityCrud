using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCrude.Data;
using RazorCrude.Models;

namespace RazorCrude.Pages.Urunler
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPostDelete(int id)
        {
            Urun urun = _db.Urunler.Find(id);
            if (urun!=null)
            {
                _db.Remove(urun);
                _db.SaveChanges();
            }
            return RedirectToPage();
        }
    }
}
