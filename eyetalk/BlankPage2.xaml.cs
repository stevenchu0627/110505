using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.ApplicationModel.Resources.Core;
using Windows.Globalization;
using Windows.Media.SpeechSynthesis;
using Microsoft.Toolkit.Uwp.Input.GazeInteraction;
using Windows.UI.ViewManagement;

// 空白頁項目範本已記錄在 https://go.microsoft.com/fwlink/?LinkId=234238
// 20211026
namespace eyetalk
{
    /// <summary>
    /// 可以在本身使用或巡覽至框架內的空白頁面。
    /// </summary>
    public sealed partial class BlankPage2 : Page
    {
        static int x;
        string pinyinChar;
        SpeechSynthesizer speechSynthesizer;
        //語音的宣告
        public partial class WordPack
        {
            [JsonProperty("zhuyin")]
            public string Zhuyin { get; set; }

            [JsonProperty("pinyin")]
            public string Pinyin { get; set; }

            [JsonProperty("word")]
            public List<string> Word { get; set; }
        }
        //json注音檔的宣告
        public BlankPage2()
        {
            this.InitializeComponent();
            ApplicationView.PreferredLaunchViewSize = new Size(1280, 720);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(1280, 720));
            speechSynthesizer = new SpeechSynthesizer();
            //語音的宣告

        }
        private async void Talk(string message)
        {
            var stream = await speechSynthesizer.SynthesizeTextToStreamAsync(message);
            media.SetSource(stream, stream.ContentType);
            media.Play();
        }
        //語音撥放器
        private void Xime()
        {
            pinyinChar = t01.Text + t02.Text + t03.Text + t04.Text;
            string PC = pinyinChar;
            //讀取注音檔
            using (StreamReader file = File.OpenText(@"assets\results.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o = (JObject)JToken.ReadFrom(reader);


                JArray a = (JArray)o["WordPack"];

                IList<WordPack> person = a.ToObject<IList<WordPack>>();

                //textBox.Text = (person[20].Word[3]);                

                //string free = o["WordPack"]
                //.Where(jt => (string)jt["zhuyin"] == PC)
                //.Select(jt => (string)jt["word"][0])
                //.FirstOrDefault();

                var new_free = o["WordPack"]
                                .Where(jt => (string)jt["zhuyin"] == PC)
                                .Select(jt => jt["word"])
                                .FirstOrDefault();

                if (new_free != null)
                {
                    t88.Text = string.Empty;
                    foreach (string new_frees in new_free)
                    {
                        t88.Text += new_frees;
                    }
                }
                else
                {
                    t88.Text = string.Empty;
                }

                //Talk(t99.Text);
            }
        }
        //注音搜尋
        private void A01_Click(object sender, RoutedEventArgs e)
        {
            x = 1;
            a01.IsEnabled = false;
            a02.IsEnabled = false;
            a03.IsEnabled = false;
            a04.IsEnabled = false;
            a05.IsEnabled = false;
            a06.IsEnabled = false;
            ime_1.Content = "";
            ime_2.Content = "ㄅ";
            ime_3.Content = "ㄆ";
            ime_4.Content = "ㄇ";
            ime_5.Content = "ㄈ";

        }



        private void A02_Click(object sender, RoutedEventArgs e)
        {
            x = 1;
            a01.IsEnabled = false;
            a02.IsEnabled = false;
            a03.IsEnabled = false;
            a04.IsEnabled = false;
            a05.IsEnabled = false;
            a06.IsEnabled = false;
            ime_1.Content = "";
            ime_2.Content = "ㄉ";
            ime_3.Content = "ㄊ";
            ime_4.Content = "ㄋ";
            ime_5.Content = "ㄌ";
        }

        private void A03_Click(object sender, RoutedEventArgs e)
        {
            x = 1;
            a01.IsEnabled = false;
            a02.IsEnabled = false;
            a03.IsEnabled = false;
            a04.IsEnabled = false;
            a05.IsEnabled = false;
            a06.IsEnabled = false;
            ime_1.Content = "";
            ime_2.Content = "";
            ime_3.Content = "ㄍ";
            ime_4.Content = "ㄎ";
            ime_5.Content = "ㄏ";
        }

        private void A04_Click(object sender, RoutedEventArgs e)
        {
            x = 1;
            a01.IsEnabled = false;
            a02.IsEnabled = false;
            a03.IsEnabled = false;
            a04.IsEnabled = false;
            a05.IsEnabled = false;
            a06.IsEnabled = false;
            ime_1.Content = "";
            ime_2.Content = "";
            ime_3.Content = "ㄐ";
            ime_4.Content = "ㄑ";
            ime_5.Content = "ㄒ";
        }

        private void A05_Click(object sender, RoutedEventArgs e)
        {
            x = 1;
            a01.IsEnabled = false;
            a02.IsEnabled = false;
            a03.IsEnabled = false;
            a04.IsEnabled = false;
            a05.IsEnabled = false;
            a06.IsEnabled = false;
            ime_1.Content = "";
            ime_2.Content = "ㄓ";
            ime_3.Content = "ㄔ";
            ime_4.Content = "ㄕ";
            ime_5.Content = "ㄖ";
        }

        private void A06_Click(object sender, RoutedEventArgs e)
        {
            x = 1;
            a01.IsEnabled = false;
            a02.IsEnabled = false;
            a03.IsEnabled = false;
            a04.IsEnabled = false;
            a05.IsEnabled = false;
            a06.IsEnabled = false;
            ime_1.Content = "";
            ime_2.Content = "";
            ime_3.Content = "ㄗ";
            ime_4.Content = "ㄘ";
            ime_5.Content = "ㄙ";
        }

        private void Ime_1_Click(object sender, RoutedEventArgs e)
        {
            switch (x)
            {
                case 1:
                    t01.Text = Convert.ToString(ime_1.Content);
                    break;
                case 2:
                    t02.Text = Convert.ToString(ime_1.Content);
                    break;
                case 3:
                    t03.Text = Convert.ToString(ime_1.Content);
                    break;
                case 4:
                    t04.Text = Convert.ToString(ime_1.Content);
                    break;
            }
            Xime();

        }
        private void Ime_2_Click(object sender, RoutedEventArgs e)
        {
            switch (x)
            {
                case 1:
                    t01.Text = Convert.ToString(ime_2.Content);
                    break;
                case 2:
                    t02.Text = Convert.ToString(ime_2.Content);
                    break;
                case 3:
                    t03.Text = Convert.ToString(ime_2.Content);
                    break;
                case 4:
                    t04.Text = Convert.ToString(ime_2.Content);
                    break;
            }
            Xime();
        }

        private void Ime_3_Click(object sender, RoutedEventArgs e)
        {
            switch (x)
            {
                case 1:
                    t01.Text = Convert.ToString(ime_3.Content);
                    break;
                case 2:
                    t02.Text = Convert.ToString(ime_3.Content);
                    break;
                case 3:
                    t03.Text = Convert.ToString(ime_3.Content);
                    break;
                case 4:
                    t04.Text = Convert.ToString(ime_3.Content);
                    break;
            }
            Xime();
        }
        private void Ime_4_Click(object sender, RoutedEventArgs e)
        {
            switch (x)
            {
                case 1:
                    t01.Text = Convert.ToString(ime_4.Content);
                    break;
                case 2:
                    t02.Text = Convert.ToString(ime_4.Content);
                    break;
                case 3:
                    t03.Text = Convert.ToString(ime_4.Content);
                    break;
                case 4:
                    t04.Text = Convert.ToString(ime_4.Content);
                    break;
            }
            Xime();
        }

        private void Ime_5_Click(object sender, RoutedEventArgs e)
        {
            switch (x)
            {
                case 1:
                    t01.Text = Convert.ToString(ime_5.Content);
                    break;
                case 2:
                    t02.Text = Convert.ToString(ime_5.Content);
                    break;
                case 3:
                    t03.Text = Convert.ToString(ime_5.Content);
                    break;
                case 4:
                    t04.Text = Convert.ToString(ime_5.Content);
                    break;
            }
            Xime();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            pinyinChar = t01.Text + t02.Text + t03.Text + t04.Text;
            string PC = pinyinChar;
            //讀取注音檔
            using (StreamReader file = File.OpenText(@"assets\results.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o = (JObject)JToken.ReadFrom(reader);


                JArray a = (JArray)o["WordPack"];

                IList<WordPack> person = a.ToObject<IList<WordPack>>();

                //textBox.Text = (person[20].Word[3]);                

                string free = o["WordPack"]
                .Where(jt => (string)jt["zhuyin"] == PC)
                .Select(jt => (string)jt["word"][0])
                .FirstOrDefault();

                t99.Text += free;
                Talk(t99.Text);
            }
            a01.IsEnabled = true;
            a02.IsEnabled = true;
            a03.IsEnabled = true;
            a04.IsEnabled = true;
            a05.IsEnabled = true;
            a06.IsEnabled = true;
            b01.IsEnabled = true;
            c01.IsEnabled = true;
            c02.IsEnabled = true;
            c03.IsEnabled = true;
            //t99.Text = "";
            t01.Text = "";
            t02.Text = "";
            t03.Text = "";
            t04.Text = "";
            t88.Text = "";
            ime_1.Content = "";
            ime_2.Content = "";
            ime_3.Content = "";
            ime_4.Content = "";
            ime_5.Content = "";
        }

        private void A99_Click(object sender, RoutedEventArgs e)
        {
            a01.IsEnabled = true;
            a02.IsEnabled = true;
            a03.IsEnabled = true;
            a04.IsEnabled = true;
            a05.IsEnabled = true;
            a06.IsEnabled = true;
            t01.Text = "";
        }

        private void B01_Click(object sender, RoutedEventArgs e)
        {
            x = 2;
            b01.IsEnabled = false;
            ime_1.Content = "";
            ime_2.Content = "";
            ime_3.Content = "ㄧ";
            ime_4.Content = "ㄨ";
            ime_5.Content = "ㄩ";
        }

        private void C01_Click(object sender, RoutedEventArgs e)
        {
            x = 3;
            c01.IsEnabled = false;
            c02.IsEnabled = false;
            c03.IsEnabled = false;

            ime_1.Content = "ㄚ";
            ime_2.Content = "ㄛ";
            ime_3.Content = "ㄜ";
            ime_4.Content = "ㄝ";
            ime_5.Content = "ㄦ";
        }

        private void C02_Click(object sender, RoutedEventArgs e)
        {
            x = 3;
            c01.IsEnabled = false;
            c02.IsEnabled = false;
            c03.IsEnabled = false;

            ime_1.Content = "";
            ime_2.Content = "ㄞ";
            ime_3.Content = "ㄟ";
            ime_4.Content = "ㄠ";
            ime_5.Content = "ㄡ";
        }

        private void C03_Click(object sender, RoutedEventArgs e)
        {
            x = 3;
            c01.IsEnabled = false;
            c02.IsEnabled = false;
            c03.IsEnabled = false;
            ime_1.Content = "";
            ime_2.Content = "ㄢ";
            ime_3.Content = "ㄣ";
            ime_4.Content = "ㄤ";
            ime_5.Content = "ㄥ";
        }

        private void D01_Click(object sender, RoutedEventArgs e)
        {
            x = 4;
            ime_1.Content = "˙";
            ime_2.Content = "";
            ime_3.Content = "ˊ";
            ime_4.Content = "ˇ";
            ime_5.Content = "ˋ";
        }

        private void C99_Click(object sender, RoutedEventArgs e)
        {
            b01.IsEnabled = true;
            t02.Text = "";
        }

        private void B99_Click(object sender, RoutedEventArgs e)
        {
            c01.IsEnabled = true;
            c02.IsEnabled = true;
            c03.IsEnabled = true;
            t03.Text = "";
        }

        private void G99_Click(object sender, RoutedEventArgs e)
        {
            Talk(t99.Text);
        }

        private void G88_Click(object sender, RoutedEventArgs e)
        {
            a01.IsEnabled = true;
            a02.IsEnabled = true;
            a03.IsEnabled = true;
            a04.IsEnabled = true;
            a05.IsEnabled = true;
            a06.IsEnabled = true;
            b01.IsEnabled = true;
            c01.IsEnabled = true;
            c02.IsEnabled = true;
            c03.IsEnabled = true;
            t99.Text = "";
            t01.Text = "";
            t02.Text = "";
            t03.Text = "";
            t04.Text = "";
            t88.Text = "";
            ime_1.Content = "";
            ime_2.Content = "";
            ime_3.Content = "";
            ime_4.Content = "";
            ime_5.Content = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
