using System.Linq;
using DataTransferObject;
using System.Data;
using System.Collections.Generic;


namespace DataAccess
{
    public class DangNhap_DAL
    {
        private readonly Database data = new Database();
        public NhanVien_Object DangNhap(string taiKhoan, string matKhau)
        {
            string sql = string.Format("Select `TenNhanVien`, `MaChucVu` from `NhanVien` WHERE `TaiKhoan` LIKE '{0}' AND `MatKhau` LIKE '{1}'", taiKhoan, matKhau);
            if (data.Execute(sql) == false)
            {
                return null;
            }
            else
            {               
                DataTable dt = data.LoadData(sql);
                var nv = new NhanVien_Object()
                {                    
                    TenNhanVien = dt.Rows[0][0].ToString(),
                    MaPhanQuyen = int.Parse(dt.Rows[0][1].ToString())
                };         
                return nv;
            }
        }
    }
}