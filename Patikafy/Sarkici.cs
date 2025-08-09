using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikafy
{
    public class Sarkici
    {
        public string AdSoyad { get; set; }
        public string MuzikTuru { get; set; }
        public int CikisYili { get; set; }
        public int AlbumSatis { get; set; }

        public override string ToString()
        {
            return AdSoyad;
        }
    }
}


