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
        public int[] getLength()
        {
            int[] xy= { satirsayisi, sutunsayisi };
            return xy;
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

        public static Matris operator +(Matris m1, Matris m2)
        {
            Matris toplam = new Matris(m1.satirsayisi, m1.sutunsayisi);

            for (int i = 0; i < m1.satirsayisi; i++)
            {
                for (int k = 0; k < m1.sutunsayisi; k++)
                {
                    toplam[i, k] = m1[i, k] + m2[i, k];
                }
            }
            return toplam;
        }

        public static Matris operator *(Matris m1, Matris m2)
        {
            Matris carpim = new Matris(m1.satirsayisi, m2.sutunsayisi);
            
            for (int i = 0; i < m1.satirsayisi; i++)
            {
                for (int k = 0; k < m2.sutunsayisi; k++)
                {
                    int toplam = 0;
                    for (int j = 0; j < m1.sutunsayisi; j++)
                    {
                        toplam += m1[i, j] * m2[j, k];
                    }
                    carpim[i, k] = toplam;
                }
            }
            return carpim;
        }

        public static Matris operator *(Matris m, int katsayi)
        {
            Matris carpim = new Matris(m.satirsayisi, m.sutunsayisi);

            for (int i = 0; i < m.satirsayisi; i++)
            {
                for (int k = 0; k < m.sutunsayisi; k++)
                {
                    m[i, k] = m[i, k] * katsayi;
                }
            }
            return m;
        }

        public static Matris operator -(Matris m1, Matris m2)
        {
            Matris fark = new Matris(m1.satirsayisi, m1.sutunsayisi);

            for (int i = 0; i < m1.satirsayisi; i++)
            {
                for (int k = 0; k < m1.sutunsayisi; k++)
                {
                    fark[i, k] = m1[i, k] - m2[i, k];
                }
            }
            return fark;
        }
    }
}
