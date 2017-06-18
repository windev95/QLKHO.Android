using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DataTransferObject;

namespace DataAccess
{
    public class DangNhap_DAL
    {
        private readonly Database data = new Database();
        public NhanVien_Object DangNhap(string taiKhoan, string matKhau)
        {
            string sql = string.Format("Select * from NHANVIEN");
            if (data.Execute(sql) == false)
            {
                return null;
            }
            else
            {
                return null;
            }
        }
    }
}