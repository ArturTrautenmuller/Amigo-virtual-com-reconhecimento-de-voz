using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using System.Globalization;

namespace Friend
{
    class Mente
    {
        
       
        public static String resposta(String inp) {
            if (inp == "olá") return "Olá, a quanto tempo";
            if (inp == "como você está" || inp == "como está você") return "Eu estou bem, obrigada por perguntar";
            if (inp == "sorria" || inp == "sorriso" || inp == "sorrir") return "claro";
            if (inp.Contains("+")) return Operacoes.somar(inp);
            if (inp.Contains("-")) return Operacoes.subtrair(inp);
            if (inp.Contains("vezes")) return Operacoes.multiplicar(inp);
            if (inp.Contains("dividido por")) return Operacoes.dividir(inp);


            return "Desculpe, não sei o que falar";

        }

        public static BitmapImage mudarRosto(String inp) {

            if (inp == "sorria" || inp == "sorriso" || inp == "sorrir") return new BitmapImage(new Uri("ms-appx:///Assets/ccSorriso.jpg"));
            if(inp.Contains("+") || inp.Contains("-") || inp.Contains("vezes") || inp.Contains("dividido por")) return new BitmapImage(new Uri("ms-appx:///Assets/ccPensante.png"));
            return new BitmapImage(new Uri("ms-appx:///Assets/cc.jpg"));


        }

        

    }
}
