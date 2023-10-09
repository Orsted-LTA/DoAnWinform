using QLYQUANAN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYQUANAN.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
       

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 80;
        public static int TableHeight = 80;
        private DataRow item;

        private TableDAO() { }
    
    public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable dt = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow item in dt.Rows)
            {
                Table table = new Table(item);

                tableList.Add(table);
            }
            return tableList;
        }
    }
}

