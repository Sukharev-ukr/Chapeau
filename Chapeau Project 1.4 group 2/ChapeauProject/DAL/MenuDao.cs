using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MenuDao : BaseDao
    {
        public List<MenuItem> GetMenuItems()
        {
            string query = "SELECT [ItemID],[Name],[Category],[Card],[Price],[Stock],[VAT] FROM Item";
            SqlParameter[] sp = new SqlParameter[0];

            return ReadItemRows(ExecuteSelectQuery(query, sp));
        }

        public List<MenuItem> ReadItemRows(DataTable dr)
        {
            List<MenuItem> list = new List<MenuItem>();

            foreach (DataRow row in dr.Rows)
            {
                list.Add(ReadDataRow(row));
            }
            return list;
        }
        public MenuItem ReadDataRow(DataRow row)
        {
            MenuItem menuItem = new MenuItem()
            {
                Id = (int)row["ItemID"],
                Name = (string)row["Name"],
                Category = MapCategory(row["Category"].ToString()),
                Card = (string)row["Card"],
                Price = (decimal)row["Price"],
                Stock = row["Stock"] as int?,
                VAT = row["VAT"] as int?,
            };
            return menuItem;
        }
        private Category MapCategory(string category)
        {
            switch (category.ToLower())
            {
                case "starters - entrees":
                    return Category.Starters;
                case "mains - le plat principal":
                    return Category.Mains;
                case "deserts - les desserts":
                    return Category.Desserts;
                case "entremets":
                    return Category.Entremets;
                default:
                    return Category.Drinks;
            }
        }
    }
}