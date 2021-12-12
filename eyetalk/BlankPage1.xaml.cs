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
    public sealed partial class BlankPage1 : Page
    {

    SpeechSynthesizer speechSynthesizer;
    //語音的宣告
    public BlankPage1()
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

    private void Button_Click(object sender, RoutedEventArgs e)
    {

            Talk(s_text.Text);

        }

        private void Home_Click(object sender, RoutedEventArgs e)
    {
        s_text.Text = "";
        s01.IsEnabled = true;
        s02.IsEnabled = true;
        s03.IsEnabled = true;
        s04.IsEnabled = true;
        s05.IsEnabled = true;
        s06.IsEnabled = true;
        s07.IsEnabled = true;
        f01.IsEnabled = false;
        f02.IsEnabled = false;
        f03.IsEnabled = false;
        f04.IsEnabled = false;
        f05.IsEnabled = false;
        f06.IsEnabled = false;

    }

    private void S01_Click(object sender, RoutedEventArgs e)
    {
        s_text.Text = s_text.Text + s01.Content;
        s01.IsEnabled = false;
        s02.IsEnabled = false;
        s03.IsEnabled = false;
        s04.IsEnabled = false;
        s05.IsEnabled = false;
        s06.IsEnabled = false;
        s07.IsEnabled = false;
        f01.IsEnabled = true;
        f02.IsEnabled = true;
        f03.IsEnabled = true;
        f04.IsEnabled = true;
        f05.IsEnabled = true;
        f06.IsEnabled = true;
    }

    private void S02_Click(object sender, RoutedEventArgs e)
    {
        s_text.Text = s_text.Text + s02.Content;
        s01.IsEnabled = false;
        s02.IsEnabled = false;
        s03.IsEnabled = false;
        s04.IsEnabled = false;
        s05.IsEnabled = false;
        s06.IsEnabled = false;
        s07.IsEnabled = false;
        f01.IsEnabled = true;
        f02.IsEnabled = true;
        f03.IsEnabled = true;
        f04.IsEnabled = true;
        f05.IsEnabled = true;
        f06.IsEnabled = true;
    }
    private void S03_Click(object sender, RoutedEventArgs e)
    {
        s_text.Text = s_text.Text + s03.Content;
        s01.IsEnabled = false;
        s02.IsEnabled = false;
        s03.IsEnabled = false;
        s04.IsEnabled = false;
        s05.IsEnabled = false;
        s06.IsEnabled = false;
        s07.IsEnabled = false;
        f01.IsEnabled = true;
        f02.IsEnabled = true;
        f03.IsEnabled = true;
        f04.IsEnabled = true;
        f05.IsEnabled = true;
        f06.IsEnabled = true;
    }
    private void S04_Click(object sender, RoutedEventArgs e)
    {
        s_text.Text = s_text.Text + s04.Content;
        s01.IsEnabled = false;
        s02.IsEnabled = false;
        s03.IsEnabled = false;
        s04.IsEnabled = false;
        s05.IsEnabled = false;
        s06.IsEnabled = false;
        s07.IsEnabled = false;
        f01.IsEnabled = true;
        f02.IsEnabled = true;
        f03.IsEnabled = true;
        f04.IsEnabled = true;
        f05.IsEnabled = true;
        f06.IsEnabled = true;
    }

    private void S05_Click(object sender, RoutedEventArgs e)
    {
        s_text.Text = s_text.Text + s05.Content;
        s01.IsEnabled = false;
        s02.IsEnabled = false;
        s03.IsEnabled = false;
        s04.IsEnabled = false;
        s05.IsEnabled = false;
        s06.IsEnabled = false;
        s07.IsEnabled = false;
        f01.IsEnabled = true;
        f02.IsEnabled = true;
        f03.IsEnabled = true;
        f04.IsEnabled = true;
        f05.IsEnabled = true;
        f06.IsEnabled = true;
    }

    private void S07_Click(object sender, RoutedEventArgs e)
    {
        s_text.Text = s_text.Text + s07.Content;
        s01.IsEnabled = false;
        s02.IsEnabled = false;
        s03.IsEnabled = false;
        s04.IsEnabled = false;
        s05.IsEnabled = false;
        s06.IsEnabled = false;
        s07.IsEnabled = false;
        f01.IsEnabled = true;
        f02.IsEnabled = true;
        f03.IsEnabled = true;
        f04.IsEnabled = true;
        f05.IsEnabled = true;
        f06.IsEnabled = true;
    }

    private void S06_Click(object sender, RoutedEventArgs e)
    {
        s_text.Text = s_text.Text + s06.Content;
        s01.IsEnabled = false;
        s02.IsEnabled = false;
        s03.IsEnabled = false;
        s04.IsEnabled = false;
        s05.IsEnabled = false;
        s06.IsEnabled = false;
        s07.IsEnabled = false;
        f01.IsEnabled = true;
        f02.IsEnabled = true;
        f03.IsEnabled = true;
        f04.IsEnabled = true;
        f05.IsEnabled = true;
        f06.IsEnabled = true;
    }

    private void F04_Click(object sender, RoutedEventArgs e)
    {
        s_text.Text = s_text.Text + f04.Content;
        s01.IsEnabled = true;
        s02.IsEnabled = true;
        s03.IsEnabled = true;
        s04.IsEnabled = true;
        s05.IsEnabled = true;
        s06.IsEnabled = true;
        s07.IsEnabled = true;
        f01.IsEnabled = false;
        f02.IsEnabled = false;
        f03.IsEnabled = false;
        f04.IsEnabled = false;
        f05.IsEnabled = false;
        f06.IsEnabled = false;
    }

    private void F01_Click(object sender, RoutedEventArgs e)
    {
        s_text.Text = s_text.Text + f01.Content;
        s01.IsEnabled = true;
        s02.IsEnabled = true;
        s03.IsEnabled = true;
        s04.IsEnabled = true;
        s05.IsEnabled = true;
        s06.IsEnabled = true;
        s07.IsEnabled = true;
        f01.IsEnabled = false;
        f02.IsEnabled = false;
        f03.IsEnabled = false;
        f04.IsEnabled = false;
        f05.IsEnabled = false;
        f06.IsEnabled = false;
    }

    private void F02_Click(object sender, RoutedEventArgs e)
    {
        s_text.Text = s_text.Text + f02.Content;
        s01.IsEnabled = true;
        s02.IsEnabled = true;
        s03.IsEnabled = true;
        s04.IsEnabled = true;
        s05.IsEnabled = true;
        s06.IsEnabled = true;
        s07.IsEnabled = true;
        f01.IsEnabled = false;
        f02.IsEnabled = false;
        f03.IsEnabled = false;
        f04.IsEnabled = false;
        f05.IsEnabled = false;
        f06.IsEnabled = false;
    }

    private void F06_Click(object sender, RoutedEventArgs e)
    {
        s_text.Text = s_text.Text + f06.Content;
        s01.IsEnabled = true;
        s02.IsEnabled = true;
        s03.IsEnabled = true;
        s04.IsEnabled = true;
        s05.IsEnabled = true;
        s06.IsEnabled = true;
        s07.IsEnabled = true;
        f01.IsEnabled = false;
        f02.IsEnabled = false;
        f03.IsEnabled = false;
        f04.IsEnabled = false;
        f05.IsEnabled = false;
        f06.IsEnabled = false;
    }

    private void F03_Click(object sender, RoutedEventArgs e)
    {
        s_text.Text = s_text.Text + f03.Content;
        s01.IsEnabled = true;
        s02.IsEnabled = true;
        s03.IsEnabled = true;
        s04.IsEnabled = true;
        s05.IsEnabled = true;
        s06.IsEnabled = true;
        s07.IsEnabled = true;
        f01.IsEnabled = false;
        f02.IsEnabled = false;
        f03.IsEnabled = false;
        f04.IsEnabled = false;
        f05.IsEnabled = false;
        f06.IsEnabled = false;
    }

    private void F05_Click(object sender, RoutedEventArgs e)
    {
        s_text.Text = s_text.Text + f05.Content;
        s01.IsEnabled = true;
        s02.IsEnabled = true;
        s03.IsEnabled = true;
        s04.IsEnabled = true;
        s05.IsEnabled = true;
        s06.IsEnabled = true;
        s07.IsEnabled = true;
        f01.IsEnabled = false;
        f02.IsEnabled = false;
        f03.IsEnabled = false;
        f04.IsEnabled = false;
        f05.IsEnabled = false;
        f06.IsEnabled = false;
    }

    private void C01_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
    {

        GazeInput.SetCursorRadius(this, Convert.ToInt32(c01.Value));
    }

    private void C02_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
    {
        string temp = "00:00:0" + Convert.ToString(c02.Value) + "." + Convert.ToString(c03.Value) + "0000";
        TimeSpan time = TimeSpan.Parse(temp);
        GazeInput.SetDwellDuration(this, time);
        //GazeInput.SetDwellDuration(this,Convert.(c02.Value)); 
        //GazeInput.SetDwellDuration(this,12660000);

    }

    private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
    {
        string temp = "00:00:0" + Convert.ToString(c02.Value) + "." + Convert.ToString(c03.Value) + "0000";
        TimeSpan time = TimeSpan.Parse(temp);
        GazeInput.SetDwellDuration(this, time);
    }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
