using System.Collections.Generic;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;

namespace UnoTalent.Service.Mappers
{
    public class UserMapper : IMapper<User, UserVm>
    {
        public User Map(UserVm model)
        {
            User user = new User();
            user.Id = model.Id;
            user.Name = model.Name;
            return user;
        }

        public UserVm Map(User entity)
        {
            UserVm user = new UserVm();
            user.Id = entity.Id;
            user.Name = entity.Name;
            return user;
        }

        public List<User> Map(List<UserVm> models)
        {
            List<User> users = new List<User>();
            foreach (UserVm user in models) {
                users.Add(Map(user));
            }

            return users;
        }

        public List<UserVm> Map(List<User> entities)
        {
            List<UserVm> users = new List<UserVm>();
            foreach (User user in entities)
            {
                users.Add(Map(user));
            }

            return users;
        }
    }
}
