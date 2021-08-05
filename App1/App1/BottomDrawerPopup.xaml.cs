using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BottomDrawerPopup
    {
        private const double MinimumTranslationY = 10d;

        public BottomDrawerPopup()
        {
            InitializeComponent();
        }

        private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Running:
                    Frame.TranslationY = Math.Max(MinimumTranslationY, Frame.TranslationY + e.TotalY);
                    break;
            }
        }
    }
}