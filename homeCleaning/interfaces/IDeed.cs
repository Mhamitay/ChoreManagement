using homeCleaning.Enums;
using homeCleaning.Models;

namespace homeCleaning.interfaces
{
    public interface IDeed
    {
        DeedType deedType { get; set; }
        int id { get; set; }
        string name { get; set; }
    }
}