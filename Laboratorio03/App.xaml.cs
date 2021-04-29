using Laboratorio03.Services;
using Laboratorio03.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio03
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
    }
}
