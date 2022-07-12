using homeCleaning.Enums;
using homeCleaning.interfaces;

namespace homeCleaning.Models
{
    public class Deed : IDeed
    {
        public int id { get; set; }
        public string name { get; set; }
        public DeedType deedType { get; set; }
    }
}
 