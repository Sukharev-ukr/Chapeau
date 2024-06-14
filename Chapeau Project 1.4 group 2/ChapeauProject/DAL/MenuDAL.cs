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
    public class MenuDAL : BaseDAL
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
                Category = Enum.Parse<Category>((string)row["Category"], true),
                Card = (string)row["Card"],
                Price = (decimal)row["Price"],
                Stock = row["Stock"] as int?,
                VAT = row["VAT"] as int?,
            };
            return menuItem;
        }
    }
}