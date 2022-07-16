using homeCleaning.Enums;
 
namespace ChoreManagement.core.lib.interfaces
{
    public interface IDeed
    {
        DeedType deedType { get; set; }
        int id { get; set; }
        string name { get; set; }
    }
}