using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.Utilities;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IsKaiser.Management.Bll.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            ValidationTool.Validate(new UsersValidator(), user);
            _userDal.Add(user);
        }

        public User Get(int id)
        {
            return _userDal.Get(u => u.UserId == id);
        }
        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User CheckUser(string username, string password)
        {
            return _userDal.Get(u => u.UserName == username && u.UserPw == password);
        }

        public void Update(User user)
        {
            ValidationTool.Validate(new UsersValidator(), user);
            _userDal.Update(user);
        }
    }
}
