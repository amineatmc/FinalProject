using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
       // NorthwindContext db = new NorthwindContext();


        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Login(User user)
        {
            //var userDb = db.Users.FirstOrDefault(u=> u.UserName== user.UserName && u.Password == user.Password);
            return 
            //if (userDb != null)
            //{
                
            //    return new SuccesResult(Messages.UsersSuccesLogin);
            //}
            //else
            //{
            //    return new SuccesResult(Messages.UsersError);
            //}
            
        }
    }
}
