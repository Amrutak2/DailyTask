using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RollOff.Models;

namespace RollOff.Controllers
{
    public class RollsController : Controller
    {
        private readonly ProjectContext _context;

        public RollsController(ProjectContext context)
        {
            _context = context;
        }

        // GET: Rolls
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rolls.ToListAsync());
        }

        // GET: Rolls/Details/5
        public async Task<IActionResult> Details(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roll = await _context.Rolls
                .FirstOrDefaultAsync(m => m.EmployeeNo == id);
            if (roll == null)
            {
                return NotFound();
            }

            return View(roll);
        }

        // GET: Rolls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rolls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeNo,Name,LocalGrade,PrimarySkill,ProjectCode,ProjectName,Practice,RollOffEndDate,ReasonForRollOff,ThisReleaseNeedsBackfillIsBackfilled,PerformanceIssue,Resigned,UnderProbation,LongLeave,TechnicalSkills,Communication,RoleCompetencies,Remarks,RelevantExperienceYrs")] Roll roll)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roll);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roll);
        }

        // GET: Rolls/Edit/5
        public async Task<IActionResult> Edit(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roll = await _context.Rolls.FindAsync(id);
            if (roll == null)
            {
                return NotFound();
            }
            return View(roll);
        }

        // POST: Rolls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(double id, [Bind("EmployeeNo,Name,LocalGrade,PrimarySkill,ProjectCode,ProjectName,Practice,RollOffEndDate,ReasonForRollOff,ThisReleaseNeedsBackfillIsBackfilled,PerformanceIssue,Resigned,UnderProbation,LongLeave,TechnicalSkills,Communication,RoleCompetencies,Remarks,RelevantExperienceYrs")] Roll roll)
        {
            if (id != roll.EmployeeNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roll);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RollExists(roll.EmployeeNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(roll);
        }

        // GET: Rolls/Delete/5
        public async Task<IActionResult> Delete(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roll = await _context.Rolls
                .FirstOrDefaultAsync(m => m.EmployeeNo == id);
            if (roll == null)
            {
                return NotFound();
            }

            return View(roll);
        }

        // POST: Rolls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(double id)
        {
            var roll = await _context.Rolls.FindAsync(id);
            _context.Rolls.Remove(roll);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RollExists(double id)
        {
            return _context.Rolls.Any(e => e.EmployeeNo == id);
        }
    }
}
