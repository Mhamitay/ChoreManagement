using HomeCleaningLib.interfaces;

namespace HomeCleaningLib.Models
{
    public class kid : Ikid
    {
        public int id { get; set; } = 0;
        public string name { get; set; }
        public int parentId { get; set; }
    }
}