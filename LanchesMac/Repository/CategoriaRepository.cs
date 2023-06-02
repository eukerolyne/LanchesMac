using LanchesMac.Data;
using LanchesMac.Models;
using LanchesMac.Repository.Interface;
using System;

namespace LanchesMac.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoriaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}