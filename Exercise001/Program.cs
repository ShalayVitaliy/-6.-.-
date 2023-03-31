// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Enter the numbers separated by a space: ");
int[] Array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int Counter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            count++;
    }
    return count;
}

Console.Write($"The count of positive numbers: {Counter(Array)}");

