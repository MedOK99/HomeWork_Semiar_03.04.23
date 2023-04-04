/* Задача 27: Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число ");

int number = EnterTheNumber();

int sum = SumOfNumbers();

Console.WriteLine($"Сумма цифр составляющих число {number} равна {sum}");

int EnterTheNumber()
{
  int input = int.Parse(Console.ReadLine());
  return input;
}

int SumOfNumbers()
{
  int total = 0;
  int i = number;
  while (i > 0)
  {
    total = total + i % 10;
    i = i / 10;
  }
  return total;
}


/* 1. Зачем нам заводить функцию на перевод строчного значения в 
int (это как проходили на семинаре), если в итоге мы имеем больше 
строк кода, чем без неё (int number = int.Parse(Console.Readline()) ? 

2. Почему если я в функции SumOfNumbers не задействую переменную
i, а напрямую пишу number, то при выводе результата программа
указывает значение переменной number равное нулю?
Я думал что то, что происходит внутри функции остаётся в ней, а 
мы получаем только результат.  */


