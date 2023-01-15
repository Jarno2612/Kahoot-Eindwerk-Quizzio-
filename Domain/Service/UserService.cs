using Domain.Models;
using Domain.Service.Contracts;
using Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<List<User>> GetUsers()
        {
            return _userRepository.GetUsers();
        }
        public User GetUserById(Guid id)
        {
            return _userRepository.GetUserById(id);
        }

        public void CreateUser(User user)
        { 
            if (user.Id == null)
            {
            _userRepository.CreateUser(user);

            }
            else
            {
                throw new Exception("User already exist");
            }
        }

    }
}
