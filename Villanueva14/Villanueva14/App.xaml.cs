using System;
using Villanueva14.DataContext;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Villanueva14
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        internal static AppDbContext GetContext()
        {
            throw new NotImplementedException();
        }
    }
}
