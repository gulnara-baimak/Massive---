// 5.	Определить, присутствует ли в заданном массиве, некоторое число. 
// Зададим число 5.

int[] array = new int[10]; // создаю массив из 10 элементов 
int count = 0; // счетчик

for (int i = 0; i < array.Length; i++) // тело цикла начинается
{
    array[i] = new Random().Next(0, 20); // выдаются случайные 10 элементов
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine(value: "Введите число:  ");

int number = int.Parse(Console.ReadLine()); // создаю целочисленную переменную, в которую заношу число с консоли

for (int j = 0; j < array.Length; j++) // тело цикла
{
    if (array[j] == number) count = 1; // если элемент массива равен введенному номеру
}
    if (count > 0) 
    {
    Console.WriteLine("Заданное число присутствует в массиве");
    }
        else 
        {
            Console.WriteLine("Заданное число в массиве отсутствует");
        }