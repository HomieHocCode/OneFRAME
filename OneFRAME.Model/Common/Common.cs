using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneFRAME.Model
{
   public class Common
    {
        public enum eHieuLuc
        {
            Co = 1 ,
            Khong=0
        }
        public enum eBanBe
        {
            Co,
            Khong
        }
        public enum eDVHC
        {
            QuocGia = 1,
            VungMien = 2,
            TinhThanh = 3,
            QuanHuyen = 4,
            XaPhuong = 5
        }
    }
}
