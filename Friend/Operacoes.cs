using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friend
{
    class Operacoes
    {
        public static String somar(String inp)
        {
            try
            {
                char[] inpc = inp.ToCharArray();
                int posicaoMais = 0, n1, n2;
                String n1s = "", n2s = "";

                for (int i = 0; i < inpc.Length; i++)
                {
                    if (inpc[i] == '+') { posicaoMais = i; break; }
                }

                for (int i = 0; i < posicaoMais - 1; i++)
                {
                    n1s += inpc[i];
                }

                n1 = Convert.ToInt32(n1s);

                for (int i = posicaoMais + 1; i < inpc.Length; i++)
                {
                    n2s += inpc[i];
                }

                n2 = Convert.ToInt32(n2s);


                return "bem, eu acho que é " + Convert.ToString(n1 + n2);
            }

            catch (Exception e)
            {
                return "desculpe, não entendi";
            }
        }


        public static String subtrair(String inp)
        {
            try
            {
                char[] inpc = inp.ToCharArray();
                int posicaoMais = 0, n1, n2;
                String n1s = "", n2s = "";

                for (int i = 0; i < inpc.Length; i++)
                {
                    if (inpc[i] == '-') { posicaoMais = i; break; }
                }

                for (int i = 0; i < posicaoMais - 1; i++)
                {
                    n1s += inpc[i];
                }

                n1 = Convert.ToInt32(n1s);

                for (int i = posicaoMais + 1; i < inpc.Length; i++)
                {
                    n2s += inpc[i];
                }

                n2 = Convert.ToInt32(n2s);


                return "bem, eu acho que é " + Convert.ToString(n1 - n2);
            }

            catch (Exception e)
            {
                return "desculpe, não entendi";
            }
        }

        public static String multiplicar(String inp)
        {
            try
            {
                char[] inpc = inp.ToCharArray();
                int posicaoMais = 0, n1, n2;
                String n1s = "", n2s = "";

                for (int i = 0; i < inpc.Length; i++)
                {
                    if (inpc[i] == 'v') { posicaoMais = i; break; }
                }

                for (int i = 0; i < posicaoMais - 1; i++)
                {
                    n1s += inpc[i];
                }

                n1 = Convert.ToInt32(n1s);

                for (int i = posicaoMais + 6; i < inpc.Length; i++)
                {
                    n2s += inpc[i];
                }

                n2 = Convert.ToInt32(n2s);


                return "bem, eu acho que é " + Convert.ToString(n1*n2);
            }

            catch (Exception e)
            {
                return "desculpe, não entendi";
            }
        }

        public static String dividir(String inp)
        {
            try
            {
                char[] inpc = inp.ToCharArray();
                int posicaoMais = 0, n1, n2;
                String n1s = "", n2s = "";

                for (int i = 0; i < inpc.Length; i++)
                {
                    if (inpc[i] == 'd') { posicaoMais = i; break; }
                }

                for (int i = 0; i < posicaoMais - 1; i++)
                {
                    n1s += inpc[i];
                }

                n1 = Convert.ToInt32(n1s);

                for (int i = posicaoMais + 13; i < inpc.Length; i++)
                {
                    n2s += inpc[i];
                }

                n2 = Convert.ToInt32(n2s);

                if (n2 == 0) return "não é possivel dividir por 0";

                return "bem, eu acho que é " + Convert.ToString(n1 / n2);
            }

            catch (Exception e)
            {
                return "desculpe, não entendi";
            }
        }
    }
}
