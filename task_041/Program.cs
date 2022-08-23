/*
    Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
    сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223-> 3
*/

//Console.Clear();

Console.Write("Введите количество вводимых чисел: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length]; 
int index = 0;
int[] numbers = ArrayInput(array, index, length);
int count = GetPositiveNumbers(array);
PrintArray(numbers, count);

int[] ArrayInput(int[] array, int index, int length)
{
   Console.Clear();
    if (index == length) return array;

    Console.Write("Введите число: ");
    array[index] = Convert.ToInt32(Console.ReadLine());  
    index++;

    return ArrayInput(array, index, length);
}

int GetPositiveNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}


void PrintArray(int[] array, int count)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("В веденных числах: ");

    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length -1)
        {
            Console.Write($"{array[i]} ");
        }
        else 
        {
            Console.Write($"{array[i]}, ");
        }
    }

    Console.WriteLine($" больше нуля -> {count}!");
    Console.ResetColor();
}