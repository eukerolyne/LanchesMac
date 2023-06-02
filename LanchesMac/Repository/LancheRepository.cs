using LanchesMac.Data;
using LanchesMac.Models;
using LanchesMac.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;

namespace LanchesMac.Repository
{
    public class LancheRepository : ILancheRepository
    {
        private readonly ApplicationDbContext _context;
        public LancheRepository(ApplicationDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.
                                   Where(l => l.IsLanchePreferido)
                                  .Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}