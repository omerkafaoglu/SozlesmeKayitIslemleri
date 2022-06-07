using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.IO;

namespace SozlesmeKayitIslemleri.Models
{
    public class Sozlesme
    {
        [Key]
        [MaxLength(500)]
        [Required]
        public string SicilNumarasi { get; set; }
        [Required]
        public string TCVergiKimlikNo { get; set; }
        [Required]
        public string UnvanAdSoyad { get; set; }
        public DateTime BaslangicTarihi { get; set; }

        public DateTime BitisTarihi { get; set; }
        [Required]
        public string Durumu { get; set; } //= { "Açık", "Normal Yürüyor", "Onayda", "Kapalı" };
        [Required]
        public string SozlesmeTuru { get; set; } //= { "Kamu", "Özel" };
        public string Aciklama { get; set; }
        public string TalepNumarasi { get; set; }  
        public DateTime GelenEvrakTarihi { get; set; }
        public int GelenEvrakSayisi { get; set; }
        public DateTime OlurTarihi { get; set; }
        public int OlurSayisi { get; set; }
        
        public string Dosya { get; set; }




    }
}