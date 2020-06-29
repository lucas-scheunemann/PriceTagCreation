using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CadastroDeEtiquetas.Data;
using CadastroDeEtiquetas.Models;

namespace CadastroDeEtiquetas.Controllers
{
    public class EtiquetasController : Controller
    {
        private readonly CadastroDeEtiquetasContext _context;

        public EtiquetasController(CadastroDeEtiquetasContext context)
        {
            _context = context;
        }

        // GET: Etiquetas
        public async Task<IActionResult> Index()
        {
            var cadastroDeEtiquetasContext = _context.Etiquetas.Include(e => e.Formulario);
            return View(await cadastroDeEtiquetasContext.ToListAsync());
        }

        // GET: Etiquetas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var etiqueta = await _context.Etiquetas
                .Include(e => e.Formulario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (etiqueta == null)
            {
                return NotFound();
            }

            return View(etiqueta);
        }

        // GET: Etiquetas/Create
        public IActionResult Create()
        {
            ViewData["FormularioId"] = new SelectList(_context.Formularios, "FormularioId", "FormularioId");
            return View();
        }

        // POST: Etiquetas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FormularioId,Linguagem,Tipo,Descricao,LarguraImpressao,Densidade,Velocidade,Imagem,EstruturaEtiqueta")] Etiqueta etiqueta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(etiqueta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FormularioId"] = new SelectList(_context.Formularios, "FormularioId", "FormularioId", etiqueta.FormularioId);
            return View(etiqueta);
        }

        // GET: Etiquetas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var etiqueta = await _context.Etiquetas.FindAsync(id);
            if (etiqueta == null)
            {
                return NotFound();
            }
            ViewData["FormularioId"] = new SelectList(_context.Formularios, "FormularioId", "FormularioId", etiqueta.FormularioId);
            return View(etiqueta);
        }

        // POST: Etiquetas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FormularioId,Linguagem,Tipo,Descricao,LarguraImpressao,Densidade,Velocidade,Imagem,EstruturaEtiqueta")] Etiqueta etiqueta)
        {
            if (id != etiqueta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(etiqueta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EtiquetaExists(etiqueta.Id))
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
            ViewData["FormularioId"] = new SelectList(_context.Formularios, "FormularioId", "FormularioId", etiqueta.FormularioId);
            return View(etiqueta);
        }

        // GET: Etiquetas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var etiqueta = await _context.Etiquetas
                .Include(e => e.Formulario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (etiqueta == null)
            {
                return NotFound();
            }

            return View(etiqueta);
        }

        // POST: Etiquetas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var etiqueta = await _context.Etiquetas.FindAsync(id);
            _context.Etiquetas.Remove(etiqueta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EtiquetaExists(int id)
        {
            return _context.Etiquetas.Any(e => e.Id == id);
        }
    }
}
