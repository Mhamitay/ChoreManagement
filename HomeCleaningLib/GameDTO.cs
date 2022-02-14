using HomeCleaningLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCleaningLib
{
    public class GameDTO
    {
        public IDictionary<int, string> playersWithNumbers { get; set; }
        public IDictionary<int, Shore> shoresWithNumbers { get; set; }
        
    }
}
