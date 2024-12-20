Console.WriteLine("hesap makinesine hoşgeldiniz...");

/*
1- kullanıcıdan birinci sayıyı isteme 
2- kullanıcıdan ikinci sayıyı isteme
3- işlemi iste
4- sonucu göster
    a.hangi işlem onu kontrol et --> ilk yöntem: if else ikinci yöntem: switch case
    b.o işleme göre sayıları işle





*/


static void ifelseHesap()
{


    Console.WriteLine("Birinci sayıyı giriniz");

    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("İkinci sayıyı giriniz");

    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Yapmak istediğiniz işlem tipini giriniz (+,-,*,/)");

    char islem = Convert.ToChar(Console.ReadLine());

    double sonuc = 0;

    if (islem == '+')
    {
        sonuc = num1 + num2;
    }
    else if (islem == '-')
    {
        sonuc = num1 - num2;
    }
    else if (islem == '*')
    {
        sonuc = num1 * num2;
    }
    else if (islem == '/')
    {
        if (num2 == 0)
        {
            sonuc = 0;
        }
        else
        {
            sonuc = num1 / num2;
        }
    }
    else
    {
        Console.WriteLine("hatalı işlem girdiniz");
    }


    Console.WriteLine(sonuc);
}


static void switchcaseHesap()
{

    Console.WriteLine("Birinci sayıyı giriniz");

    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("İkinci sayıyı giriniz");

    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Yapmak istediğiniz işlem tipini giriniz (+,-,*,/)");

    char islem = Convert.ToChar(Console.ReadLine());

    double sonuc = 0;

    switch (islem)
    {
        case '+':
            sonuc = num1 + num2;
            break;
        case '-':
            sonuc = num1 - num2;
            break;
        case '*':
            sonuc = num1 * num2;
            break;
        case '/':
            if (num2 != 0)
            {
                sonuc = num1 / num2;
            }
            else
            {
                Console.WriteLine("ikinci sayı 0 oolamaz");
            }
            break;
        default:
            Console.WriteLine("geçersiz işlem");
            break;
    }

    Console.WriteLine("sonuc : " + sonuc);
}
switchcaseHesap();