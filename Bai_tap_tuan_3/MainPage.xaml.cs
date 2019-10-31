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
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoaiHoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewLoaiHoa());
        }

        private void ThemHoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThemHoa());
        }
    }
}