using System;


class Program
{
    public static void Main()
    {
      
        List <string> ogrenciliste = new List <string>();
        
        int ogrencisayisi =0;
        Console.WriteLine("Geziye katılacak birini ekleyecekseniz 1 eklemeyecekseniz 2 yazınız.");

        while (true)
        {
           int karar = 0;
           karar = Convert.ToInt32(Console.ReadLine());
           if (karar ==1)
           {
            Console.WriteLine("Geziye katılacak kişinin ismini giriniz");
            ogrenciliste.Add(Console.ReadLine());
            ogrencisayisi++;
            Console.WriteLine("Devam için 1 devam edilmeyecekse 2");
           }
           else if(karar ==2)
           {
            Console.WriteLine("Ekleme işlemi bitti. Toplam eklenen kişi sayısı="+ ogrencisayisi);
            break;
           }
           else
           {
            Console.WriteLine("Geçersiz bir değer girdiniz lütfen tekrar deneyin");
           }
        }

        Console.WriteLine("Araç kapasite ne kadar?");
        int kapasite = Convert.ToInt32(Console.ReadLine());
        if (ogrencisayisi>kapasite)
        {
            Console.WriteLine("Tek araç yeteresiz");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Tek araç yeterli");
            Console.ReadLine();
        }

    }
}