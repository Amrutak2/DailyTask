using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RollOff.Models;

namespace RollOff.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class SupplyDatumsController : Controller
    {
        private readonly ProjectContext _context;

        public SupplyDatumsController(ProjectContext context)
        {
            _context = context;
        }

        // GET: SupplyDatums
        public async Task<IActionResult> Index()
        {
            return View(await _context.SupplyData.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Index(string EmpSearch)
        {
            ViewData["GetDetails"] = EmpSearch;
            var empquery = from x in _context.SupplyData select x;
            if (!string.IsNullOrEmpty(EmpSearch))
            {
                empquery = empquery.Where(x => x.Name.Contains(EmpSearch) || x.GlobalGroupId.ToString().Contains(EmpSearch) || x.Email.Contains(EmpSearch));
            }
            return View(await empquery.AsNoTracking().ToListAsync());
        }
       

        //*************************************************************
    // GET: SupplyDatums/Details/5
    //public async Task<IActionResult> Details(double? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var supplyDatum = await _context.SupplyData
    //            .FirstOrDefaultAsync(m => m.GlobalGroupId == id);
    //        if (supplyDatum == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(supplyDatum);
    //    }
        //*****************************************************************
        // GET: SupplyDatums/Create
        public IActionResult Create()
        {
            return View();
        }

       
        public IActionResult RollOff()
        {
            List<SelectListItem> Roll = new()
            {
                new SelectListItem { Value = "select", Text = "--select--" },
                new SelectListItem { Value = "1", Text = "Project Closure" },
                new SelectListItem { Value = "2", Text = "Maternity Leave" },
                new SelectListItem { Value = "3", Text = "Resigned" },
                new SelectListItem { Value = "4", Text = "Performance Issue" },
                new SelectListItem { Value = "5", Text = "HR Case" },
                new SelectListItem { Value = "6", Text = "People Skill" },
                new SelectListItem { Value = "7", Text = "Automation" },
                new SelectListItem { Value = "8", Text = "Quality" },
                new SelectListItem { Value = "9", Text = "New Delivery Model" },
                new SelectListItem { Value = "10", Text = "Labour(Work Force Productivity)" },
                new SelectListItem { Value = "11", Text = "Client Budget Issue" },
                new SelectListItem { Value = "12", Text = "Other reason" }
            };

            

            //assigning SelectListItem to view Bag
            ViewBag.RollOff = Roll;
           
            //return View(await _context.Rolls.ToListAsync());
           return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RollOff([Bind("EmployeeNo,Name,LocalGrade,PrimarySkill,ProjectCode,ProjectName,ProjectCode,ProjectName,Practice,RollOffEndDate,ReasonForRollOff,ThisReleaseNeedsBackfillIsBackfilled,PerformanceIssue,Resigned,UnderProbation,LongLeave,TechnicalSkills,Communication,RoleCompetencies,Remarks,RelevantExperienceYrs")] Roll rollOff)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rollOff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(RollOffFormData));
            }
            return View(rollOff);
        }

        public async Task<IActionResult> RollOffFormData()
        {
            return View(await _context.Rolls.ToListAsync());
        }

        public IActionResult Feedback()
        {
            return View();

        }
       // [HttpPost]
        //[ValidateAntiForgeryToken]
        
        //***************************************************************
        // POST: SupplyDatums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
       
        //public async Task<IActionResult> Create([Bind("Country,GlobalGroupId,EmployeeNo,Name,LocalGrade,MainClient,Email,JoiningDate,ProjectCode,ProjectName,ProjectStartDate,ProjectEndDate,PeopleManagerPerformanceReviewer,Practice,PspName,NewGlobalPractice,OfficeCity")] SupplyDatum supplyDatum)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(supplyDatum);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(supplyDatum);
        //}
        //******************************************************************
        // GET: SupplyDatums/Edit/5
        //public async Task<IActionResult> Edit(double? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var supplyDatum = await _context.SupplyData.FindAsync(id);
        //    if (supplyDatum == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(supplyDatum);
        //}
        //*************************************************************
        // POST: SupplyDatums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //******************************************************
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(double id, [Bind("Country,GlobalGroupId,EmployeeNo,Name,LocalGrade,MainClient,Email,JoiningDate,ProjectCode,ProjectName,ProjectStartDate,ProjectEndDate,PeopleManagerPerformanceReviewer,Practice,PspName,NewGlobalPractice,OfficeCity")] SupplyDatum supplyDatum)
        //{
        //    if (id != supplyDatum.GlobalGroupId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(supplyDatum);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!SupplyDatumExists(supplyDatum.GlobalGroupId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(supplyDatum);
        //}
        //*******************************************************
        // GET: SupplyDatums/Delete/5
        //public async Task<IActionResult> Delete(double? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var supplyDatum = await _context.SupplyData
        //        .FirstOrDefaultAsync(m => m.GlobalGroupId == id);
        //    if (supplyDatum == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(supplyDatum);
        //}
        //***************************************************
        // POST: SupplyDatums/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(double id)
        //{
        //    var supplyDatum = await _context.SupplyData.FindAsync(id);
        //    _context.SupplyData.Remove(supplyDatum);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
        //***************************************************
        private bool SupplyDatumExists(double id)
        {
            return _context.SupplyData.Any(e => e.GlobalGroupId == id);
        }

        
    
    }
}
