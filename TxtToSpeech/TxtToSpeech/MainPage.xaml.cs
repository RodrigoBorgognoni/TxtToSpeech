using Plugin.TextToSpeech;
using System;
using Xamarin.Forms;

namespace TxtToSpeech
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void ClickedButton(object Sender, EventArgs args)
        {
            var text = Enter.Text;

            CrossTextToSpeech.Current.Speak(text);
        }


    }
}
