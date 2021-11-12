using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Matris
    {
        int[,] matris;
        int satirsayisi;
        int sutunsayisi;
        public Matris(int satir, int sutun)
        {
            matris = new int[satir, sutun];
            satirsayisi = satir;
            sutunsayisi = sutun;
        }
        public int this[int satir ,int sutun]
        {
            get
            {
                return matris[satir, sutun];
            }
            set 
            {
                matris[satir, sutun] = value;
            }
        }
    }
}
