using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilya
{
    public abstract class MobilyaFabrika
    {
        protected Mobilya mobilya2;

        public virtual void MobilyaYap(string tip)
        {
            Mobilya m = this.Mobilyasipariş(tip);
            m.kes();
            m.şekillendir();
          
         }

        public abstract Mobilya Mobilyasipariş(string tip);

    }

    public class KayseriFabrika : MobilyaFabrika
    {
        public override Mobilya Mobilyasipariş(string tip)
        {
            if (tip == "çam")
                mobilya2 = new çammobilya();
            return mobilya2;
        }
    }

    public class KocaeliFabrika : MobilyaFabrika
    {
        public override Mobilya Mobilyasipariş(string tip)
        {
            if (tip == "kestane")
                mobilya2 = new kestanemobilya();
            return mobilya2;
        }
    }
    //singleton

    public class İnegölFabrika : MobilyaFabrika
    {
        public class ÖzelÜretim
        {
            static ÖzelÜretim mobilya2;

            public static ÖzelÜretim Instance
            {
                get { return ÖzelÜretim.mobilya2; }

            }
            
            static ÖzelÜretim()
            {
                mobilya2 = new ÖzelÜretim();

            }
        }

        public override Mobilya Mobilyasipariş(string tip)
        {
            return mobilya2;
        }
    }


























}
