using System;
using System.Collections.Generic;
using System.Text;

namespace Kırtasiye.Models
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        public decimal UrunAlisFiyati { get; set; }
        public decimal UrunSatisFiyati { get; set; }
        public int UrunAdeti { get; set; }
        public Kategori UrunKategorisi { get; set; }

        public override string ToString() => $"{UrunAdi} {UrunSatisFiyati}{"₺  ~>"} {UrunKategorisi}";
    }
}
