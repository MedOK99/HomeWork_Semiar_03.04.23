/* Задача 25: Напишите цикл, который принимает на вход два 
числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());

int result = degreeA(A, B);

if (A > 0 && B > 0)
{
  Console.WriteLine($" Число {A} в степени {B} равно {result}");
}

if (A <=0)
{
  Console.WriteLine("Введите корректное число A");
}

if (B <=0)
{
  Console.WriteLine("Введите корректное число B");
}

int degreeA(int A, int B)
{
  int number = 1;
  for (int i = 0; i < B; i++)
  {
    number = number * A; // также можно number *= A, но мне бы так сначала привыкнуть)
  }
  return number;
}

/* Я не знаю как в функцию завести и вывести из неё
две переменные, которые вводит пользователь. На семинаре
разобрали ввод только одной переменной. Думаю то это
как-то просто, но как пока не пойму)
*/





