using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYQUANAN.DTO
{
   public  class Bill
    {
        public Bill(int id, DateTime? dateCheckin, DateTime? dateCheckOut, int status )
        {
            this.ID= id;
            this.dateChekIn = dateCheckin;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }
        public Bill(DataRow row)
        {
            this.ID =(int) row["id"];
            this.dateChekIn = (DateTime?)row["dateCheckin"];
            this.DateCheckOut = (DateTime?)row ["dateCheckOut"];
            this.Status = (int)row["status"];

        }
        private int Status
        {
            get { return Status; }
            set { status = Value; }
        }
        private DateTime? DateCheckOut;
        private DateTime? dateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }

        }
        private DateTime? dateChekIn
        {
            get { return dateChekIn; }
            set { dateChekIn = value; }

        }

        private int id;
        private object status;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public object Value { get; private set; }
        public int Id { get; internal set; }
    }
}
