using QLYQUANAN.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYQUANAN.DAO
{
    public  class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO instacne 
        {
            get { if (instance == null) instacne = new BillInfoDAO(); return BillInfoDAO.instacne; }
           private  set { BillInfoDAO.instacne = value; }
        }
        private BillInfoDAO() { }
        public List<BillInfo> GetListBillInfo(int id )

        {
            List<BillInfo> ListBillInfo = new List<BillInfo>();
            return ListBillInfo;

        }

    }
}
