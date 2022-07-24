using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliMimari.Core
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } // ürünler tablosu ile ilişki.
    }
}
