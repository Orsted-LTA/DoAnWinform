namespace QLYQUANAN
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSwitchtable = new System.Windows.Forms.ComboBox();
            this.btnSwitchtable = new System.Windows.Forms.Button();
            this.nmDiscoutn = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mnFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnFood = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscoutn)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mnFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addminToolStripMenuItem,
            this.thôngTinTàiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addminToolStripMenuItem
            // 
            this.addminToolStripMenuItem.Name = "addminToolStripMenuItem";
            this.addminToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.addminToolStripMenuItem.Text = "Addmin";
            this.addminToolStripMenuItem.Click += new System.EventHandler(this.addminToolStripMenuItem_Click);
            // 
            // thôngTinTàiToolStripMenuItem
            // 
            this.thôngTinTàiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiToolStripMenuItem.Name = "thôngTinTàiToolStripMenuItem";
            this.thôngTinTàiToolStripMenuItem.Size = new System.Drawing.Size(193, 29);
            this.thôngTinTàiToolStripMenuItem.Text = "Thông tin tài khoảng";
            // 
            // thôngTinCáToolStripMenuItem
            // 
            this.thôngTinCáToolStripMenuItem.Name = "thôngTinCáToolStripMenuItem";
            this.thôngTinCáToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.thôngTinCáToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(411, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 238);
            this.panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(12, 3);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(274, 232);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.List;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbSwitchtable);
            this.panel3.Controls.Add(this.btnSwitchtable);
            this.panel3.Controls.Add(this.nmDiscoutn);
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Controls.Add(this.btnCheck);
            this.panel3.Location = new System.Drawing.Point(401, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 79);
            this.panel3.TabIndex = 3;
            // 
            // cbSwitchtable
            // 
            this.cbSwitchtable.FormattingEnabled = true;
            this.cbSwitchtable.Location = new System.Drawing.Point(0, 35);
            this.cbSwitchtable.Name = "cbSwitchtable";
            this.cbSwitchtable.Size = new System.Drawing.Size(155, 28);
            this.cbSwitchtable.TabIndex = 7;
            // 
            // btnSwitchtable
            // 
            this.btnSwitchtable.Location = new System.Drawing.Point(0, 3);
            this.btnSwitchtable.Name = "btnSwitchtable";
            this.btnSwitchtable.Size = new System.Drawing.Size(111, 26);
            this.btnSwitchtable.TabIndex = 6;
            this.btnSwitchtable.Text = "Chuyển bàn";
            this.btnSwitchtable.UseVisualStyleBackColor = true;
            // 
            // nmDiscoutn
            // 
            this.nmDiscoutn.Location = new System.Drawing.Point(195, 35);
            this.nmDiscoutn.Name = "nmDiscoutn";
            this.nmDiscoutn.Size = new System.Drawing.Size(104, 26);
            this.nmDiscoutn.TabIndex = 5;
            this.nmDiscoutn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(195, 0);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(104, 29);
            this.btnDiscount.TabIndex = 4;
            this.btnDiscount.Text = "giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(299, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(104, 41);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Thanh toán";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.mnFoodCount);
            this.panel4.Controls.Add(this.btnFood);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(409, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(379, 71);
            this.panel4.TabIndex = 4;
            // 
            // mnFoodCount
            // 
            this.mnFoodCount.Location = new System.Drawing.Point(241, 24);
            this.mnFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.mnFoodCount.Name = "mnFoodCount";
            this.mnFoodCount.Size = new System.Drawing.Size(120, 26);
            this.mnFoodCount.TabIndex = 3;
            this.mnFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(131, 16);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(104, 41);
            this.btnFood.TabIndex = 2;
            this.btnFood.Text = "Thêm món";
            this.btnFood.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(4, 29);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(121, 28);
            this.cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(4, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 28);
            this.cbCategory.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(12, 65);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(367, 323);
            this.flpTable.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 473);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán ăn";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscoutn)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mnFoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.NumericUpDown mnFoodCount;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.NumericUpDown nmDiscoutn;
        private System.Windows.Forms.ComboBox cbSwitchtable;
        private System.Windows.Forms.Button btnSwitchtable;
    }
}