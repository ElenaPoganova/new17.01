Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n % 10;
int n2 = n / 10000;
int n3 = n / 10;
int n4 = n / 1000;
if (n1 == n2 && (n3 % 10) == (n4 % 10))
   Console.WriteLine("Это палиндром");
else
    Console.WriteLine("Это не палиндром");