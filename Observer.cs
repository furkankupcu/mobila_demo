using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilya
{
    class Bilgilendirme
    {
        abstract public class Observer
        {
            public abstract void Update();
        }

        abstract public class KullanıcıObserver : Observer
        {

        }

        public class  AdetSayısı
        {
            public double Adet = 0;

            bool AdetBittiMi;

            public bool adetBittiMi
            {
                get { return AdetBittiMi; }
                set
                {
                    if (value = true)
                    {
                        Notify();
                        AdetBittiMi = value;
                    }
                    else
                        AdetBittiMi = value;
                }

            }

            private void Notify()
            {
                throw new NotImplementedException();
            }

            List<Observer> Gozlemciler;

            public void Taraftar()
            {
                this.Gozlemciler = new List<Observer>();

            }

            public void AboneEkle(Observer observer)
            {
                Gozlemciler.Add(observer);
            }

            public void AboneCikar(Observer observer)
            {
                Gozlemciler.Remove(observer);


                void Notify()
                {
                    Gozlemciler.ForEach(g =>
                    {
                        g.Update();



                    });



                }
            }
        }
    }
}
