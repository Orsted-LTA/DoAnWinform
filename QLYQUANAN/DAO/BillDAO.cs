using QLYQUANAN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYQUANAN.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instace
        {
            get { if (Instace == null) instance = new BillDAO() ; return instance; }
           private  set { BillDAO.instance = value; }

        }
        private BillDAO() { }
        /// <summary>
        /// thành công bill :ID 
        /// thất bại : -1 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT  * FROM dbo.Bill WHERE idTable = "+ id + " AND Status = 0");
            if (data.Rows.Count >0 )
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;

            }
            return -1 ;
        }
    }
}
