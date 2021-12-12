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
//using Windows.ApplicationModel.Resources.Core;
//using Windows.Globalization;
using Windows.Media.SpeechSynthesis;
using Microsoft.Toolkit.Uwp.Input.GazeInteraction;
using Windows.UI.ViewManagement;

// 空白頁項目範本已記錄在 https://go.microsoft.com/fwlink/?LinkId=234238

namespace eyetalk
{
    /// <summary>
    /// 可以在本身使用或巡覽至框架內的空白頁面。
    /// </summary>
    public sealed partial class BlankPage5 : Page
    {
        SpeechSynthesizer speechSynthesizer;
        //語音宣告
        public BlankPage5()
        {
            this.InitializeComponent();
            ApplicationView.PreferredLaunchViewSize = new Size(1280, 720);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(1280, 720));
           //解析度
            speechSynthesizer = new SpeechSynthesizer();
            //語音宣告
        }




        private async void Talk(string message)
        {
            var stream = await speechSynthesizer.SynthesizeTextToStreamAsync(message);
            media.SetSource(stream, stream.ContentType);
            media.Play();
        }
        //語音撥放器



        private void Sback_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Stext.Text))
                //如果是空白的話就不執行下面這一行程式
                Stext.Text = Stext.Text.Substring(0, Stext.Text.Length - 1);
        }
        //倒退情除
        private void A00_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + " ";
        }
        //空白字元
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Talk(Stext.Text);
        }
        //發音
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        //回上頁
        private void A0a_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0a.Content;
        }

        private void A0b_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0b.Content;
        }

        private void A0c_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0c.Content;
        }
        private void A0d_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0d.Content;
        }

        private void A0e_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0e.Content;
        }

        private void A0f_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0f.Content;
        }
        private void A0g_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0g.Content;
        }

        private void A0h_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0h.Content;
        }

        private void A0i_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0i.Content;
        }
        private void A0j_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0j.Content;
        }

        private void A0k_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0k.Content;
        }

        private void A0l_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0l.Content;
        }
        private void A0m_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0m.Content;
        }

        private void A0n_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0n.Content;
        }

        private void A0o_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0o.Content;
        }
        private void A0p_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0p.Content;
        }

        private void A0q_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0q.Content;
        }

        private void A0r_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0r.Content;
        }
        private void A0s_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0s.Content;
        }

        private void A0t_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0t.Content;
        }

        private void A0u_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0u.Content;
        }
        private void A0v_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0v.Content;
        }

        private void A0w_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0w.Content;
        }

        private void A0x_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0x.Content;
        }
        private void A0y_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0y.Content;
        }

        private void A0z_Click(object sender, RoutedEventArgs e)
        {
            Stext.Text = Stext.Text + a0z.Content;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Stext.Text = "";
        }
    }
}
