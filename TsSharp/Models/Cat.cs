using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TsSharp.Models
{
    public class Cat : BaseModel
    {

        public int ParentId { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<Cat> Cats { get; set; }

    }
}
