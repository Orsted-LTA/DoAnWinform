using QLYQUANAN.DAO;
using QLYQUANAN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLYQUANAN
{
    public partial class Form2 : Form
    {
        private object environment;

        public Form2()
        {
            InitializeComponent();
            LoadTable();
        }
        #region  Method
        void LoadTable()
        {
            List<Table> tablesList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tablesList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + environment + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch(item.Status)
                {
                    case " Trống ":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:btn.BackColor = Color.Tan; break;
                }


                flpTable.Controls.Add(btn);

            }
        }

        void ShowBill(int id )
        {

        }
        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int TableID = (sender as Table).ID;
            ShowBill(TableID);
        }
        internal void show()
        {
            throw new NotImplementedException();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void addminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }
        #endregion
    }
}

