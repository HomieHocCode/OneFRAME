using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Model
{
    public class Demo
    {
        public enum eTrangThai
        {
            Moi = 0,
            DangThucHien = 1,
            HoanTat = 2,
            Huy = 3
        }

        public static readonly string[] sTrangThai = new string[]
        {
            "Mới",
            "Đang thực hiện",
            "Hoàn tất",
            "Hủy"
        };
        public static readonly string[] spanTrangThai = new string[]
        {
            "<span style=\"font-size:13px; background-color: #FFFF00;\" class=\"badge\" >Mới</span>",
            "<span style=\"font-size:13px; background-color: #2eb8ec;\" class=\"badge\" >Đang thực hiện</span>",
            "<span style=\"font-size:13px; background-color: #00B050;\" class=\"badge\" >Hoàn tất</span>",
            "<span style=\"font-size:13px; background-color: #676a6c;\" class=\"badge\" >Hủy</span>"
        };
        public enum eTacVu
        {
            Luu = 0,
            Tai = 1,
            Chuyen = 2,
            ThuHoi = 3,
            Huy = 4,
            TaoMoi =5,
        }
        public static readonly string[] sTacVu = new string[]
        {
            "Lưu",
            "Tải",
            "Chuyển",
            "Thu hồi",
            "Hủy",
            "Tạo mới",
        };
    }
}
