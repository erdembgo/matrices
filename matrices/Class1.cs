using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Class1
    {
        private  int[,] matris;
        public Class1(int satir, int sutun)
        {
            matris = new int[satir, sutun];
        }
        public int this [int satir, int sutun]
        {
            get
            {
                return matris[satir, sutun];
            }
            set
            {
            }       
        }
    }
}
