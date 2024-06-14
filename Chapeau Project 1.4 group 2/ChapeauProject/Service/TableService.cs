using DAL;
using Model;

namespace Service
{
    public class TableService
    {
        private TableDAL _tableDAL;

        public TableService()
        {
            _tableDAL = new TableDAL();
        }

        public List<Table> GetAllTables()
        {
            return _tableDAL.GetAllTables();
        }

        public void UpdateTableStatus(Table table)
        {
            _tableDAL.UpdateTableStatus(table);
        }
        public Table GetTableById(int id)
        {
            return _tableDAL.getTableById(id);
        }

    }
}