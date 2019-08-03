using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TsSharp.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string Desc { get; set; }

        public string FullDesc { get; set; }

        public string FotoName { get; set; }
    }
}
