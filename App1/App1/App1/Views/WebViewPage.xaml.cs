using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1.Views
{
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Volta para a página Inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Voltar_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MyContentPage();
        }
    }
}
