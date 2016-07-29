using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1.Views
{
    public partial class ComponentsPage : ContentPage
    {
        public ComponentsPage()
        {
            InitializeComponent();

            //Código para setar imagem de acordo com o dispositivo e localização da imagem
            //imgXmarin.Source = Device.OnPlatform( iOS: ImageSource.FromFile("Images/Xamarin.png"),
            //                                  Android: ImageSource.FromFile("Xamarin.png"),
            //                                 WinPhone: ImageSource.FromFile("Assets/Xamarin.png"));

            LoadProgressBar();

        }

        void MySlider_ValueChanged(object sender, EventArgs e)
        {   

            txtSliderValue.Text = mySlider.Value.ToString();
        }

        private async void LoadProgressBar()
        {
            myProgressBar.Progress = .1;

            await myProgressBar.ProgressTo(.9, 3000, Easing.Linear);
        }

        void ChangeColor_Clicked(object sender, EventArgs e)
        {
            if (bvwColor.Color == Color.Green)
            {
                bvwColor.Color = Color.Blue;
            }
            else
            {
                bvwColor.Color = Color.Green;
            }
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
