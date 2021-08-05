using System;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenBottomDrawerButton_Clicked(object sender, EventArgs e)
        {
            this.ShowPopup(new BottomDrawerPopup());
        }
    }
}
