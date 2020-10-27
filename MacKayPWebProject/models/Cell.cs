using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MacKayPWebProject.Models
{
    public class Cell
    {
        public Cell() { }
        public string Value { get; set; }
        public bool Hidden { get; set; }
        public bool Flagged { get; set; }
    }
}
