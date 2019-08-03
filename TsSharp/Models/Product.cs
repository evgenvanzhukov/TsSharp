using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TsSharp.Models
{
    public class Product : BaseModel
    {
        public decimal Price { get; set; }

        public bool IsSpecial  { get; set; }

        public string  FotoMin { get; set; }

        public List<Prop> Props { get; set; }

        public int CatId { get; set; }

        public Product()
        {
            Props = new List<Prop>();
        }
    }
}
