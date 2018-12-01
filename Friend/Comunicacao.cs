using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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



namespace Friend
{
    public class Comunicacao 
    {
        static Stopwatch stopWatch = new Stopwatch();
        

        public static async void falar(String fala) {
            int i = 0;
            double last = stopWatch.ElapsedMilliseconds;
            while (i < 3)
            {
                if (stopWatch.ElapsedMilliseconds + 150 > last)
                {
                    MediaElement mediaElement = new MediaElement();
                    var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                    Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync(fala);
                    mediaElement.SetSource(stream, stream.ContentType);
                    mediaElement.Play();
                    i++;
                    last = stopWatch.ElapsedMilliseconds;
                }
            }

        }

        public static async Task<String> ouvir()
        {
            var reconhecedorDeVoz = new Windows.Media.SpeechRecognition.SpeechRecognizer();

            await reconhecedorDeVoz.CompileConstraintsAsync();

            Windows.Media.SpeechRecognition.SpeechRecognitionResult resultado = await reconhecedorDeVoz.RecognizeWithUIAsync();

            return resultado.Text;
            
            
            
        }


    }
}
