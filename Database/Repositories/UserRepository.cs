using Microsoft.EntityFrameworkCore;
using GestorDePacientes.Core.Application.Helpers;
using GestorDePacientes.Core.Application.Interfaces.Repositories;
using GestorDePacientes.Core.Application.ViewModels.User;
using GestorDePacientes.Core.Domain.Entities;
using GestorDePacientes.Infrastructure.Persistence.Contexts;
using System.Threading.Tasks;

namespace StockApp.Infrastructure.Persistence.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly SqlServerContext _dbContext;

        public UserRepository(SqlServerContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override async Task<User> AddAsync(User entity)
        {
            entity.Password = PasswordEncryptation.ComputeSha256Hash(entity.Password);
            await base.AddAsync(entity);
            return entity;
        }

        public async Task<User> LoginAsync(LoginViewModel loginVm)
        {
            string passwordEncrypt = PasswordEncryptation.ComputeSha256Hash(loginVm.Password);
            User user = await _dbContext.Set<User>().FirstOrDefaultAsync(user=> user.Username == loginVm.Username && user.Password == passwordEncrypt);
            return user;
        }

    }
}
