using SozlesmeKayitIslemleri.Models.Guncelleme;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SozlesmeKayitIslemleri.Models
{
    public class SozlesmeDBContext:DbContext
    {
        public SozlesmeDBContext():base("name=BaglantiCumlesi")
        {

        }
        public DbSet<Sozlesme>  Sozlesme { get; set; }
    }
}