using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Administrativo.Contexts;
using Administrativo.Models;

namespace Administrativo.Controllers
{
    public class LancamentosController : Controller
    {
        private readonly LancamentoContext _context;

        public LancamentosController(LancamentoContext context)
        {
            _context = context;
        }

        // GET: Lancamentoes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Lancamentos.ToListAsync());
        }

        // GET: Lancamentoes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Lancamentos == null)
            {
                return NotFound();
            }

            var lancamento = await _context.Lancamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lancamento == null)
            {
                return NotFound();
            }

            return View(lancamento);
        }

        // GET: Lancamentoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lancamentoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DesLancament,IndEntradaSaida,ValLancamento,DtaLancamento,DtaCreateAt,DtaUpdatedAt")] Lancamento lancamento)
        {
            if (ModelState.IsValid)
            {
                lancamento.DtaCreateAt = DateTime.Now;
                lancamento.DtaUpdatedAt = DateTime.Now;
                _context.Add(lancamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lancamento);
        }

        // GET: Lancamentoes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Lancamentos == null)
            {
                return NotFound();
            }

            var lancamento = await _context.Lancamentos.FindAsync(id);
            if (lancamento == null)
            {
                return NotFound();
            }
            
            return View(lancamento);
        }

        // POST: Lancamentoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,DesLancament,IndEntradaSaida,ValLancamento,DtaLancamento,DtaCreateAt,DtaUpdatedAt")] Lancamento lancamento)
        {
            if (id != lancamento.Id)
            {
                return NotFound();
            }
            
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lancamento);
                    lancamento.DtaUpdatedAt = DateTime.Now;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LancamentoExists(lancamento.Id))
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
            return View(lancamento);
        }

        // GET: Lancamentoes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.Lancamentos == null)
            {
                return NotFound();
            }

            var lancamento = await _context.Lancamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lancamento == null)
            {
                return NotFound();
            }

            return View(lancamento);
        }

        // POST: Lancamentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.Lancamentos == null)
            {
                return Problem("Entity set 'LancamentoContext.Lancamentos'  is null.");
            }
            var lancamento = await _context.Lancamentos.FindAsync(id);
            if (lancamento != null)
            {
                _context.Lancamentos.Remove(lancamento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LancamentoExists(long id)
        {
          return _context.Lancamentos.Any(e => e.Id == id);
        }


        // GET: Lancamentoes/Create
        public IActionResult Report()
        {
            var report = new RelatotioDiario(new List<Lancamento>());
            report.DiaReferencia = DateTime.Now;
            return View(report);
        }

        [HttpPost, ActionName("Report")]
        public async Task<IActionResult> Report(DateTime diaReferencia)
        {
            var inicioDia = new DateTime(diaReferencia.Year, diaReferencia.Month, diaReferencia.Day);
            var lancametos = _context.Lancamentos
                .Where(lan => inicioDia <= lan.DtaLancamento 
                && inicioDia.AddHours(24) >= lan.DtaLancamento)
                .ToList()
                ?? new List<Lancamento>();

            var report = new RelatotioDiario(lancametos);
            if (lancametos.Count > 0) {
                report.ValEntrada = lancametos
                    .FindAll(lan => lan.IndEntradaSaida == TipoTransacao.Entrada)
                    .Select(lan => lan.ValLancamento)
                    .Sum(); 
                report.ValSaida = lancametos
                    .FindAll(lan => lan.IndEntradaSaida == TipoTransacao.Saida)
                    .Select(lan => lan.ValLancamento)
                    .Sum();
                report.Saldo = report.ValEntrada - report.ValSaida;
                report.DiaReferencia = inicioDia;
            }
            return View(report);
        }
    }
}
