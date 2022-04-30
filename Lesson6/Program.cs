// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.WriteLine($"Введите число: ");
int n = Convert.ToInt32(System.Console.ReadLine());
int s = 0;
while (n > 0) 
{
    s = s + n % 10;
    n = n /10 ;
}
 Console.WriteLine(s);
 Console.WriteLine($"Сумма цифр в числе: {s}" );
