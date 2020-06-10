using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDPApplication
{
    class Futbolcu
    {
        public string Name { get;set; }
        private List<IAntrenor> _antrenors;

        public Futbolcu()
        {
            _antrenors = new List<IAntrenor>();
        }

        public void UyeEkle(IAntrenor antrenor)
        {
            _antrenors.Add(antrenor);
        }
        private void Notify()
        {
            foreach (IAntrenor antrenor in _antrenors)
            {
                antrenor.FUpdate(this);
            }
        }

        private int _sure;

        public int Sure
        {
            get
            {
                return _sure;
            }
            set
            {
                _sure = value;
                Notify();
            }
        }
        private int _gol;

        public int Gol
        {
            get
            {
                return _gol;
            }
            set
            {
                _gol = value;
                Notify();
            }
        }
        private int _asist;

        public int Asist
        {
            get
            {
                return _asist;
            }
            set
            {
                _asist = value;
                Notify();
            }
        }
    }
}
