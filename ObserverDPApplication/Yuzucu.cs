using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDPApplication
{
    class Yuzucu
    {
        public string Name { get; set; }
        private List<IAntrenor> _antrenors;

        public Yuzucu()
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
                antrenor.YUpdate(this);
            }
        }

        private int _sırtsure;

        public int SırtSure
        {
            get
            {
                return _sırtsure;
            }
            set
            {
                _sırtsure = value;
                Notify();
            }
        }
        private int _kelebeksure;

        public int KelebekSure
        {
            get
            {
                return _kelebeksure;
            }
            set
            {
                _kelebeksure = value;
                Notify();
            }
        }
        private int _kurbagasure;

        public int KurbagaSure
        {
            get
            {
                return _kurbagasure;
            }
            set
            {
                _kurbagasure = value;
                Notify();
            }
        }
        private int _serbestsure;

        public int SerbestSure
        {
            get
            {
                return _serbestsure;
            }
            set
            {
                _serbestsure = value;
                Notify();
            }
        }

        private int _sırtmesafe;

        public int SırtMesafe
        {
            get
            {
                return _sırtmesafe;
            }
            set
            {
                _sırtmesafe = value;
                Notify();
            }
        }
        private int _kelebekmesafe;

        public int KelebekMesafe
        {
            get
            {
                return _kelebekmesafe;
            }
            set
            {
                _kelebekmesafe = value;
                Notify();
            }
        }
        private int _kurbagamesafe;

        public int KurbagaMesafe
        {
            get
            {
                return _kurbagamesafe;
            }
            set
            {
                _kurbagamesafe = value;
                Notify();
            }
        }
        private int _serbestmesafe;

        public int SerbestMesafe
        {
            get
            {
                return _serbestmesafe;
            }
            set
            {
                _serbestmesafe = value;
                Notify();
            }
        }

        private string _sırtteknik;

        public string SırtTeknik
        {
            get
            {
                return _sırtteknik;
            }
            set
            {
                _sırtteknik = value;
                Notify();
            }
        }
        private string _kelebekteknik;

        public string KelebekTeknik
        {
            get
            {
                return _kelebekteknik;
            }
            set
            {
                _kelebekteknik = value;
                Notify();
            }
        }
        private string _kurbagateknik;

        public string KurbagaTeknik
        {
            get
            {
                return _kurbagateknik;
            }
            set
            {
                _kurbagateknik = value;
                Notify();
            }
        }
        private string _serbestteknik;

        public string SerbestTeknik
        {
            get
            {
                return _serbestteknik;
            }
            set
            {
                _serbestteknik = value;
                Notify();
            }
        }
    }
}
