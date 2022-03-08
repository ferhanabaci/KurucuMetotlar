using System;

namespace kurucuMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
 //*****Kurucu methodlar****
            //krucu methodlar sınıf ısmıyle aynı olur 
            //mutluka publis olmalı 
            // geri donus degeri almaz
            // geri donusunun yazmıyporuz 
            //parametre alabilir almayadabilir.


            Console.WriteLine("****Calışan 1******");
            Calisan calısan1= new Calisan("Ayse","Kara",313241856,"İnsan Kaynakları");
            calısan1.calısanBilgileri();

            Console.WriteLine("****Calısan 2****");
            Calisan calisan2= new Calisan();
            calisan2.ad="ferhan";
            calisan2.soyAd="abacı";
            calisan2.no=4123156;
            calisan2.departman="Satın Alma";

            calisan2.calısanBilgileri();
            Console.WriteLine("****calısan 3****");
            Calisan calısan3= new Calisan("Fatma","Kara");
            calısan1.calısanBilgileri();
        }
    }
    class Calisan
   {
        // burada özlelliler oluyor 
        public string ad;
        public string soyAd;
        public int no;

        public string departman;
        

        //kurucu methodu tanımlıyoruz 
        public Calisan(string ad,string soyAd, int no,string departman){
            // gövdesini yazıyoruz 

            this.ad= ad;
            this.soyAd=soyAd;
            this.no=no;
            this.departman=departman;

        }
          public Calisan(string ad,string soyAd){
            // gövdesini yazıyoruz 

            this.ad= ad;
            this.soyAd=soyAd;
         

        }
        public Calisan(){}


         public void calısanBilgileri(){
            //calısan sınıfının bilgilerini yazdıracagım birde method olsuturcam;



            Console.WriteLine("Calısan Adı:{0}",ad);
            Console.WriteLine("Calısan Soy Adı:{0}",soyAd);
            Console.WriteLine("Calısan No:{0}",no);
            Console.WriteLine("Calısan Adı:{0}",departman);

        }        }
    }
}
