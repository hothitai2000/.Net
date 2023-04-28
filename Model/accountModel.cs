using Model.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class accountModel
    {
        private dbcontext context = null;
        public accountModel()
        {
            context = new dbcontext();
        }
        public bool Login(string user, string pass)
        {
            object[] sqlParams = { new SqlParameter("@username",user), new SqlParameter("@pass",pass) };

            var res = context.Database.SqlQuery<bool>("Sp_Acount_Login @username,@pass",

            sqlParams).SingleOrDefault();

            return res;
        }
    }
}
