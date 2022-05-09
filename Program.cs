using System;

namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {   //Uyarı: Kumarhanemiz, gerçek saate göre saat 18:00-06:00 arası hizmet vermektedir.
        a3:
        int tarih  = DateTime.Now.Hour; 
        for(int t=6;t<18;t++){if(tarih==t){System.Console.WriteLine("Ne yazık ki kumarhanemiz, gerçek saate göre saat 18:00-06:00 arası hizmet vermektedir.");goto a3;}}
        System.Console.WriteLine("  ^^^^###     Kıbrıs Patika.Dev Kumarhanesi'ne Hoşgeldiniz    ###^^^^");
        Int32 para =0;
        a2:
        try{
            System.Console.WriteLine("Jeton Al (Tane:5 TL):             (1)");
            System.Console.WriteLine("Jeton At ve Kolu Çek:             (2)");
            System.Console.WriteLine("Bakiyeyi çekin:                   (3)");
            Int32 x =Int32.Parse(Console.ReadLine());

            if(x==1){a1:
            System.Console.WriteLine("Lütfen önce para yatırınız\nKaç para yatıracaksınız? (TL)");
            para =Int32.Parse(Console.ReadLine());
            if(para<10){System.Console.WriteLine("Lütfen 10 TL ya da üzerinde ücret ödeyin.");goto a1;}
            else{System.Console.WriteLine("Artık oyuna hazırsınız. Jeton Atıp kolu çekebilirsiniz. Bol Şanslar!");goto a2;}}

            else if(x==2){
                if(para==0){System.Console.WriteLine("Bakiyeniz yetersiz. Lütfen jeton satın alınız.");goto a2;}
                else{
                    para=para-5;
                    Random sans = new Random();
                    int slot1 = sans.Next(1,5);
                    int slot2 = sans.Next(1,5);
                    int slot3 = sans.Next(1,5);
                    int slot4 = sans.Next(1,5);
                    int slot5 = sans.Next(1,5);
                    int slot6 = sans.Next(1,5);
                    int slot7 = sans.Next(1,5);
                    int slot8 = sans.Next(1,5);
                    int slot9 = sans.Next(1,5);

                    System.Console.WriteLine(slot1 + " " + slot2 + " " + slot3);
                    System.Console.WriteLine(slot4 + " " + slot5 + " " + slot6);
                    System.Console.WriteLine(slot7 + " " + slot8 + " " + slot9);

                    if(slot1==slot2&&slot1==slot3){para=para+100;System.Console.WriteLine("TEBRİKLER! 100 TL Kazandınız! Toplam Bakiyeniz:"+para);goto a2;}
                    else if(slot4==slot5&&slot4==slot6){para=para+100;System.Console.WriteLine("TEBRİKLER! 100 TL Kazandınız! Toplam Bakiyeniz:"+para);goto a2;}
                    else if(slot7==slot8&&slot7==slot9){para=para+100;System.Console.WriteLine("TEBRİKLER! 100 TL Kazandınız! Toplam Bakiyeniz:"+para);goto a2;}
                    else{System.Console.WriteLine("Tekrar deneyin...");goto a2;}}}

            else if(x==3){System.Console.WriteLine(para + " TL nakitiniz hazır. İyi günler.");para=0;goto a2;}
        }
        catch{System.Console.WriteLine("Sanırım birşeyler ters gitti... Kurpiyerimiz ilgileniyor. Lütfen lobiye gidiniz.");goto a2;}
        }
    }
}
