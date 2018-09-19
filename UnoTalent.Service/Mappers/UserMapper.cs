using System;
using System.Collections.Generic;
using System.Text;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;

namespace UnoTalent.Service.Mappers
{
    public class UserMapper : IMapper<Data.Entities.User, Models.User>
    {
        public override Data.Entities.User Map(Models.User model)
        {
            Data.Entities.User user = new Data.Entities.User();
            user.Id = model.Id;
            user.Name = model.Name;
            return user;
        }

        public override Models.User Map(Data.Entities.User entity)
        {
            Models.User user = new Models.User();
            user.Id = entity.Id;
            user.Name = entity.Name;
            return user;
        }

        public override List<Data.Entities.User> Map(List<Models.User> models)
        {
            List<Data.Entities.User> users = new List<Data.Entities.User>();
            foreach (Models.User user in models) {
                Data.Entities.User newUser = new Data.Entities.User();
                newUser.Id = user.Id;
                newUser.Name = user.Name;
                users.Add(newUser);
            }

            return users;
        }

        public override List<Models.User> Map(List<Data.Entities.User> entities)
        {
            List<Models.User> users = new List<Models.User>();
            foreach (Data.Entities.User user in entities)
            {
                Models.User newUser = new Models.User();
                newUser.Id = user.Id;
                newUser.Name = user.Name;
                users.Add(newUser);
            }

            return users;
        }
    }
}
