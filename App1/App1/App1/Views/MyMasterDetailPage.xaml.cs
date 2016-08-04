using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1.Views
{
    public partial class MyMasterDetailPage : MasterDetailPage
    {
        public MyMasterDetailPage()
        {
            InitializeComponent();
        }

        private void Button1_OnClicked(object sender, EventArgs e)
        {
            ChangeDetail(new DetailPage1());
        }

        private void Button2_OnClicked(object sender, EventArgs e)
        {
            ChangeDetail(new DetailPage2());
        }

        private void ChangeDetail(Page page)
        {
            var navigationPage = Detail as NavigationPage;
            if (navigationPage != null)
            {
                navigationPage.PushAsync(page);
                return;
            }

            Detail = new NavigationPage(page);
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
