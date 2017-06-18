
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Business;

namespace QLKHO.Android
{
    [Activity(Label = "DangNhap_Activity", MainLauncher = true, Icon = "@drawable/icon")]
    public class DangNhap_Activity : Activity
    {
        private readonly DangNhap_BUS dangNhapBus = new DangNhap_BUS();
        EditText edtUserName, edtPassWord;
        Button btnDangNhap;
        string msg = "";
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DangNhap);

            edtUserName = FindViewById<EditText>(Resource.Id.edtUserName);
            edtPassWord = FindViewById<EditText>(Resource.Id.edtPassWord);
            btnDangNhap = FindViewById<Button>(Resource.Id.btnDangNhap);

            btnDangNhap.Click += BtnDangNhap_Click;

        }

        private void BtnDangNhap_Click(object sender, System.EventArgs e)
        {
            var dn = dangNhapBus.DangNhap(edtUserName.Text.Trim().ToString(), edtPassWord.Text.Trim().ToString());
            if(dn == null)
            {
                msg = "Lỗi";
            }
            else
            {
                //Android.Content intent = new Android.Content.Intent(this, typeof(MainActivity));
                Intent intent = new Intent(this, typeof(Menu_Activity));
                Bundle bundle = new Bundle();

                bundle.PutString("TenNhanVien", dn.TenNhanVien.ToString());
                bundle.PutString("PhanQuyen", dn.MaPhanQuyen.ToString());
                bundle.PutString("UserName", dn.TaiKhoan.ToString());

                intent.PutExtra("data", bundle);
                StartActivity(intent);

                msg = "Thành Công";
            }

            Toast.MakeText(this, msg, ToastLength.Long).Show();
        }

        public void clear()
        {
            edtUserName.Text = "";
            edtPassWord.Text = "";
        }
    }
}