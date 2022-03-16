using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tuan4_1911062004_VoMinhHieu.Models
{
    public class Giohang
    {
        MyDataDataContext data = new MyDataDataContext();
        public int masach { get; set; }
        [Display(Name = "Tên sách")]
        public string tensach { get; set; }
        [Display(Name = "Ảnh sách")]
        public string hinh { get; set; }

        [Display(Name = "Giá bán")]
        public Double giaban { get; set; }

        [Display(Name = "Số lượng")]
        public int iSoluong { get; set; }

        [Display(Name = "Thành tiền")]
        public Double dThanhtien
        {
            get { return iSoluong * giaban; }
        }

        public Giohang(int id)
        {
            masach = id;
            Sach sach = data.Saches.Single(n => n.masach == masach);
            tensach = sach.tensach;
            hinh = sach.hinh;
            giaban = double.Parse(sach.giaban.ToString());
            iSoluong = 1;
        }
    }
}