/*  Задача 29: Напишите программу, которая приниматет 
на вход длину массива, минимальное значение массива и 
максимальное значение массива, создаёт массив с заданными 
параметрами и выводит значения на экран
5, 1, 19 -> [1, 2, 5, 7, 19]

Т.е:
Введите длину массива: 4
Введите минимальное допустимое значение элемента массива: 1
Введите максимальное допустимое значение элемента массива: 33

3, 1, 33 -> [6, 1, 33]
*/
Console.Clear();
Console.WriteLine("Введите длину массива данных:");
int lenght = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное допустимое значение массива:");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное допустимое значение массива:");
int max = int.Parse(Console.ReadLine());
void NewArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(min, max+1);
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count - 1)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
    Console.Write($"{col[position]}");
}

int[] array = new int[lenght];
NewArray(array);
PrintArray(array);


/* В итоге я выполнил задание, но не понял как создаются функции,
точнее не уловил синтаксис. Задание я сделал по аналогии с тем,
которое делали на занятии. Пересмотрю ещё раз все материалы по 
функциям, надеюсь всё пойму)   */


