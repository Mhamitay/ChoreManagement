using ChoreManagement.core.lib.interfaces;

namespace ChoreManagement.core.lib.Models
{
    public class Chore : IChore
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? discription { get; set; }
    }
}

