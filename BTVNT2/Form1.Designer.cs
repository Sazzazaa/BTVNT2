namespace BTVNT2
{
    partial class Form1
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
            this.lv_info = new System.Windows.Forms.ListView();
            this.cl_ho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_sdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_ho = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lv_info
            // 
            this.lv_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_ho,
            this.cl_ten,
            this.cl_sdt});
            this.lv_info.FullRowSelect = true;
            this.lv_info.GridLines = true;
            this.lv_info.HideSelection = false;
            this.lv_info.Location = new System.Drawing.Point(20, 44);
            this.lv_info.Margin = new System.Windows.Forms.Padding(2);
            this.lv_info.Name = "lv_info";
            this.lv_info.Size = new System.Drawing.Size(275, 251);
            this.lv_info.TabIndex = 0;
            this.lv_info.UseCompatibleStateImageBehavior = false;
            this.lv_info.View = System.Windows.Forms.View.Details;
            // 
            // cl_ho
            // 
            this.cl_ho.Text = "Họ";
            this.cl_ho.Width = 90;
            // 
            // cl_ten
            // 
            this.cl_ten.Text = "Tên";
            this.cl_ten.Width = 90;
            // 
            // cl_sdt
            // 
            this.cl_sdt.Text = "SDT";
            this.cl_sdt.Width = 90;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(324, 225);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(44, 32);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(394, 225);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(44, 32);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(465, 225);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(44, 32);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SDT:";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(416, 121);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(76, 20);
            this.txt_ten.TabIndex = 7;
            // 
            // txt_ho
            // 
            this.txt_ho.Location = new System.Drawing.Point(416, 149);
            this.txt_ho.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ho.Name = "txt_ho";
            this.txt_ho.Size = new System.Drawing.Size(76, 20);
            this.txt_ho.TabIndex = 8;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(416, 177);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(76, 20);
            this.txt_sdt.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 340);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_ho);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.lv_info);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Thêm, Xóa, Sửa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_info;
        private System.Windows.Forms.ColumnHeader cl_ten;
        private System.Windows.Forms.ColumnHeader cl_ho;
        private System.Windows.Forms.ColumnHeader cl_sdt;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_ho;
        private System.Windows.Forms.TextBox txt_sdt;
    }
}