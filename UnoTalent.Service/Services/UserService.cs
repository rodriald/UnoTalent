using System;
using System.Collections.Generic;
using System.Text;
using UnoTalent.Service.Services.Abstractions;
using UnoTalent.Data.Entities;
using UnoTalent.Data;
using System.Linq;

namespace UnoTalent.Service.Services
{
    public class UserService : IApiService<User>
    {
        private readonly UnoTalentDbContext _context;

        public UserService(UnoTalentDbContext context) {
            _context = context;
        }

        public int Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }

        public User Delete(long id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return null;
            }

            _context.Users.Remove(user);
            _context.SaveChanges();

            return user;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(long id)
        {
            return _context.Users.Find(id);
        }

        public User Update(long id, User user)
        {
            var oldUser = _context.Users.Find(id);

            if (oldUser == null)
            {
                return null;
            }

            oldUser.Name = user.Name;

            _context.Users.Update(oldUser);
            _context.SaveChanges();
            return user;
        }
    }
}
