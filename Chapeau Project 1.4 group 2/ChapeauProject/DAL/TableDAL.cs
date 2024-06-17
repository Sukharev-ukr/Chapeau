using System;
using System.Collections.Generic;
using System.Data;
using Model;
using System.Data.SqlClient;

namespace DAL
{
    public class TableDAL: BaseDAL
    {

        public List<Table> GetAllTables()
        {
            string query = "SELECT TableID, Status FROM [Table]";
            DataTable dataTable = ExecuteSelectQuery(query);

            List<Table> tables = new List<Table>();
            foreach (DataRow row in dataTable.Rows)
            {
                Table table = new Table
                {
                    TableId = (int)row["TableID"],
                    Status = Enum.Parse<TableStatus>((string)row["Status"])
                };
                tables.Add(table);
            }
            return tables;
        }

        public void UpdateTableStatus(Table table)
        {
            string updateQuery = "UPDATE [Table] SET Status = @Status WHERE TableID = @TableID";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Status", table.Status.ToString()),
                new SqlParameter("@TableID", table.TableId)
            };
            ExecuteEditQuery(updateQuery, sqlParameters);

        }

        public Table getTableById(int tableId)
        {
            string query = "SELECT TableID, number, Status FROM [Table] WHERE TableID = @TableID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TableID", tableId)
            };

            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private Table ReadTable(DataTable data)
        {
            DataRow dataRow = data.Rows[0];
            Table table = new Table()
            {
                TableId = (int)dataRow["TableID"],
                TableNumber = (int)dataRow["number"],
                Status = (TableStatus)Enum.Parse(typeof(TableStatus), (string)dataRow["Status"])
            };
            return table;
        }
    }
}