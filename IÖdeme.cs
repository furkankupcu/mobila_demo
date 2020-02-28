using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilya
{
    interface IÖdeme
    {

        void Ödeme();
        
    }

    class KrediKartı: IÖdeme
    {

        public void Ödeme()
        {

        }
    }

    class Havale: IÖdeme
    {
        public void Ödeme()
        {

        }
    }
}
