using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace baitap1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private void CmdWelcome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MH_Chao());
        }

        private void CmdTinhTong_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MH_TinhTong());
        }

        private void CmdLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MH_Login());
        }

        private void CmdCalculator_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calculator());
        }
    }
}
