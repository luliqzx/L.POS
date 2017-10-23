using L.Pos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.DataAccess.Repo
{
    public interface IUserRepo : IBaseRepo<User>
    {
        void GetOne();
    }

    public class UserRepo : BaseRepo<User>, IUserRepo
    {
        public void GetOne()
        {
            User usr = GetBy(p => p.ID == "8584");
            string x = usr.Username;
        }
    }
}
