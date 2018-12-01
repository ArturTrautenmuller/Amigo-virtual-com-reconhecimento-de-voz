using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.System.Diagnostics;
using System.Diagnostics;
using Windows.Media.SpeechRecognition;
using System.ComponentModel;
using Windows.Web.Http;
using Windows.UI.Xaml.Media.Imaging;


namespace Friend
{
    
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

      
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Comunicacao.falar("Olá, eu ainda não tenho nome, mas eu serei sua amiga");

        }

        private async void button1_Click(object sender, RoutedEventArgs e)
        {

            String vozResultado =  await Comunicacao.ouvir();
            String res = Mente.resposta(vozResultado);
            image.Source = Mente.mudarRosto(vozResultado);
            Comunicacao.falar(res);
            text.Text = res;
           

        }
    }
}
