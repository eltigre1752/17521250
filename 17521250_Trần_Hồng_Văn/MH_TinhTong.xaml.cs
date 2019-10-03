using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baitap1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MH_TinhTong : ContentPage
    {
        public MH_TinhTong()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double tempA = Double.Parse(txtA.Text);
            double tempB = Double.Parse(txtB.Text);
            double sum = tempA + tempB;
            txtSum.Text = sum.ToString();
        }

        private void CmdBackNav_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}