using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliMimari.Core
{
   public class Product : BaseEntity
    {
        public string MyProperty { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; } //Fk
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }
    }
}
