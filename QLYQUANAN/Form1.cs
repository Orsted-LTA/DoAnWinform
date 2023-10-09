using QLYQUANAN.DAO;
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
    public partial class Form1 : Form
    {
        public object MasageBox { get; private set; }
        public object MasageBoxButtons { get; private set; }
        public object MassageBox { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (Login (userName, passWord))
            {

                Form2 f = new Form2();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("sai tên tài khoảng hoặc mật khẩu!");
            }

        }
        bool Login (string userName, string passWord)
        {
            return AccountDAO.Instance.Login (userName, passWord);  
        }
           

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Bạn có thật sự muốn thoát chương trình ?", "Thong bao", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
