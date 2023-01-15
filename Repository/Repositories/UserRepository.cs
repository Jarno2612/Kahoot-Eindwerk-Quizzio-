using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly KahootContext _kahootContext;

        public UserRepository(KahootContext kahootContext)
        {
            _kahootContext = kahootContext;
        }

        #region GET
        public async Task<List<User>> GetUsers()
        {
            List < User > users = await _kahootContext.User.ToListAsync();
            return users;
        }

        public User GetUserById(Guid id)
        {
            User user = _kahootContext.User.FirstOrDefault(u => u.Id == id);
            return user;
        }
        #endregion

        #region CREATE
        public void CreateUser(User user)
        {
            _kahootContext.User.Add(user);
            _kahootContext.SaveChanges();
        }


        #endregion
    }
}
