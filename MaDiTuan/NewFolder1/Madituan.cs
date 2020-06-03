using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaDiTuan
{
    class Madituan
    {
        
            #region Cấu trúc một nước đi của quân Mã
            struct nuocDi
            {
                public int n;       //So o co the di tiep
                public int x, y;    //Vi tri
            };
            #endregion
            #region Khai Báo Các Biến Cần Thiết
            private int x, y;                                       //Toa do cua quan Ma
            private int kichThuoc;                                  //Kich Thuoc ban co
            private bool ngung = false;
            private int[,] duongDi = new int[2501, 2501];          //Duong di cua quan Ma
            private int[,] vt = new int[2, 2501];             //Vi tri hien tai cua quan Ma
            public int[,] _vt = new int[2, 2501];             //Mang tong hop cac Vi tri cua Quan Ma
           int [] dx= {2,1,-1,-2,-2,-1,1,2};
           int [] dy= {1,2,2,1,-1,-2,-2,-1};
            nuocDi temp = new nuocDi();
            #endregion

            //Cài đặt giá trị cho các biến
            #region Hàm Set
            public void SetGT(int _x, int _y, int _kt)
            {
                x = _x;
                y = _y;
                kichThuoc = _kt;
            }
            #endregion

            //Gọi các hàm cần thiết để tìm đường đi
            #region Đi Tuần Tối Ưu
            public bool DiTuan()
            {
                KhoiTao();
                duongDi[x, y] = 1;
                TimDuong(x, y, 1);
                if (ngung)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            #endregion
      
            #region Khoi tao
            private void KhoiTao()
            {
                //Khoi tao gia tri ban dau cho vi tri cua quan ma = 0
                for (int i = 0; i < kichThuoc * kichThuoc; i++)
                {
                    vt[0, i] = 0;
                    vt[1, i] = 0;
                    _vt[0, i] = 0;
                    _vt[1, i] = 0;
                }

                //Khoi tao duong di cua quan Ma = 0
                for (int i = 0; i < kichThuoc; i++)
                {
                    for (int j = 0; j < kichThuoc; j++)
                    {
                        duongDi[i, j] = 0;
                    }
                }
                //một quân mã có thể đi 8 nước tiếp theo
               
       
            }
            #endregion
            //Tính số nước có thể đi tiếp của quân Mã
            #region TinhSoNuocDi(int,int)
            private int TinhSoNuocDi(int _x, int _y)
            {
                int i, j, n = 0;

                for (int k = 0; k < 8; k++)
                {
                    i = _x + dx[k];
                    j = _y + dy[k];

                    //ô có thể đi là ô nằm trong bàn cờ và quân Mã chưa đi qua
                    if (i >= 1 && i <= kichThuoc && j >= 1 && j <= kichThuoc && duongDi[i, j] == 0)
                    {
                        n++;
                    }
                }
                return n;
            }
            #endregion

            //Tìm nước đi kế tiếp và tìm đường đi
            #region Hàm Tìm Đường
            private void TimDuong(int _x, int _y, int buoc)
            {
                //Neu di het ban co roi
                if (buoc == kichThuoc * kichThuoc && !ngung)
                {
                    ngung = true;
                    for (int i = 0; i < kichThuoc * kichThuoc; i++)
                    {
                        _vt[0, i] = vt[0, i];
                        _vt[1, i] = vt[1, i];
                    }
                }
                else
                {
                    if (!ngung)
                    {
                        int i, j, soNuocDi = 0;
                        nuocDi[] luaChon = new nuocDi[8];

                        //Tim nuoc di ke tiep
                        for (int k = 0; k < 8; k++)
                        {
                            i = _x + dx[k];
                            j = _y + dy[k];
                            if (i >= 1 && i <= kichThuoc && j >= 1 && j <= kichThuoc && duongDi[i, j] == 0)
                            {
                                temp.n = TinhSoNuocDi(i, j);
                                temp.x = i;
                                temp.y = j;
                                luaChon[soNuocDi++] = temp;
                            }
                        }

                        if (soNuocDi > 0)
                        {
                            //Sap xep cac nuoc di tang dan theo so o co the di tiep
                            for (i = 0; i < soNuocDi - 1; i++)
                            {
                                for (j = i + 1; j < soNuocDi; j++)
                                {
                                    if (luaChon[i].n > luaChon[j].n)
                                    {
                                        temp = luaChon[i];
                                        luaChon[i] = luaChon[j];
                                        luaChon[j] = temp;
                                    }
                                }
                            }

                            //lưu  tọa độ bước đi của nó
                            for (i = 0; i < soNuocDi; i++)
                            {
                                duongDi[luaChon[i].x, luaChon[i].y] = buoc + 1;
                                vt[0, buoc] = luaChon[i].x;
                                vt[1, buoc] = luaChon[i].y;

                                TimDuong(luaChon[i].x, luaChon[i].y, buoc + 1);
                                duongDi[luaChon[i].x, luaChon[i].y] = 0;
                            }

                        }
                    }
                }
            }
            #endregion
        }
}

