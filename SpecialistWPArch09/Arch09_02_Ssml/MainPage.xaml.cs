using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Arch09_02_Ssml.Resources;
using Windows.Phone.Speech.Synthesis;

namespace Arch09_02_Ssml
{
    public partial class MainPage : PhoneApplicationPage
    {
        // コンストラクター
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            var synth = new SpeechSynthesizer();
            await synth.SpeakSsmlAsync(textBox.Text);
        }
    }
}