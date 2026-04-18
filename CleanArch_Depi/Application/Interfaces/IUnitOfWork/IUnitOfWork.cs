using System;
using System.Collections.Generic;
using System.Text;
using Application.Interfaces.IRepositories;
using Domain.Models;

namespace Application.Interfaces.IUnitOfWork
{
    public interface IUnitOfWork
    {
        IGenaricRepository<User> UserRepository { get; }
        Task<int> CompleteAsync();
    }
}
