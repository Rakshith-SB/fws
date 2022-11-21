using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using afraz.Models;

namespace afraz.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly afrazContext _context;

        public ProjectsController(afrazContext context)
        {
            _context = context;
        }

        // GET: Projects
        public async Task<IActionResult> Index()
        {
            var afrazContext = _context.Projects.Include(p => p.Cus).Include(p => p.ProMan);
            return View(await afrazContext.ToListAsync());
        }

        // GET: Projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Projects == null)
            {
                return NotFound();
            }

            var project = await _context.Projects
                .Include(p => p.Cus)
                .Include(p => p.ProMan)
                .FirstOrDefaultAsync(m => m.Pid == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // GET: Projects/Create
        public IActionResult Create()
        {
            ViewData["CusId"] = new SelectList(_context.Customers, "Id", "Id");
            ViewData["ProManid"] = new SelectList(_context.ProjectManagers, "Pmid", "Pmid");
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Pid,CusId,Name,Description,StartDate,EndDate,ProManid")] Project project)
        {
            if (ModelState.IsValid)
            {
                _context.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CusId"] = new SelectList(_context.Customers, "Id", "Id", project.CusId);
            ViewData["ProManid"] = new SelectList(_context.ProjectManagers, "Pmid", "Pmid", project.ProManid);
            return View(project);
        }

        // GET: Projects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Projects == null)
            {
                return NotFound();
            }

            var project = await _context.Projects.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            ViewData["CusId"] = new SelectList(_context.Customers, "Id", "Id", project.CusId);
            ViewData["ProManid"] = new SelectList(_context.ProjectManagers, "Pmid", "Pmid", project.ProManid);
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Pid,CusId,Name,Description,StartDate,EndDate,ProManid")] Project project)
        {
            if (id != project.Pid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(project);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.Pid))
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
            ViewData["CusId"] = new SelectList(_context.Customers, "Id", "Id", project.CusId);
            ViewData["ProManid"] = new SelectList(_context.ProjectManagers, "Pmid", "Pmid", project.ProManid);
            return View(project);
        }

        // GET: Projects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Projects == null)
            {
                return NotFound();
            }

            var project = await _context.Projects
                .Include(p => p.Cus)
                .Include(p => p.ProMan)
                .FirstOrDefaultAsync(m => m.Pid == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Projects == null)
            {
                return Problem("Entity set 'afrazContext.Projects'  is null.");
            }
            var project = await _context.Projects.FindAsync(id);
            if (project != null)
            {
                _context.Projects.Remove(project);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectExists(int id)
        {
          return _context.Projects.Any(e => e.Pid == id);
        }
    }
}
