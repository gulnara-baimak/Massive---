// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Число с именем A возвожу в число с именем B, а в С запишем результаты.

double A;
double B;
double C;

Console.WriteLine($"Программа возведения числа в степень");
Console.WriteLine($"Введите число, которое вы хотите возвести в степень:");
A = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите степень, в которую хотите возвести число "+A+":");
B = Convert.ToDouble(Console.ReadLine());
C = Math.Pow(A, B);
Console.WriteLine("Результат: "+A+" в степени "+B+" равно "+C+"!");
Console.ReadLine();