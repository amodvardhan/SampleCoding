using SampleCoding.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace SampleCoding.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SampleCodingDBContext _SampleCodingDBContext;

        public UserRepository(SampleCodingDBContext SampleCodingDBContext)
        {
            _SampleCodingDBContext = SampleCodingDBContext;
        }

        public bool CreateUser(User user)
        {
            if (user == null)
                return false;

            _SampleCodingDBContext.Users.Add(user);
            _SampleCodingDBContext.SaveChanges();
            return true;
        }

        public IEnumerable<User> GetUserList()
        {
            var users = _SampleCodingDBContext.Users.OrderByDescending(u=>u.Id).ToList();
            return users;
        }

        public User GetUserById(int userId)
        {
            var user = _SampleCodingDBContext.Users.FirstOrDefault(u => u.Id == userId);
            return user;
        }
    }
}
