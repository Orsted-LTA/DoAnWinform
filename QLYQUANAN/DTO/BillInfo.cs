using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYQUANAN.DTO
{
    public class BillInfo
    {
        public BillInfo(int ID  , int billID,int foodID, int count )
    {
            this.ID = iD;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Count = count;
    }
        public BillInfo (DataRow row)
        {
            this.ID = (int) row ["id "];
            this.BillID =(int)row  ["billID"];
            this.FoodID = (int)row["foodID"];
            this.Count = (int)row["count "] ;

        }
        private int count;
        public int Count
        {
            get { return Count; }
            set { Count = value; }
        }


        private int FoodId;
        public int FoodID 
        {
            get { return FoodID; }
            set { FoodID  = value; }
        }

        private int billID;
        public int BillID
        {
            get { return billID; ; }
            set { billID = value; }
        }



        private int iD;
   

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

    }
}

