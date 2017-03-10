using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication40
{
    public abstract class Mesterember
    {
        public string Nev;
        protected int Napidij;
        public bool[] Foglaltnapok = new bool[31];

        public Mesterember(string Nev, string Napidij)
        {
            for (int i = 0; i < 30; i++)
            {
                Foglaltnapok[i] = false;
            }
               

        }

        public void MindenAdat()
        {
            throw new System.NotImplementedException();
        }

        public abstract int MunkatVallal();
        
    }
}