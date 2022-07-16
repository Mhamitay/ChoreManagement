
using ChoreManagement.core.lib.interfaces;

namespace ChoreManagement.core.lib.Models
{
    public class kid : Ikid
    {
        public int id { get; set; } = 0;
        public string name { get; set; }
        public int parentId { get; set; }
    }
}