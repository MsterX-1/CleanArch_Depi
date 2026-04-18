using Application.Interfaces.IRepositories;
using Application.Interfaces.IUnitOfWork;
using Domain.Models;
using Infrastructure.Database;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IGenaricRepository<User> UserRepository { get; }
        public UnitOfWork(AppDbContext context, IGenaricRepository<User> userRepository)
        {
            _context = context;
            UserRepository = userRepository;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
