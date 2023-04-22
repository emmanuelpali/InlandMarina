using InlandMarina.Data;

namespace InlandMarina.Models
{
    public class DockManager
    {
        public static List<Dock> GetDocks(InlandMarinaContext db) // dependency injection
        {
            List<Dock>? docks = null;

            docks = db.Docks.ToList();

            return docks;
        }
    }
}
