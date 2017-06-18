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

namespace DataTransferObject
{   
    public class NhanVien_Object
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string MaHoa { get; set; }
    }
    
}