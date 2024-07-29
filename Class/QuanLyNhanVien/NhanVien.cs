using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_management_appication.Class
{
    public class NhanVien
    {
        public string ID { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }

        public long SoDT { get; set; }
        public string DiaChi { get; set; }
        public string ChucVu { get; set; }
        public long Luong { get; set; }

        public bool CheckInfo()
        {
            if (ID.ToString()!="" && HoTen!=""&&GioiTinh!=""&&Email!=""&&SoDT.ToString()!=""&&DiaChi!=""&&ChucVu!=""&&Luong.ToString()!="")
                return true;
            else
                return false;
        }
    }
}
