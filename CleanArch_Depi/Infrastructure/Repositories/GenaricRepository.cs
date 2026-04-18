using Application.Interfaces.IRepositories;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class GenaricRepository<T> : IGenaricRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;
        public GenaricRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
       

    }
}
