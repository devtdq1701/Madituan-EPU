namespace MaDiTuan
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
            this.components = new System.ComponentModel.Container();
            this.txtkichthuoc = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.panelBanCo = new System.Windows.Forms.Panel();
            this.btnchay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnduong_NguaXanh = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.lbl_Toadohientai = new System.Windows.Forms.Label();
            this.lbl_Toadoxuatphat = new System.Windows.Forms.Label();
            this.lblBuocdi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtkichthuoc
            // 
            this.txtkichthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtkichthuoc.Location = new System.Drawing.Point(48, 81);
            this.txtkichthuoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtkichthuoc.Multiline = true;
            this.txtkichthuoc.Name = "txtkichthuoc";
            this.txtkichthuoc.Size = new System.Drawing.Size(152, 30);
            this.txtkichthuoc.TabIndex = 0;
            this.txtkichthuoc.Text = "8";
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnok.Location = new System.Drawing.Point(220, 60);
            this.btnok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(121, 57);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "Tạo bàn cờ";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // panelBanCo
            // 
            this.panelBanCo.AllowDrop = true;
            this.panelBanCo.AutoScroll = true;
            this.panelBanCo.AutoSize = true;
            this.panelBanCo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBanCo.Location = new System.Drawing.Point(-16, -38);
            this.panelBanCo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBanCo.Name = "panelBanCo";
            this.panelBanCo.Size = new System.Drawing.Size(991, 869);
            this.panelBanCo.TabIndex = 2;
            // 
            // btnchay
            // 
            this.btnchay.Enabled = false;
            this.btnchay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnchay.ForeColor = System.Drawing.Color.Black;
            this.btnchay.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnchay.Location = new System.Drawing.Point(48, 135);
            this.btnchay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnchay.Name = "btnchay";
            this.btnchay.Size = new System.Drawing.Size(295, 59);
            this.btnchay.TabIndex = 3;
            this.btnchay.Text = "Đi Tuần";
            this.btnchay.UseVisualStyleBackColor = true;
            this.btnchay.Click += new System.EventHandler(this.btnchay_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtkichthuoc);
            this.groupBox1.Controls.Add(this.btnchay);
            this.groupBox1.Controls.Add(this.btnok);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(1060, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(351, 294);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Công Cụ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0.5",
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(140, 229);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 30);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "0.5";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tốc độ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kích thước bàn cờ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(1060, 341);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(351, 203);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ký hiệu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vị trí ngựa có thể đi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngựa chạy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngựa đã đi qua";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MaDiTuan.Properties.Resources.Ngua_xanh;
            this.pictureBox3.Location = new System.Drawing.Point(23, 143);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 49);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MaDiTuan.Properties.Resources.Ngua_do;
            this.pictureBox2.Location = new System.Drawing.Point(23, 86);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 49);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaDiTuan.Properties.Resources.Ngua_trang;
            this.pictureBox1.Location = new System.Drawing.Point(23, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 49);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnduong_NguaXanh);
            this.groupBox3.Controls.Add(this.btnlammoi);
            this.groupBox3.Controls.Add(this.lbl_Toadohientai);
            this.groupBox3.Controls.Add(this.lbl_Toadoxuatphat);
            this.groupBox3.Controls.Add(this.lblBuocdi);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(1060, 553);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(351, 300);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bước thực hiện";
            // 
            // btnduong_NguaXanh
            // 
            this.btnduong_NguaXanh.Enabled = false;
            this.btnduong_NguaXanh.Location = new System.Drawing.Point(23, 223);
            this.btnduong_NguaXanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnduong_NguaXanh.Name = "btnduong_NguaXanh";
            this.btnduong_NguaXanh.Size = new System.Drawing.Size(303, 50);
            this.btnduong_NguaXanh.TabIndex = 1;
            this.btnduong_NguaXanh.Text = "Xem đường có thể đi";
            this.btnduong_NguaXanh.UseVisualStyleBackColor = true;
            this.btnduong_NguaXanh.Click += new System.EventHandler(this.btnduong_NguaXanh_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Enabled = false;
            this.btnlammoi.Location = new System.Drawing.Point(25, 165);
            this.btnlammoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(303, 50);
            this.btnlammoi.TabIndex = 1;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // lbl_Toadohientai
            // 
            this.lbl_Toadohientai.AutoSize = true;
            this.lbl_Toadohientai.Location = new System.Drawing.Point(21, 123);
            this.lbl_Toadohientai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Toadohientai.Name = "lbl_Toadohientai";
            this.lbl_Toadohientai.Size = new System.Drawing.Size(141, 24);
            this.lbl_Toadohientai.TabIndex = 0;
            this.lbl_Toadohientai.Text = "Tọa độ hiện tại:";
            // 
            // lbl_Toadoxuatphat
            // 
            this.lbl_Toadoxuatphat.AutoSize = true;
            this.lbl_Toadoxuatphat.Location = new System.Drawing.Point(21, 81);
            this.lbl_Toadoxuatphat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Toadoxuatphat.Name = "lbl_Toadoxuatphat";
            this.lbl_Toadoxuatphat.Size = new System.Drawing.Size(157, 24);
            this.lbl_Toadoxuatphat.TabIndex = 0;
            this.lbl_Toadoxuatphat.Text = "Tọa độ xuất phát:";
            // 
            // lblBuocdi
            // 
            this.lblBuocdi.AutoSize = true;
            this.lblBuocdi.Location = new System.Drawing.Point(21, 41);
            this.lblBuocdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuocdi.Name = "lblBuocdi";
            this.lblBuocdi.Size = new System.Drawing.Size(64, 24);
            this.lblBuocdi.TabIndex = 0;
            this.lblBuocdi.Text = "Bước: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(752, 832);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 7;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 852);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelBanCo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkichthuoc;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Panel panelBanCo;
        private System.Windows.Forms.Button btnchay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnduong_NguaXanh;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Label lbl_Toadohientai;
        private System.Windows.Forms.Label lbl_Toadoxuatphat;
        private System.Windows.Forms.Label lblBuocdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer3;

    }
}

