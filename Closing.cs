Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?"); // Soru 1

Console.WriteLine($"Metinsel veri: {Console.ReadLine()} Sayılar veri: {Convert.ToInt32(Console.ReadLine())}"); // Soru 2

Random rnd = new Random(); // Soru 3
Console.WriteLine($"Üretilen rastgele sayı: {rnd.Next(0, 100)}");

int random = rnd.Next(0, 100); // Soru 4
Console.WriteLine($"Üretilen rastgele sayı: {random} bu sayının 3'e bölümünden kalan: {random % 3}");

Console.WriteLine("Kaç yaşındasınız?"); // Soru 5
int age = Convert.ToInt32(Console.ReadLine());
if (age >= 18)
    Console.WriteLine("+");
else
    Console.WriteLine("-");

for (int i = 0; i < 10; i++) // Soru 6
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}

Console.WriteLine("2 adet ad-soyad giriniz"); // Soru 7
string name1, name2, temp;
name1 = Console.ReadLine();
name2 = Console.ReadLine();
temp = name1; name1 = name2; name2 = temp;
Console.WriteLine($"Girilen ad-soyad sıralaması: {name1} ve {name2}");

void BenDegerDondurmem() // Soru 8
{
    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");
}
BenDegerDondurmem();

int Sum(int x, int y) // Soru 9
{
    return x + y;
}
Console.WriteLine("Lütfen toplamak istediğiniz 2 sayıyı giriniz");
Console.WriteLine($"Toplama işleminin sonucu: {Sum(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()))}");
string StringToBool(bool trueFalse) // Soru 10
{
    if (trueFalse)
        return "True girildi";
    else
        return "False girildi";
}

Console.WriteLine("True ya da false değeri giriniz");
string input = Console.ReadLine();
bool confirmBool;
while (!bool.TryParse(input, out confirmBool))
{
    Console.WriteLine("True veya false değeri giriniz");
    input = Console.ReadLine();
}

string result = StringToBool(confirmBool);
Console.WriteLine($"Sonuç: {result}");

int Ages(int age1, int age2, int age3) // Soru 11
{
    return Math.Max(age1, Math.Max(age2, age3));
}

Console.WriteLine("Lütfen 3 adet yaş giriniz");
Console.WriteLine($"{Ages(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()))}");

void SelectMax() // Soru 12
{
    int number;
    int max = 0;
    while (true)
    {
        Console.WriteLine("Sayı giriniz: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number > max)
            max = number;
        Console.WriteLine($"Girilen sayıların arasında en büyük değer: {max}");
    }
}
SelectMax();

void Swap(ref string first, ref string second) // Soru 13
{
    string temp = first; first = second; second = temp;
}

string x = Console.ReadLine();
string y = Console.ReadLine();

Swap(ref x, ref y);

bool isEven(int number) // Soru 14
{
    if (number % 2 == 0)
        return true;
    else
        return false;
}

Console.WriteLine("Lütfen bir sayı giriniz");
Console.WriteLine($"{isEven(Convert.ToInt32(Console.ReadLine()))}");

double distanceTraveled(double speed, double time) // Soru 15
{
    return speed * time;
}

Console.WriteLine($"Gidilen toplam yol: {distanceTraveled(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()))}");

double circleArea(double radius) // Soru 16
{
    return 3.14 * Math.Pow(radius, 2);
}
Console.WriteLine("Dairenin yarıçapını giriniz");
Console.WriteLine($"{circleArea(Convert.ToDouble(Console.ReadLine()))}");

Console.WriteLine("Zaman bir GeRi SayIm".ToLower() + "\nZaman bir GeRi SayIm".ToUpper()); // Soru 17

string text = "    Selamlar   "; // Soru 18
text = text.Trim();
Console.WriteLine(text);
