// See https://aka.ms/new-console-template for more information

using System.Collections;


int code = 1;

int[] depo = new int[26];

int f5 = 0;


//Ramden depo Doluluk Oranı Silinmesin Diye While Döngüsüne Alındı....

while (code == 1)
{


    //depo durumunu göstermesını sagladım depo ne kadar dolu onu gösterir

    int[] Kargocıktı1 = new int[24];

    for (int v = 0; v < 24; v++)
    {
        Kargocıktı1[v] = depo[v];
    }



    string[] strArray3 = Array.ConvertAll(Kargocıktı1, ele => ele.ToString());

    Console.WriteLine("Deponun Durumu : " + " " + f5 + "#" + string.Join("", strArray3));




    Console.WriteLine("vagon sayısını gir : ");
    int vagonSayısı = Convert.ToInt32(Console.ReadLine());









    int[] vagonIcerigi = new int[vagonSayısı * 25];


    for (int i = 0; i < vagonIcerigi.Length; i++)
    {
        // 1 vagonda 26 tane bölüm vardır her bölüme max 9 kargo duser kargoları vagona yerlestirme bölümü

        Console.WriteLine("Vagona Kargo bölümü" + i + " düsen paket sayısını gir : ");
        int paketsayısı = Convert.ToInt32(Console.ReadLine());



        int a = 1;

        while (a == 1)
        {

            //kargo bölümüne 0 ile 9 paket yüklemesi

            if (paketsayısı < 10 && paketsayısı > -1)
            {
                vagonIcerigi[i] = paketsayısı;

                a = 0;
            }
            else
            { 
                //kargo bölümüne 9 paketen fazla paket yüklenmesini önler

                Console.WriteLine("Vagona düsen paket sayısını 0 ile 9 arasında olmalı : ");

                paketsayısı = Convert.ToInt32(Console.ReadLine());
            }
        }


        a = 1;




    }






    // toplamada kaç vagon oldugunu hesaplar

    int toplamVagonSayısı = vagonIcerigi.Length / vagonSayısı;

    int[] cıktı = new int[25];

    int sayac = 0;

    for (int i = 1; i < vagonSayısı + 1; i++)
    {

        // bütün paketleri vagonlara böler ve her vagonda paket bölümlerinde kaç paket oldugunu gösterir.

        for (int j = 0; j < 25; j++)
        {



            cıktı[j] = vagonIcerigi[sayac];

            sayac++;
        }

        string[] strArray1 = Array.ConvertAll(cıktı, ele => ele.ToString());

        Console.WriteLine("gelenVagon" + i + " = " + " " + string.Join("", strArray1));


    }


    //kargo yükleme



    int fazlaKargo;

    int sayaç1 = 0;

  
 
    int f6 = 0;

    for (int i = 0; i < vagonIcerigi.Length; i++)
    {
        // vagon içerigi kadar for dongüsü döner

        //her sayaç 25 oldugunda sayacı 0 a çeker

        if (i % 25 == 0)
        {



            sayaç1 = 0;
        }

        // depo'nun içindeki paket sayısı ve vagondan gelen paket sayısının toplamı 9 dan buyuk mu konturol eder

        //cuku depo 9 paket alabılır

        if ((depo[sayaç1] + vagonIcerigi[i]) > 9)
        {
            //depo ya 9 paketten daha fazla pakt gelirse fazla kargoyu bir sonraki depoya iletmek için fazla kargo tespiti

            fazlaKargo = (depo[sayaç1] + vagonIcerigi[i]) - 9;

            
            // fazla kargo bir sonraki depoya akterılır

            depo[sayaç1 + 1] = fazlaKargo;



            //ilk gitigi depo 9 paketler dolar fazla kargo diyer depodadır

            depo[sayaç1] = 9;


        }
        else
        {
            // eger depo daki paket sayısı vagoniçindeki paketsayısının toplamı 9 dan küçük ise paketler depoya direk yüklenir fazla kargo olmaz


            depo[sayaç1] = depo[sayaç1] + vagonIcerigi[i];
        }


        //depo 25 indisi f5 dir sonsuz kapasiteye sahiptir fazla paketler burda depolanır

        f6 = depo[25];

        f5 = f5 + f6;


        sayaç1++;
      

    }


   // deponun doluluk durumunu pasar

    int[] Kargocıktı = new int[24];

    for (int g = 0; g < 24; g++)
    {
        Kargocıktı[g] = depo[g];
    }

    string[] strArray2 = Array.ConvertAll(Kargocıktı, ele => ele.ToString());

    Console.WriteLine("Deponun Durumu :" + f5 + "#" + string.Join("", strArray2));

    int depoyuBoşalt = 0;

    Console.WriteLine("Depoyu Boşaltmak İçin 1'e basın veya Depo Dolu Kalsın 0'a basıl ");
    depoyuBoşalt = Convert.ToInt32(Console.ReadLine());


    if (depoyuBoşalt == 1)
    {
        for (int p = 0; p < depo.Length; p++)
        {
            depo[p] = 0;
        }
      
    }


    //programdan çıkış

    Console.WriteLine("Çıkış : 0 , Devam 1 ");
    code = Convert.ToInt32(Console.ReadLine());


}







