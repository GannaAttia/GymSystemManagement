using GymSystemManagement.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;

namespace GymSystemManagement.Controllers
{
    public class PlanController :Controller 
    {
        private GymDbContext context = new GymDbContext();
        public IActionResult IndexTest()
        {
            return View();
        }

        public async Task<IActionResult> Index() 
        { 
            var plans = await context.Plan.ToListAsync();
            return View(plans);
        }

    }
}
