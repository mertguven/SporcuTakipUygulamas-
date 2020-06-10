using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDPApplication
{
    class Voleybolcu
    {
        public string Name { get; set; }
        private List<IAntrenor> _antrenors;

        public Voleybolcu()
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
                antrenor.VUpdate(this);
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
        private int _pas;

        public int Pas
        {
            get
            {
                return _pas;
            }
            set
            {
                _pas = value;
                Notify();
            }
        }
        private int _smac;

        public int Smac
        {
            get
            {
                return _smac;
            }
            set
            {
                _smac = value;
                Notify();
            }
        }
    }
}
