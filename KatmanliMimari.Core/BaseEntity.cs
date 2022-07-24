using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliMimari.Core
{
    // abstract classlar  projedeki  ortak metotlar ve prob lar için kullanılır.
    public abstract class BaseEntity 
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
