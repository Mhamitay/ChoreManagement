using HomeCleaningLib.Enums;
using HomeCleaningLib.Models;

namespace HomeCleaningLib.interfaces
{
    public interface IDeed
    {
        DeedType deedType { get; set; }
        int id { get; set; }
        string name { get; set; }
    }
}