// 2. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] array = new int[8]; // задали массив из 8 элементов
string Massive(int[] array) // преобразовываем массив в стринг
{
    string result = string.Empty; // Представляет пустую строку. Это поле доступно только для чтения.
    for (int i = 0; i < array.Length; i ++) // тело цикла 
    {
        array[i] = new Random().Next(0, 2);
    }
    for (int i = 0; i < array.Length; i ++)
    {
        result += ($"{array[i]}  ");
    }
    return result; // возврат результата
}
Console.WriteLine(Massive(array)); // выводим на экран




