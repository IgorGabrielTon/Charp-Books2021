using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Books2021;

namespace Books2021.componentes.splash
{
    public class principalSplash 
    {
        public static bool Verificar()
        {
            return true;
        }

        public static String MsgLabel(int Msg)
        {
            String retorno = null;
            if (Msg == 1)
            {
                retorno = language.ptMsgLabel1;
            }
            else if (Msg == 2)
            {
                retorno = language.ptMsgLabel2;
            }
            else if (Msg == 3)
            {
                retorno = language.ptMsgLabel3;
            }
            else if (Msg == 4)
            {
                retorno = language.ptMsgLabel4;
            }
            else if (Msg == 5)
            {
                retorno = language.ptMsgLabel5;
            }
            else if (Msg == 6)
            {
                retorno = language.ptMsgLabel6;
            }
            else
            {
                retorno = "end";
            }
            return retorno;
        }
    }
}
