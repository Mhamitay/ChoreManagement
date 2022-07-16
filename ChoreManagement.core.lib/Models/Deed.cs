using ChoreManagement.core.lib.interfaces;
using homeCleaning.Enums;
 
namespace ChoreManagement.core.lib.Models
{
    public class Deed : IDeed
    {
        public int id { get; set; }
        public string name { get; set; }
        public DeedType deedType { get; set; }
    }
}
 