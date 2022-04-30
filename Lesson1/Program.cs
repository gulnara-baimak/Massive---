// 1. Задать массив из 8 элементов и вывести их на экран

int[] Massive = new int[8];
void FullArray(int[] Maks)
{
    int index = 0;
    int length = Maks.Length;

    while (index < length)
    {
        Maks[index] = new Random().Next(0, 10);
        index ++;
    }
}
void PrintArray(int[] Maks)
{
    int count = 0;
    int lenght = Maks.Length;

    while (count < lenght)
    {
        Console.WriteLine($"Элементы массива {Maks[count]}");
        count++;
    }

}
FullArray (Massive);
PrintArray (Massive);

