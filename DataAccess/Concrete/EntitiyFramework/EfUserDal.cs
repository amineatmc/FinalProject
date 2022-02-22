using Core.DataAcces.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<UserDetailDto>GetUserDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from u in context.Users
                             select new UserDetailDto
                             {
                                 UserName = u.UserName,
                                 Password = u.Password
                             };
                return result.ToList();

            }

        }
    }
}
