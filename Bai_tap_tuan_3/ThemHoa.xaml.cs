using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baitap3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThemHoa : ContentPage
    {
        public ThemHoa()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            TypePicker.ItemsSource = await App.Database.LietKeLoaiHoa();
        }

        private async void cmd_Them_Clicked(object sender, EventArgs e)
        {
            Hoa temp = new Hoa();
            temp.MaLoai = TypePicker.SelectedIndex;
            temp.TenHoa = TenHoa.Text;
            temp.Hinh = Hinh.Text;
            temp.DonGia = DonGia.Text;
            temp.MoTa = MoTa.Text;

            await App.Database.LuuHoa(temp);
            await Navigation.PopAsync();
        }

        private async void cmd_Xoa_Clicked(object sender, EventArgs e)
        {
            Hoa temp = new Hoa();
            temp.TenHoa = TenHoa.Text;
            await App.Database.XoaHoa(temp);
            await Navigation.PopAsync();
            
        }
    }
}
