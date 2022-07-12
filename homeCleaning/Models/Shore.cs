using homeCleaning.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeCleaning.Models
{
    public class Shore : IShore
    {
        public int id { get; set; }
        public string name { get; set; }
        public string discription { get; set; }
    }
}

