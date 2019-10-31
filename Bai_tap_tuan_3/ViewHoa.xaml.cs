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
    public partial class ViewHoa : ContentPage
    {
        int MaLoai = 0;
        public ViewHoa()
        {
            InitializeComponent();
        }

        public ViewHoa(int MaLoai)
        {
            InitializeComponent();
            this.MaLoai = MaLoai;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (MaLoai == 0)
                viewHoa.ItemsSource = await App.Database.LietKeHoa();
            else
                viewHoa.ItemsSource = await App.Database.LietKeHoa(MaLoai);
        }
    }
}