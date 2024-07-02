using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoomType
    {
        int _id;
        string _ten;
        string _mota;
        int _sogiuong;
        float _gio;
        float _ngay;

        public int Id { get => _id; set => _id = value; }
        public string Ten { get => _ten; set => _ten = value; }
        public string Mota { get => _mota; set => _mota = value; }
        public int Sogiuong { get => _sogiuong; set => _sogiuong = value; }
        public float Gio { get => _gio; set => _gio = value; }
        public float Ngay { get => _ngay; set => _ngay = value; }
        public RoomType() { }
        public RoomType(int id,string ten,string mt,int sg,float gio,float ngay)
        {
            this.Id = id;
            this.Ten = ten;
            this.Mota = mt; 
            this.Sogiuong = sg; 
            this.Gio = gio; 
            this.Ngay = ngay;
        }
        public RoomType(string ten, string mt, int sg, float gio, float ngay)
        {
            this.Ten = ten;
            this.Mota = mt;
            this.Sogiuong = sg;
            this.Gio = gio;
            this.Ngay = ngay;
        }

        public RoomType(DataRow row)
        {
            this.Id = (int)row["MALOAIPHONG"]; 
            this.Ten = row["TENLOAI"].ToString();
            this.Mota = row["MOTA"].ToString();
            this.Sogiuong = (int)row["SOGIUONG"];
            this.Gio = (float)Convert.ToDouble(row["TINHTHEOGIO"].ToString());
            this.Ngay = (float)Convert.ToDouble(row["TINHTHEONGAY"].ToString());
        }
    }
}
