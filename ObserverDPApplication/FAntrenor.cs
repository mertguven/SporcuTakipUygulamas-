using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDPApplication
{
    class FAntrenor : IAntrenor
    {
        public void BUpdate(Basketbolcu basketbolcu)
        {
            Form1.blabel.Visible = true;
        }

        public void FUpdate(Futbolcu futbolcu)
        {
            Form1.flabel.Visible = true;
        }

        public void VUpdate(Voleybolcu voleybolcu)
        {
            Form1.vlabel.Visible = true;
        }

        public void YUpdate(Yuzucu yuzucu)
        {
            Form1.ylabel.Visible = true;
        }
    }
}
