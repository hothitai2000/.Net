using Model.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class productModel
    {
        private dbcontext context = null;
        public productModel()
        {
            context = new dbcontext();
        }
        public List<tbl_products> ListAll()
        {
            var list =context.Database.SqlQuery<tbl_products>("SP_Products_listall").ToList
           ();
            return list;
        }
        public int update(int id, string name, decimal? price, string detail,
        string images)
        {
            object[] parameters =
            {
        new SqlParameter("@ID",id),
        new SqlParameter("@Name",name),
        new SqlParameter("@Price",price),
        new SqlParameter("@Detail",detail),
        new SqlParameter("@Images",images)
        };

            int res = context.Database.ExecuteSqlCommand("Sp_Products_Update @ID, @Name, @Price, @Detail, @Images", parameters);

            return res;
        }
        public int delete(int id)
        {
            object[] parameters =
            {
                     new SqlParameter("@ID",id)

            };
            int res =
            context.Database.ExecuteSqlCommand("Sp_Products_Delete @ID", parameters);
            return res;
        }

        public List<tbl_products> SelectID(int id)

        {
            object[] parameters =
            {
                    new SqlParameter("@ID",id)

                };
            var list = context.Database.SqlQuery<tbl_products>("Sp_Products_SelectID @ID", parameters).ToList();
            return list;
        }


        public int create(int id, string name, decimal? price, string detail, string images)
        {
            object[] parameters =
            {
            new SqlParameter("@ID",id),
            new SqlParameter("@Name",name),
            new SqlParameter("@Price",price),
            new SqlParameter("@Detail",detail),
            new SqlParameter("@Images",images)
};
            int res = context.Database.ExecuteSqlCommand("Sp_Products_Insert @ID, @Name, @Price, @Detail, @Images",parameters);
 return res;
        }

    }
}
