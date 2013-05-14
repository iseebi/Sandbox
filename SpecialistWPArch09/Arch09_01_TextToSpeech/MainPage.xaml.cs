using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Arch09_01_TextToSpeech.Resources;
using Windows.Phone.Speech.Synthesis;

namespace Arch09_01_TextToSpeech
{
    public partial class MainPage : PhoneApplicationPage
    {
        // コンストラクター
        public MainPage()
        {
            InitializeComponent();

            // ApplicationBar をローカライズするためのサンプル コード
            //BuildLocalizedApplicationBar();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("こんにちは、Windows Phone です。");
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var synth = new SpeechSynthesizer();
            var maleVoice = InstalledVoices.All
            .Where(v => (v.Gender == VoiceGender.Male) && (v.Language == "ja-JP"))
            .First();
            var femaleVoice = InstalledVoices.All
            .Where(v => (v.Gender == VoiceGender.Female) && (v.Language == "ja-JP"))
            .First();

            synth.SetVoice(femaleVoice);
            await synth.SpeakTextAsync("みなさま。まもなく2号線に、大阪梅田方面へ向かう電車が、到着します。");

            synth.SetVoice(maleVoice);
            await synth.SpeakTextAsync("みなさま。まもなく1号線に、神戸三宮方面へ向かう電車が、到着します。");
        }

        // ローカライズされた ApplicationBar を作成するためのサンプル コード
        //private void BuildLocalizedApplicationBar()
        //{
        //    // ページの ApplicationBar を ApplicationBar の新しいインスタンスに設定します。
        //    ApplicationBar = new ApplicationBar();

        //    // 新しいボタンを作成し、テキスト値を AppResources のローカライズされた文字列に設定します。
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // AppResources のローカライズされた文字列で、新しいメニュー項目を作成します。
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}