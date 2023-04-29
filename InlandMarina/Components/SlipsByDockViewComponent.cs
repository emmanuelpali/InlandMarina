//using InlandMarina.Data;
//using InlandMarina.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace InlandMarina.Components
//{
//    public class SlipsByDockViewComponent : ViewComponent
//    {
//        private InlandMarinaContext _context; // context object

//        // constructor with dependency injection
//        public SlipsByDockViewComponent(InlandMarinaContext context)
//        {
//            _context = context;
//        }

//        public async Task<IViewComponentResult> InvokeAsync(string dockID) // dock ID
//        {
            
//            List<Slip> slips = null;
//            if (dockID == "All")
//            {
//                slips = SlipManager.GetSlips(_context);
//            }
//            else // specific dock
//            {
//                //int DockID = Convert.ToInt32(id);
//                slips = SlipManager.GetSlipsByDock(_context, Convert.ToInt32(dockID));
//            }
//            return View(slips); // in Views/Shared/Components/SlipsByDock/Default.cshtml
//        }
//    }
//}
