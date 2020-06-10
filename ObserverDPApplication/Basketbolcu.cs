using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDPApplication
{
    class Basketbolcu
    {
        public string Name { get; set; }
        private List<IAntrenor> _antrenors;

        public Basketbolcu()
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
                antrenor.BUpdate(this);
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
        private int _sayi;

        public int Sayi
        {
            get
            {
                return _sayi;
            }
            set
            {
                _sayi = value;
                Notify();
            }
        }
        private int _ribaund;

        public int Ribaund
        {
            get
            {
                return _ribaund;
            }
            set
            {
                _ribaund = value;
                Notify();
            }
        }
    }
}
