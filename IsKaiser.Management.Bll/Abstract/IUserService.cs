using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User Get(int id);
        void Add(User user);
        void Update(User user);
        User CheckUser(string username, string password);
    }
}
