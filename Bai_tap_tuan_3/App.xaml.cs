using System;
using Xamarin.Forms;
using System.IO;
using Xamarin.Forms.Xaml;

namespace baitap3
{
    public partial class App : Application
    {
        static DBLoaiHoa database;
        public static DBLoaiHoa Database
        {
            get
            {
                if (database == null)
                {
                    database = new DBLoaiHoa(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DBLoaiHoa.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
