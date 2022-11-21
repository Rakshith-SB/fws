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
    public class ProjectManagersController : Controller
    {
        private readonly afrazContext _context;

        public ProjectManagersController(afrazContext context)
        {
            _context = context;
        }

        // GET: ProjectManagers
        public async Task<IActionResult> Index()
        {
              return View(await _context.ProjectManagers.ToListAsync());
        }

        // GET: ProjectManagers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProjectManagers == null)
            {
                return NotFound();
            }

            var projectManager = await _context.ProjectManagers
                .FirstOrDefaultAsync(m => m.Pmid == id);
            if (projectManager == null)
            {
                return NotFound();
            }

            return View(projectManager);
        }

        // GET: ProjectManagers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectManagers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Pmid,Email,Name,Mobile,Address,City,State,Pincode,Password,ConfirmPassword")] ProjectManager projectManager)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectManager);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projectManager);
        }

        // GET: ProjectManagers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProjectManagers == null)
            {
                return NotFound();
            }

            var projectManager = await _context.ProjectManagers.FindAsync(id);
            if (projectManager == null)
            {
                return NotFound();
            }
            return View(projectManager);
        }

        // POST: ProjectManagers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Pmid,Email,Name,Mobile,Address,City,State,Pincode,Password,ConfirmPassword")] ProjectManager projectManager)
        {
            if (id != projectManager.Pmid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectManager);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectManagerExists(projectManager.Pmid))
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
            return View(projectManager);
        }

        // GET: ProjectManagers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProjectManagers == null)
            {
                return NotFound();
            }

            var projectManager = await _context.ProjectManagers
                .FirstOrDefaultAsync(m => m.Pmid == id);
            if (projectManager == null)
            {
                return NotFound();
            }

            return View(projectManager);
        }

        // POST: ProjectManagers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProjectManagers == null)
            {
                return Problem("Entity set 'afrazContext.ProjectManagers'  is null.");
            }
            var projectManager = await _context.ProjectManagers.FindAsync(id);
            if (projectManager != null)
            {
                _context.ProjectManagers.Remove(projectManager);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectManagerExists(int id)
        {
          return _context.ProjectManagers.Any(e => e.Pmid == id);
        }
    }
}
