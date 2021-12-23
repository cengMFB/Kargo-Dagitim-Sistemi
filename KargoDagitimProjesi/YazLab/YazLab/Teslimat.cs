using System;
using System.Collections.Generic;
using System.Text;

namespace YazLab
{
    class Teslimat
    {
        public string MüsteriAd { get; set; }
        public string MüsteriID { get; set; }
        public string KargoID { get; set; }
        public string Enlem { get; set; }
        public string Boylam { get; set; }

        public static implicit operator Teslimat(List<Teslimat> v)
        {
            throw new NotImplementedException();
        }
    }
}
