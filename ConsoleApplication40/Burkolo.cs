using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication40
{
    public class Burkolo : Mesterember
    {
        public Szakterulet szakterulet;

        public Burkolo() 
        {
            throw new System.NotImplementedException();
        }

        public Szakterulet Szakterulet
        {
            get
            {
                return szakterulet;
            }

            set
            {
                if (value < Szakterulet.Belso) 
                    return;

                if (value > Szakterulet.Kulso)
                    return;

                szakterulet = value;
            }
        }

        public void OsszesSzabadnap()
        {
            int szabadnapok = 0;

            for (int i = 0; i < 31; i++)
            {
                if (Foglaltnapok[i] == false)
                {
                    szabadnapok = szabadnapok + 1;
                }
                if (i == 31)
                Console.WriteLine("Összes szabadnap száma:" + szabadnapok);
            }
        }

        public void MindenAdat()
        {
            string s = 
        }

        public override int MunkatVallal(bool adottnap)
        {
            for (int i = 0; i < 30; i++)

                if (Foglaltnapok[i] = adottnap && false)
                {
                    Foglaltnapok[i] = true; // lefoglalás
                }

                else
                    Foglaltnapok[i] = false;
                 

        }
    }
}