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
using DataAccess;
using DataTransferObject;


namespace Business
{
    public class DangNhap_BUS
    {
        private readonly DangNhap_DAL dangNhap = new DangNhap_DAL();
        public NhanVien_Object DangNhap(string taiKhoan, string matKhau)
        {
            return dangNhap.DangNhap(taiKhoan, matKhau);
        }
    }
}