/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Write("Введите числа через пробел: ");
string Numbers = Console.ReadLine()!;

int[] array = Array.ConvertAll(Numbers.Split(), int.Parse);


int Res (int [] arr)
{

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        count++;
}
return count;
}
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Чисел больше 0 введено: {Res(array)}");



