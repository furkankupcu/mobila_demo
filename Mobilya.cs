using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilya
{
    //decorator

    public abstract class Mobilya
    {
        public double adet = 300;
        protected string isim = "isimsiz";
        protected double fiyat = 0;
        public virtual void kes() { }
        public virtual void şekillendir() { }
        
      

        public virtual string getİsim()
        {
            return isim;
        }

        public virtual double getFİyat()
        {
            return fiyat;
        }

    }

    public class Masa : Mobilya
    {
        public Masa()
        {
            isim = "Masa";
            fiyat = 3000;
            
        }
        public override double getFİyat()
        {
            return fiyat;
        }
        public override string getİsim()
        {
            return isim;
        }

    }
    public class Dolap : Mobilya
    {
        public Dolap()
        {
            isim = "Dolap";
            fiyat = 2000;
           
        }
        public override string getİsim()
        {
            return isim;
        }
        public override double getFİyat()
        {
            return fiyat;
        }

       
    }

    public class Sandalye : Mobilya
    {
        public Sandalye()
        {
            isim = "Sandalye";
            fiyat = 500;
           
        }
        public override string getİsim()
        {
            return isim;
        }
        public override double getFİyat()
        {
            return fiyat;
        }

       
    }

    public abstract class İlave : Mobilya
    {
        protected double İlaveFiyat = 0;
    }

    public class MDF : İlave
    {
        Mobilya mobilya;
        public MDF(Mobilya yenimobilya)
        {
            mobilya = yenimobilya;
            İlaveFiyat = 500;
        }

        public override double getFİyat()
        {
            return this.mobilya.getFİyat() + 300; ;
        }
        public override string getİsim()
        {
            return this.mobilya.getİsim() + "+MDF Kaplama";
        }

    }

    public class Garanti : İlave
    {
        Mobilya mobilya1;
        public Garanti(Mobilya yenimobilya1)
        {
            mobilya1 = yenimobilya1;
            İlaveFiyat = 300;
        }

        public override double getFİyat()
        {
            return this.mobilya1.getFİyat() + 300; ;
        }
        public override string getİsim()
        {
            return this.mobilya1.getİsim() + "+Garanti";
        }
    }

    public class Teslimat : İlave
    {
        Mobilya mobilya2;
        public Teslimat(Mobilya yenimobilya2)
        {
            mobilya2 = yenimobilya2;
            İlaveFiyat = 200;
        }
        public override double getFİyat()
        {
            return this.mobilya2.getFİyat() + 500; ;
        }
        public override string getİsim()
        {
            return this.mobilya2.getİsim() + "+Teslimat";
        }
    }

    //factory

    public class kestanemobilya:Mobilya
    {
        public override void kes()
        {
            
        }

    }

    public class  çammobilya: Mobilya
    {

        public override void kes()
        {
            
        }
    }

    public class meşemobilya:Mobilya
    {
        public override void kes()
        {
            
        }

    }

}
