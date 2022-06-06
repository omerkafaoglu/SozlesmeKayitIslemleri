using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.IO;

namespace SozlesmeKayitIslemleri.Models.Guncelleme
{
    public class Sozlesme
    {
        [Key]
        [MaxLength(500)]
        public string SicilNumarasi { get; set; }
        public string TCVergiKimlikNo { get; set; }
        public string UnvanAdSoyad { get; set; }
        public DateTime BaslangicTarihi { get; set; }

        public DateTime BitisTarihi { get; set; }
        public string[] Durumu = { "Açık", "Normal Yürüyor", "Onayda", "Kapalı" };
        public string[] SozlesmeTuru = { "Kamu", "Özel" };
        public string Aciklama { get; set; }
        public string TalepNumarasi { get; set; }  
        public DateTime GelenEvrakTarihi { get; set; }
        public int GelenEvrakSayisi { get; set; }
        public DateTime OlurTarihi { get; set; }
        public int OlurSayisi { get; set; }
        




    }
}