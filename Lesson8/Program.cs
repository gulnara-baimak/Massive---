// // 6.	Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных чисел

double GetCount( int[] array)
{
    double count = 0;
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i] % 2!=0)
        {
            count++;
        }
    }
    return count;
}
double result  = GetCount(new int[] {113, 324, 457, 222, 997, 444, 100, 555, 777});
Console.WriteLine($"Количество нечетных чисел {result}");


