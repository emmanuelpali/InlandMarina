using Microsoft.EntityFrameworkCore;
using InlandMarina.Data;

namespace InlandMarina.Models
{
    public class SlipManager
    {
        public static List<Slip> GetSlips(InlandMarinaContext db) // dependency injection
        {
            List<Slip> slips = null;
            
            List<int> leasedSlipsIDS = db.Leases.Select(l => l.SlipID).ToList();

            slips = db.Slips.Include(d => d.Dock).Where(s => !leasedSlipsIDS.Contains(s.ID)).ToList();
            
            return slips;
        }

        public static List<Slip> GetSlipsByDock(InlandMarinaContext db, int dockId)
        {
         
            List<Slip> slips = db.Slips.Where(s => s.DockID == dockId).
                Include(m => m.Dock).OrderBy(m => m.ID).ToList();
            return slips;
        }
    }

}

