using LanchesBR.Context;
using LanchesBR.Models;
using LanchesBR.Repositories.Interfaces;

namespace LanchesBR.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
