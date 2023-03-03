using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.ConstrainedExecution;

namespace Assigment_Tasks_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        #region Task1
        //l1:
        //    Console.WriteLine("4 Reqemli Ededinizi Daxil Edin:");
        //    string eded1 = Console.ReadLine();
        //    if(!int.TryParse(eded1, out int eded11))
        //    { 
        //        goto l1;
        //    }

        //        int sum = 0;

        //    while(eded11>0)
        //    {
        //        int qaliq= eded11 % 10;
        //        eded11 = eded11 / 10;
        //        sum = sum + qaliq;

        //    }

        //        Console.WriteLine(sum);
        #endregion
        #region Task2

        //Console.WriteLine("6 Reqemli Ededinizi Daxil Edin:");
        //int num = int.Parse(Console.ReadLine()); 
        //int firstThreeDigits = num / 1000; 
        //int sum = 0;

        //for (int i = 0; i < 3; i++)
        //{
        //    sum = sum+ firstThreeDigits % 10; 
        //    firstThreeDigits /= 10; 
        //}

        //Console.WriteLine("Ilk 3 reqemin cemi : " + sum);
        #endregion
        #region Task3
        //Console.WriteLine("9 Reqemli Ededinizi Daxil Edin:");
        //int eded = int.Parse(Console.ReadLine());
        //int threedigits = eded / 1000;
        //int threedigits1 = threedigits % 1000;
        //int sum = 0;
        //for(int i=0; i<3;i++)
        //{
        //    sum = sum + threedigits1 % 10;
        //    threedigits1 = threedigits1 / 10;
        //}
        //Console.WriteLine($"9Reqemli Ededin Duz Ortaya Dusen 3 Reqemlerin Cemi: {sum}");
        #endregion
        #region Task4
        //Console.WriteLine("5 Reqemli Ededinizi Daxil Edin:");
        //int eded1 = int.Parse(Console.ReadLine());
        //int lastdigit = eded1 % 10;
        //int firstdigit = eded1 / 10000;
        //int sum= (lastdigit*lastdigit+ firstdigit*firstdigit);
        //Console.WriteLine($"Netice: {sum}");
        #endregion
        #region Task5
        //Console.WriteLine("6 Reqemli Ededinizi Daxil Edin:");
        //int eded= int.Parse(Console.ReadLine());
        //int firstdigit = eded / 100000;
        //int lastdigits = eded % 100000;
        //int newnum = lastdigits * 10 + firstdigit;
        //Console.WriteLine($"Netice:{newnum}");
        #endregion
        #region Task6
        //Console.WriteLine("8 Reqemli Ededinizi Daxil Edin:");
        //int eded=int.Parse(Console.ReadLine());
        //int firstdigit = eded % 10000000;
        //int lastdigit = eded % 10;
        //int newnum = (firstdigit - lastdigit) / 10;
        //Console.WriteLine($"Netice: {newnum}");
        #endregion
        #region Task7
        //l1:
        //    Console.WriteLine("4 Reqemli Ededinizi Daxil Edin:");
        //    int eded = int.Parse(Console.ReadLine());
        //    int sum = 0;
        //    if((eded>9999 || eded <1000))
        //    {
        //        Console.WriteLine("Edediniz Duzgun Deyildir!");
        //        goto l1;
        //    }

        //    for(int i=0; i<4; i++)
        //    { 
        //        int qaliq = eded % 10;
        //        eded= eded / 10;
        //        sum = sum * 10 + qaliq;
        //    }
        //    Console.WriteLine($"1.Hissenin Neticesi: {sum}");

        //    int newnum = sum + 80000;
        //    int newnum2 = newnum * 10 + 8;
        //    Console.WriteLine($"2.Hissenin Neticesi: {newnum2}");
        #endregion
        #region Task8
        //Console.WriteLine("Ededinizi Daxil Edin:");
        //int eded = int.Parse(Console.ReadLine());
        //int eded1 = (eded % 1000)/100;
        //int eded2 = eded % 10;
        //int newnum = eded1 + eded2;
        //Console.WriteLine($"Son Neticeniz:{newnum}");
        #endregion
        #region Task9
        // int qaliq, 
        // newnum=0;
        //l1:
        // Console.WriteLine("9 Reqemli Ededinizi Daxil Edin:");
        // int eded1;
        // if (!int.TryParse(Console.ReadLine(), out eded1))
        // {
        //     Console.WriteLine("Edediniz Duzgun Daxil Edilmeyib!");
        //     goto l1;
        // }
        // while(eded1>0)
        // {
        //     qaliq = eded1 % 10;
        //     eded1 = eded1 / 10;
        //     newnum = newnum * 10 + qaliq;
        // }
        // Console.WriteLine(newnum);
        // int counter = 0;
        // eded1 = newnum;
        // newnum = 0;

        // while (eded1 > 0)
        // {
        //     qaliq = eded1 % 10;
        //     eded1 = eded1 / 10;


        //     if (counter % 2 == 1)
        //     {
        //         counter++;
        //         continue;
        //     }
        //     counter++;
        //     newnum = newnum * 10 + qaliq;

        // }
        // Console.WriteLine(newnum);
        #endregion
        #region Task10

        //    int qaliq,
        //   newnum = 0;
        //l1:
        //    Console.WriteLine("9 Reqemli Ededinizi Daxil Edin:");
        //    int eded1;
        //    if (!int.TryParse(Console.ReadLine(), out eded1))
        //    {
        //        Console.WriteLine("Edediniz Duzgun Daxil Edilmeyib!");
        //        goto l1;
        //    }
        //    while (eded1 > 0)
        //    {
        //        qaliq = eded1 % 10;
        //        eded1 = eded1 / 10;
        //        newnum = newnum * 10 + qaliq;
        //    }
        //    Console.WriteLine(newnum);
        //    int counter = 0;
        //    eded1 = newnum;
        //    newnum = 0;

        //    while (eded1 > 0)
        //    {
        //        qaliq = eded1 % 10;
        //        eded1 = eded1 / 10;


        //        if (counter % 2 == 1)
        //        {
        //            counter++;
        //            continue;
        //        }
        //        counter++;
        //        newnum = newnum * 10 + qaliq;

        //    }
        //    Console.WriteLine(newnum);
        //    int qaliq2,
        //   newnum2 = 0;

        //l2:
        //    Console.WriteLine("9 Reqemli Ededinizi Daxil Edin:");
        //    int eded2;
        //    if (!int.TryParse(Console.ReadLine(), out eded2))
        //    {
        //        Console.WriteLine("Edediniz Duzgun Daxil Edilmeyib!");
        //        goto l2;
        //    }
        //    while (eded2 > 0)
        //    {
        //        qaliq2 = eded2 % 10;
        //        eded2 = eded2 / 10;
        //        newnum2 = newnum2 * 10 + qaliq2;
        //    }
        //    Console.WriteLine(newnum2);
        //    int counter2 = 0;
        //    eded2 = newnum2;
        //    newnum2 = 0;

        //    while (eded2 > 0)
        //    {
        //        qaliq2 = eded2 % 10;
        //        eded2 = eded2 / 10;


        //        if (counter2 % 2 == 0)
        //        {
        //            counter2++;
        //            continue;
        //        }
        //        counter2++;
        //        newnum2 = newnum2 * 10 + qaliq2;

        //    }
        //    Console.WriteLine(newnum2);
        //    Console.WriteLine($"En Son Netice: {newnum}+{newnum2}={newnum+newnum2}");
        #endregion
        #region Task11
        //int qaliq;
        //Console.WriteLine("8 Reqemli Ededinizi Daxil Edin: ");
        //int eded=int.Parse(Console.ReadLine());
        //int sum = 0;
        //while(eded>0)
        //{
        //    qaliq = eded % 100;
        //    eded = eded / 100;

        //    sum = sum + qaliq;
        //    Console.WriteLine($" 1.Sert:Iki-Iki Qruplasma: {qaliq}");
        //}
        //    Console.WriteLine($"2. Sert: Qruplarin cemi: {sum}");
        //int sum1 = (sum * 100) + 99;
        //Console.WriteLine($"3.Sert:Alinan Cavabin axirina 99 artir:{sum1}");
        //int netice = sum1 - (sum1 * 18 / 100);
        //Console.WriteLine($"4.Sert:Cavabin Ozunden Onun 18%-i Cix:{netice}");
        #endregion
        #region Task12
        //l1:
        //    Console.WriteLine("1. 5 Reqemli Ededinizi Daxil Edin: ");
        //    int eded1;
        //   ;

        //    if (!int.TryParse(Console.ReadLine(), out eded1))
        //    {
        //        Console.WriteLine("Edediniz 5 Reqemli Deyil!");
        //        goto l1;
        //    }
        //    int a = eded1;
        //l2:
        //    Console.WriteLine("2. 5 Reqemli Ededinizi Daxil Edin: ");
        //    int eded2;

        //    if (!int.TryParse(Console.ReadLine(), out eded2))
        //    {
        //        Console.WriteLine("Edediniz 5 Reqemli Deyil!");
        //        goto l2;
        //    }
        //    int qaliq;
        //    int sum = 0;

        //    while (eded1 > 0)
        //    //12345
        //    {
        //        qaliq = eded1 % 10;
        //        eded1 = eded1 / 10;
        //        sum = sum + qaliq;
        //    }
        //    Console.WriteLine($"1. Ededin Reqemleri Cemi: {sum}");
        //    int qaliq2;
        //    int sum2 = 1;
        //    while (eded2 > 0)
        //    {
        //        qaliq2 = eded2 % 10;
        //        eded2 = eded2 / 10;
        //        sum2 = sum2 * qaliq2;
        //    }

        //    int sum3 = sum + sum2;
        //    int lastdigitofeded = a % 10;
        //    int sonnetice = sum3 * 10 + lastdigitofeded;
        //    Console.WriteLine($"2. Ededin Reqemleri Hasili {sum2}");
        //    Console.WriteLine($"1.Sert: 1. Ededin Reqemlerinin Ceminin uzerine 2. Ededin Reqemleri Hasili: {sum3}");
        //    Console.WriteLine($"2.Sert:Neticenin Axirina I ededin en axirinci reqemini artir {sonnetice}");
        //    Console.WriteLine(lastdigitofeded);

        #endregion
        #region Task13
        //l1:
        //    Console.WriteLine("1. 5 Reqemli Ededinizi Daxil Edin: ");
        //    int eded1;
        //    if (!int.TryParse(Console.ReadLine(), out eded1))
        //    {
        //        Console.WriteLine("Edediniz Duzgun Daxil Edilmemisdir!");
        //        goto l1;
        //    }
        //    if(eded1<10000 || eded1>99999)
        //    {
        //        Console.WriteLine("Edediniz 5 Reqemli Deyil!");
        //        goto l1;
        //    }
        //    Console.WriteLine("2. 5 Reqemli Ededinizi Daxil Edin! ");
        //    int eded2;
        //l2:
        //    if (!int.TryParse(Console.ReadLine(), out eded2))
        //    {
        //        Console.WriteLine("Edediniz Duzgun Daxil Edilmemisdir!");
        //        goto l2;
        //    }
        //    if (eded2 < 10000 || eded2 > 99999)
        //    {
        //        Console.WriteLine("Edediniz 5 Reqemli Deyil!");
        //        goto l2;
        //    }
        //    int eded3;
        //     l3:   
        //    Console.WriteLine("3. 5 Reqemli Ededinizi Daxil Edin: ");
        //    if(!int.TryParse(Console.ReadLine(), out eded3))
        //    {
        //        Console.WriteLine("Edediniz Duzgun Daxil Edilmemisdir!");
        //        goto l3;
        //    }
        //    if (eded3 < 10000 || eded3 > 99999)
        //    {
        //        Console.WriteLine("Edediniz 5 Reqemli Deyil!");
        //        goto l3;
        //    }
        //    int lastdigit1 = eded1 % 10;
        //    int firstdigit1 = eded1 / 10000;
        //    int newnum1 = firstdigit1 * 10 + lastdigit1;
        //    Console.WriteLine($"1.Eded:{newnum1}");
        //    int lastdigit2 = eded2 % 10;
        //    int firstdigit2 = eded2 / 10000;
        //    int newnum2= firstdigit2 * 10 + lastdigit2;
        //    Console.WriteLine($"2.Eded:{newnum2}");
        //    int lastdigit3 = eded3 % 10;
        //    int firstdigit3 = eded3 / 10000;
        //    int newnum3= firstdigit3*10+ lastdigit3;
        //    Console.WriteLine($"3.Eded:{newnum3}");
        //    double result = newnum1 + newnum2 + newnum3;
        //    Console.WriteLine($"Alinan Neticeleri Topla: {result}");
        //    double result1 = result + result / 2;
        //    Console.WriteLine($"Son Neticenin 50%-i Neticenin Uzerine Gel: {result1}");
        #endregion
        #region Task14
        //l1:
        //    Console.WriteLine("1. 6 Reqemli Ededinizi Daxil Edin:");
        //    int eded1 = int.Parse(Console.ReadLine());
        //    //123456
        //    if(eded1< 100000 || eded1>= 999999)
        //    {
        //        Console.WriteLine("Edediniz 6 Reqemli Deyil!");
        //        goto l1;
        //    }
        //l2:
        //    Console.WriteLine("2. 6 Reqemli Ededinizi Daxil Edin:");
        //    int eded2 = int.Parse(Console.ReadLine());
        //    //123456
        //    if (eded2 < 100000 || eded2 >= 999999)
        //    {
        //        Console.WriteLine("Edediniz 6 Reqemli Deyil!");
        //        goto l2;
        //    }
        //l3:
        //    Console.WriteLine("3. 6 Reqemli Ededinizi Daxil Edin:");
        //    int eded3 = int.Parse(Console.ReadLine());
        //    //123456
        //    if (eded3 < 100000 || eded3 >= 999999)
        //    {
        //        Console.WriteLine("Edediniz 6 Reqemli Deyil!");
        //        goto l3;
        //    }
        //l4:
        //    Console.WriteLine("1. 7 Reqemli Ededinizi Daxil Edin:");
        //    int eded4 = int.Parse(Console.ReadLine());
        //    //123456
        //    if (eded4 < 1000000 || eded1 >= 9999999)
        //    {
        //        Console.WriteLine("Edediniz 7 Reqemli Deyil!");
        //        goto l4;
        //    }
        //    //1234567
        //    //4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
        //    //6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
        //    //Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
        //    //Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
        //    //Neticenin 60 % tap.Cavabin axirina 60 artir.
        //    //Neticeden 18 % cix.

        //    int eded11 = eded1 / 1000;
        //    int eded22=eded2 / 1000;
        //    int eded33=eded3 / 1000;
        //    int eded44 = eded4 / 10000;
        //    int sum = eded11 + eded22 + eded33;
        //    Console.WriteLine($"6 Reqemli Ededlerin Ilk 3 Reqeminden Alinan Ededlerin Cemi: {sum}");
        //    int eded444 = eded4 % 10000;
        //    int sum1 = sum + eded444;
        //    Console.WriteLine($"Neticenin Uzerine 7 Reqemli Edin Son 4 Reqeminden Alinan Ededi Gel! {sum1}");
        //    int qaliq;
        //    int eded4444 = eded4 / 10000;
        //    int sum11 = 1;



        //    //1234567
        //        while (eded4444>0)
        //    {
        //        qaliq = eded4444 % 10;
        //        eded4444 = eded4444 / 10;
        //        sum11 = sum11 * qaliq;

        //    }

        //    int sert1 = sum1 - sum11;
        //    Console.WriteLine($"Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi {sert1}");
        //    double sert2 = sert1 * 0.6;
        //    double sert3 = (sert2 * 100) + 60;
        //    Console.WriteLine($"Neticenin 60% tap. Cavabin Axirina 60 Artir! {sert3}");
        //    double netice = sert3 - (sert3 * 0.18);
        //    Console.WriteLine($"Neticeden 18%-i Cix:{netice}");
        #endregion
        #region Task15
        //l1:

        //    Console.WriteLine("1.3 Reqemli Ededinizi Daxil Edin: ");
        //    int eded1 = int.Parse(Console.ReadLine());
        //    if(eded1<100 || eded1>999)
        //    {
        //        Console.WriteLine("Ededini 3 Reqemli Deyil!");
        //        goto l1;
        //    }
        //l2:
        //    Console.WriteLine("2.3 Reqemli Ededinizi Daxil Edin: ");
        //    int eded2 = int.Parse(Console.ReadLine());
        //    if (eded2 < 100 || eded2 > 999)
        //    {
        //        Console.WriteLine("Ededini 3 Reqemli Deyil!");
        //        goto l2;
        //    }
        //l3:
        //    Console.WriteLine("1.6 Reqemli Ededinizi Daxil Edin: ");
        //    int eded3 = int.Parse(Console.ReadLine());
        //    if (eded3 < 100000 || eded3 > 999999)
        //    {
        //        Console.WriteLine("Ededini 6 Reqemli Deyil!");
        //        goto l3;
        //    }
        //l4:
        //    Console.WriteLine("2.6 Reqemli Ededinizi Daxil Edin: ");
        //    int eded4 = int.Parse(Console.ReadLine());
        //    if (eded4 < 100000 || eded3 > 999999)
        //    {
        //        Console.WriteLine("Ededini 6 Reqemli Deyil!");
        //        goto l4;
        //    }
        //l5:
        //    Console.WriteLine("1.7 Reqemli Ededinizi Daxil Edin: ");
        //    int eded5 = int.Parse(Console.ReadLine());
        //           int cem3reqemli = eded1 + eded2;
        //    if (eded5 < 1000000 || eded5 > 9999999)
        //    {
        //        Console.WriteLine("Edediniz 7 Reqemli Deyil!");
        //        goto l5;
        //    }
        //    Console.WriteLine($"3 Reqemli Ededlerin Cemi: {cem3reqemli}");
            
        //    int sum = 1;

        //    int reqemlerinyapisdirilmasi = eded1 * 1000 + eded2;
        //    int ikincipart = cem3reqemli + reqemlerinyapisdirilmasi;
        //    Console.WriteLine($"Cavabin Ustune 3 Reqemli Ededlerin Bir-Birine Yapisdirilmasindan Sonra Alinan Ededi Gel! {ikincipart}");
        //    int cixma = ikincipart - eded5 % 100000;
        //    Console.WriteLine($"Cavabdan 7 Reqemli Ededin Son 5 Reqemini Cix! {cixma}");
        //    int reqemcemi6li = eded3 + eded4;
        //    int axirinci3eded = reqemcemi6li % 1000;
        //    int ucuncupart = cixma + axirinci3eded;
        //    Console.WriteLine($"Alinan Neticenin Uzerine 6 Reqemlilerin Ceminden Alinan Cavabin Axirinci 3 Dene Ededini Gel! {ucuncupart}");
        //    int elavetme = ucuncupart * 100 + 11;
        //    Console.WriteLine($"Cavabin Axirina 11 Artir! {elavetme}");
        //    int newnum = 0;
        //    while(eded5>0)
        //    {
        //        int qaliq1 = eded5 % 10;
        //        eded5= eded5 / 10;
        //        newnum = newnum * 10 + qaliq1;
        //    }
        //    eded5 = newnum;
        //    newnum = 0;
        //    int counter = 0;
        //    while (eded5 > 0)
        //    {
        //        int qaliq1 = eded5 % 10;
        //        eded5 = eded5 / 10;
        //        if (counter % 2 == 1)
        //        {
        //            counter++;
        //            continue;
        //        }
        //        counter++;
        //        newnum = newnum * 10 + qaliq1;
        //    }
        //    int cixma1 = elavetme - newnum;
        //    Console.WriteLine($"7 Reqemli Ededin Tek Yerde Dayanan Reqemlerinden Alinan Ededi Cix! {cixma1}");
        //    int qaliq111 = cixma1 % 10;
        //    int eded111=cixma1 / 10;
        //    int elavetme11 = eded111 * 100 + 88;
        //    int elavetme111 = elavetme11 * 10 + qaliq111;
        //    Console.WriteLine($"Cavabin Axirdan II Reqemi Ile Axirinci Reqemin Arasina 88 Elave Et! {elavetme111}");

            #endregion










        }
    }
}