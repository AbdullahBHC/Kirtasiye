using System;
using System.Collections.Generic;
using System.Text;

namespace Kırtasiye.Models
{
    public class Kategori
    {
        public string UrunKategorisi { get; set; }

        public override string ToString()
        {
            return UrunKategorisi;
        }

    }
}
