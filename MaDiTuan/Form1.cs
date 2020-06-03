using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MaDiTuan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Madituan _MDT = new Madituan();

        #region Khởi tạo
        //private CustomPictureBox[,] banCo;
        private Label[,] labelSo;
        private Label[,] banCo;
        private int do_rong = 70;
        private int TDX = 120, TDY = 110;
        private int kich_thuoc;
        private bool tuychon = false;
        private int bd = 1;                                     //Số bước đi của mã
        private int[,] vt = new int[3, 2501];                //Vi tri hien tai cua quan Ma
        private int _iX, _iXtam;
        private int _iY, _iYtam;
        private int[,] duongDi = new int[2501, 2501];          //Duong di cua quan Ma
        private int[] dx = new int[8] { -1, 1, 2, 2, 1, -1, -2, -2 };
        private int[] dy = new int[8] { -2, -2, -1, 1, 2, 2, 1, -1 };
        #endregion
        #region Vebanco
        public void khoiTao(int kich_thuoc)
        {
            this.panelBanCo.Size = new System.Drawing.Size(70 * kich_thuoc + 80, 70 * kich_thuoc + 80);
            labelSo = new Label[2, kich_thuoc + 1];
            for (int i = 1; i <= kich_thuoc; i++)
            {
                //Ngang
                labelSo[1, i] = new Label();
                labelSo[1, i].AutoSize = true;
                labelSo[1, i].Location = new System.Drawing.Point(do_rong * i + 70, 80);
                labelSo[1, i].Name = i.ToString();
                labelSo[1, i].Size = new System.Drawing.Size(19, 13);
                labelSo[1, i].TabIndex = 1;
                labelSo[1, i].Text = i.ToString();
                labelSo[1, i].ForeColor = Color.Red;
                panelBanCo.Controls.Add(labelSo[1, i]);
                //Doc
                labelSo[0, i] = new Label();
                labelSo[0, i].AutoSize = true;
                labelSo[0, i].Location = new System.Drawing.Point(80, do_rong * i + 70);
                labelSo[0, i].Name = i.ToString();
                labelSo[0, i].Size = new System.Drawing.Size(19, 13);
                labelSo[0, i].TabIndex = 1;
                labelSo[0, i].Text = i.ToString();
                labelSo[0, i].ForeColor = Color.Red;
                panelBanCo.Controls.Add(labelSo[0, i]);
            }
            //Khởi tạo mảng hai chiều picture hiển thị bàn cờ
            banCo = new Label[kich_thuoc + 1, kich_thuoc + 1];
            // banCo = new CustomPictureBox[kich_thuoc + 1, kich_thuoc + 1];
            for (int i = 1; i <= kich_thuoc; i++)
            {
                for (int j = 1; j <= kich_thuoc; j++)
                {
                    banCo[i, j] = new Label();
                    if (i % 2 != 0)
                    {
                        //if (j % 2 != 0) banCo[i, j].BackgroundImage = Properties.Resources.Nen_trang;
                        //else banCo[i, j].BackgroundImage = Properties.Resources.Nen_do;
                        if (j % 2 != 0) banCo[i, j].BackColor = Color.White;
                        else banCo[i, j].BackColor = Color.Black;
                    }
                    //else if (j % 2 != 0) banCo[i, j].BackgroundImage = Properties.Resources.Nen_do;
                    //else banCo[i, j].BackgroundImage = Properties.Resources.Nen_trang;
                    else if (j % 2 != 0) banCo[i, j].BackColor = Color.Black;
                    else banCo[i, j].BackColor = Color.White;
                    banCo[i, j].Location = new System.Drawing.Point(TDX + (j - 1) * do_rong, TDY + (i - 1) * do_rong);
                    banCo[i, j].Name = i + "_" + j;
                    banCo[i, j].Size = new System.Drawing.Size(do_rong, do_rong);
                    //banCo[i, j].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    banCo[i, j].TabIndex = 0;
                    banCo[i, j].TabStop = false;
                    banCo[i, j].ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                    banCo[i, j].Click += new EventHandler(SukienTienpro_Click); // dat con ma len day
                    panelBanCo.Controls.Add(banCo[i, j]);
                }
            }
        }
        #endregion

        #region Chon vị trí cho mã
        private void btnok_Click(object sender, EventArgs e)
        {
            btnok.Enabled = false;
            kich_thuoc = Convert.ToInt32(txtkichthuoc.Text);
            if (kich_thuoc > 9 || kich_thuoc < 5)
            {
                MessageBox.Show("Nhập kích thước bàn cờ trong khoảng từ 5 đến 9",
                              "Lỗi",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error,
                              MessageBoxDefaultButton.Button1);

                txtkichthuoc.Focus();
                txtkichthuoc.Text = "";
            }
            else
            {
                khoiTao(Convert.ToInt32(txtkichthuoc.Text));
                btnchay.Enabled = true;
                btnlammoi.Enabled = true;
            }
        }
        int click = 0;
        private void SukienTienpro_Click(object sender, EventArgs e)
        {
            if (click != -1)
            {
                xoaNgua();
                Xoa_Inmaxanh(_iXtam, _iYtam);
                Label btn = (Label)sender;
                btn.Image = Properties.Resources.Ngua_do;
                click++;
                TimViTri();
                lbl_Toadoxuatphat.Text = "Tọa độ xuất phát:  (" + _iX + " : " + _iY + ")";
                btnduong_NguaXanh.Enabled = true;
            }

        }
        #endregion
        void TimViTri()
        {
            foreach (Label item in panelBanCo.Controls)
            {
                if (item.Image != null)
                {
                    string a = item.Name;
                    string[] kq = a.Split('_');
                    _iX = Convert.ToInt32(kq[0].Trim());
                    _iY = Convert.ToInt32(kq[1].Trim());
                    _iXtam = _iX;
                    _iYtam = _iY;
                }

            }


        }
        bool TamDung = false;
        int a = 0;
        private void btnchay_Click(object sender, EventArgs e)
        {
            btnduong_NguaXanh.Enabled = false;
            if (click != 0)
            {
                click = -1;
                if (TamDung == false)
                {
                    
                    if (test_NguaXanh == 1)
                    {
                        Xoa_Inmaxanh(_iXtam, _iYtam);
                    }

                    Di();
                    TamDung = true;
                    if (a == 0)
                    {
                        _MDT = new Madituan();
                        _MDT.SetGT(_iX, _iY, kich_thuoc);
                        _MDT.DiTuan();
                        vt = _MDT._vt;
                        _iXtam = _iX;
                        _iYtam = _iY;
                        bd = 1;
                        tuychon = false;
                        a = 1;
                    }
                    btnchay.Text = "Tạm dừng";


                }
                else
                {
                    timer2.Enabled = false;
                    timer1.Enabled = false;
                    btnduong_NguaXanh.Enabled = true;
                    TamDung = false;
                    btnchay.Text = "Chạy tiếp";
                }
            }
            else
            {
                MessageBox.Show("Bạn đặt vị trí mã lên bàn cờ vua thì chương trình mới chạy được!");
            }
        }
        void Di()
        {
            if (tuychon == false)
            {
                tuychon = true;
                timer1.Enabled = true;
                if (bd == 1)
                {
                    timer2.Enabled = true;
                }

            }
            else
            {
                tuychon = false;
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }

        public void xoaNgua()
        {
            for (int i = 1; i <= kich_thuoc; i++)
            {
                for (int j = 1; j <= kich_thuoc; j++)
                {
                    banCo[i, j].Image = null;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //vt[0,i]là tọa độ x, vt[1,i] là tọa độ y
            if (bd == 0)
            {
                bd++;
                xoaNgua();
                banCo[_iX, _iY].Image = Properties.Resources.Ngua_do;
            }
            else
            {

                banCo[_iXtam, _iYtam].Image = Properties.Resources.Ngua_trang;
                banCo[_iXtam, _iYtam].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                banCo[_iXtam, _iYtam].ForeColor = System.Drawing.Color.Red;
                banCo[_iXtam, _iYtam].Text = bd.ToString();
                _iXtam = vt[0, bd];
                _iYtam = vt[1, bd];
                lbl_Toadohientai.Text = "Tọa độ hiện tại:   (" + _iXtam + " : " + _iYtam + ")";
                lblBuocdi.Text = "Bước:   " + bd.ToString();
                banCo[_iXtam, _iYtam].Image = Properties.Resources.Ngua_do;
                bd++;
                if (bd == kich_thuoc * kich_thuoc)//đi hết bàn cờ
                {
                    banCo[_iXtam, _iYtam].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                    banCo[_iXtam, _iYtam].ForeColor = System.Drawing.Color.Red;
                    lblBuocdi.Text = "Bước:   " + bd.ToString();
                    banCo[_iXtam, _iYtam].Text = bd.ToString();
                    _iXtam = _iX;
                    _iYtam = _iY;
                    bd = 0;
                    tuychon = false;
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    btnchay.Text = "Bắt đầu";
                    btnok.Enabled = true;
                    btnlammoi.Enabled = true;
                    btnchay.Enabled = false;
                    btnduong_NguaXanh.Enabled = false;
                    MessageBox.Show("Chạy hoàn tất!");
                    click = -1;
                }
            }

            banCo[_iX, _iY].Image = Properties.Resources.Ngua_do;
        }
        bool doi1 = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (bd != 0)
            {
                if (doi1)
                {
                    doi1 = false;
                    banCo[vt[0, bd], vt[1, bd]].Image = Properties.Resources.Ngua_do;
                }
                else
                {
                    doi1 = true;
                    banCo[vt[0, bd], vt[1, bd]].Image = null;
                }
            }
        }
        #region TinhSoNuocDi(int,int)
        int[] i_nguaxanh = new int[200];
        int[] j_nguaxanh = new int[200];
        int n = 0;
        private void Inmaxanh(int _x, int _y)
        {
            int i, j;

            for (int k = 0; k < 8; k++)
            {
                i = _x + dx[k];
                j = _y + dy[k];

                //ô có thể đi là ô nằm trong bàn cờ và quân Mã chưa đi qua
                if (i >= 1 && i <= kich_thuoc && j >= 1 && j <= kich_thuoc && duongDi[i, j] == 0 && banCo[i, j].Image == null)
                {
                    i_nguaxanh[n] = i;
                    j_nguaxanh[n] = j;

                    banCo[i, j].Image = Properties.Resources.Ngua_xanh;
                    banCo[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                    banCo[i, j].ForeColor = System.Drawing.Color.Gold;
                    banCo[i, j].Text = (n + 1).ToString();
                    n++;
                }

            }
            //return n;
        }
        private void Xoa_Inmaxanh(int _x, int _y)
        {
            for (int i = 0; i < n; i++)
            {
                banCo[i_nguaxanh[i], j_nguaxanh[i]].Image = null;
                banCo[i_nguaxanh[i], j_nguaxanh[i]].Text = "";
            }
            i_nguaxanh = new int[200];
            j_nguaxanh = new int[200];
            n = 0;
        }
        #endregion
        int test_NguaXanh = 0;
        private void btnduong_NguaXanh_Click(object sender, EventArgs e)
        {

            if (test_NguaXanh == 0)
            {
                Inmaxanh(_iXtam, _iYtam);
                test_NguaXanh = 1;

            }
            else
            {
                Xoa_Inmaxanh(_iXtam, _iYtam);
                test_NguaXanh = 0;
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            //Đưa ra thông báo xác nhận
            DialogResult a = MessageBox.Show("Bạn có muốn khởi tạo lại bàn cờ?",
                                            "Thông Báo",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button1);

            if (a == DialogResult.Yes)
            {
                //chạy chương trình mới và tắt cửa sổ hiện tại đi
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "0.5")
            {
                timer1.Interval = 500;
            }
            else
            {
                timer1.Interval = int.Parse(comboBox1.Text) * 1000;
            }

            if (comboBox1.Text != "0.5" && int.Parse(comboBox1.Text) > 1 && bd == 1)
            {
                banCo[vt[0, 1], vt[1, 1]].Image = Properties.Resources.Ngua_Dong;
            }
            else
            {
                if (bd == 1)
                    banCo[vt[0, 1], vt[1, 1]].Image = null;
            }
        }

      

        private void timer3_Tick(object sender, EventArgs e)
        {

        }



    }
}
