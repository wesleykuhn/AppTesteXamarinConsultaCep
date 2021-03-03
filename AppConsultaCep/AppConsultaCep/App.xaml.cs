using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppConsultaCep
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent(); //Chama o initialize que irá chamar o App.xaml depois.

            //App.Current.MainPage = Isso irá mudar de página.

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
    }
}
