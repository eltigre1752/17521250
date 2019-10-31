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
    public partial class ThemLoaiHoa : ContentPage
    {
        public ThemLoaiHoa()
        {
            InitializeComponent();
        }

        async void ThemLoai_Clicked(object sender, EventArgs e)
        {
            LoaiHoa temp = new LoaiHoa();
            temp.TenLoai = entry.Text;
            await App.Database.LuuLoaiHoa(temp);
            await Navigation.PopAsync();
        }
    }
}
