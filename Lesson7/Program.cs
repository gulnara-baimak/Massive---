// 6.	Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество четных чисел

double GetCount( int[] array)
{
    double count = 0;
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}
int[] arr = {113, 324, 457, 222, 997, 444, 100, 543};
double result  = GetCount(arr);
Console.WriteLine($"Количество четных чисел {result}");
