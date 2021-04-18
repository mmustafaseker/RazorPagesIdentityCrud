using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorCrude.Models
{
    public class Urun
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen ürün adı giriniz.")]
        public string UrunAd { get; set; }

        [Required(ErrorMessage = "Lütfen ürün fiyatını giriniz.")]
        public decimal BirimFiyat { get; set; }

    }
}
