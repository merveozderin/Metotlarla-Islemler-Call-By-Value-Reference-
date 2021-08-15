using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // erisim_belirteci geri_dönüs_tipi metod_adi (parametrelistresi/arguman)
            // {
            //     komutlar ;
            // }

            int a = 2 ; 
            int b = 3 ;
            Console.WriteLine(a+b) ;

            int sonuc = Topla(a,b) ;
            Console.WriteLine(sonuc) ;

            Metotlar ornek = new Metotlar() ;
            ornek.ekranayazdir(Convert.ToString(sonuc)) ;

            int sonuc2 = ornek.arttirvetopla(a,b) ;
            ornek.ekranayazdir(Convert.ToString(sonuc2)) ;
            ornek.ekranayazdir(Convert.ToString(a+b)) ; //main'deki değer ile yazdırır 2+3=5 (call by value)

            int sonuc3 = ornek.arttirvetoplaref(ref a,ref b) ;
            ornek.ekranayazdir(Convert.ToString(sonuc3)) ;
            ornek.ekranayazdir(Convert.ToString(a+b)) ; //referans değer ile yazdırır 3+5=8  (call by referance)


        }

        static int Topla(int deger1, int deger2)
        {

            return (deger1 + deger2);

        }
        
    }

    class Metotlar
    {
        public void ekranayazdir(string veri)
        {
            Console.WriteLine(veri) ;
        }

        public int arttirvetopla(int deger1, int deger2)
        {
            deger1 +=1 ;
            deger2 +=2 ;

            return deger1+deger2 ;
        }

        public int arttirvetoplaref(ref int deger1, ref int deger2)
        {
            deger1 +=1 ;
            deger2 +=2 ;

            return deger1+deger2 ;
        }
    }
}
