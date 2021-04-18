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
    public class YeniModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Urun Urun{ get; set; }
        public YeniModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Urunler.Add(Urun);
                _db.SaveChanges();
                return RedirectToPage("/Urunler/Index");
            }
            return Page();
        }
    }
}
