using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDPApplication
{
    interface IAntrenor
    {
        void FUpdate(Futbolcu futbolcu);
        void BUpdate(Basketbolcu basketbolcu);
        void VUpdate(Voleybolcu voleybolcu);
        void YUpdate(Yuzucu yuzucu);
    }
}
