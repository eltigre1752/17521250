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
    public partial class ViewLoaiHoa : ContentPage
    {
        public ViewLoaiHoa()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            viewLoaiHoa.ItemsSource = await App.Database.LietKeLoaiHoa();
        }

        private void OnSelected(object sender, EventArgs e)
        {
            int temp = ((LoaiHoa)viewLoaiHoa.SelectedItem).MaLoai;
            Navigation.PushAsync(new ViewHoa(temp));
        }

        private void Them_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThemLoaiHoa());
        }
    }
}
