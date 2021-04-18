using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RazorCrude.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorCrude.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Urun> Urunler{ get; set; }
    }
}
