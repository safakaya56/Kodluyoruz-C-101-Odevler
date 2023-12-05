using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Atama ve İşlemli Atama Operatörleri(=, +=, -=, *=, /=)
        Mantıksal Operatörler(||, &&, !)
        İlişkisel Operatörler(==,!=, <, >, >=,<=)
        Aritmetik(+, -, *, /, %, ++, --)*/



        int sonuc = 0, sonuc2 = 1, sonuc3 = 610;
        
        sonuc=sonuc2;
        
        for (int i = 0;i<10;i++) 
        {

            sonuc += i;
            sonuc2 *= i;
            sonuc3 -= i;
            
        }

        
        int a = 5, b = 4, c = 8;

        if(a + b == 4 || a + b == 5)
        {
            sonuc += a + b;
        }
        
        else if (a + b > 4 && a+ b <=18) 
        {
            sonuc += a + b;
        }
        
        else if (a + b < 4 && a + b >= 2) 
        {
            sonuc += a + b;
        }
        
        else if (a + b != 4)
        {
            sonuc += a + b;
        }

        int sayi = 5;
        
        Console.WriteLine(sayi++);//sayiyi önce bastı sonra ram'deki bolgede arttirdi sayi=6 artik.
        
        Console.WriteLine(++sayi);// sayiyi önce arttirdi sayi=7 artik sonra basti

        int mod = 11;
        int modSonuc = mod % 5;
        Console.WriteLine(modSonuc);

    }
}