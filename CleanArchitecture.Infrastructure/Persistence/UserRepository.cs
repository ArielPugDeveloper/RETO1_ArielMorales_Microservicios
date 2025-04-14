using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new List<User>();

        public async Task Save(User user)
        {
            _users.Add(user);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await Task.FromResult(_users);
        }
    }
}
