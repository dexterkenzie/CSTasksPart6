// Задача 41
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую:");
string numbers = Console.ReadLine();

string[] newNumbers = new string[numbers.Length];
int step = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
    if (numbers[i] == ',')
    {
        step++;
    }
    else
    {
        newNumbers[step] = newNumbers[step] + $"{numbers[i]}";
    }
}
step++;
int[] resultNumbers = new int[step];
PrintArray(resultNumbers, newNumbers);
int result = 0;
for (int i = 0; i < step; i++)
{
    if (resultNumbers[i] > 0)
    {
        result++;
    }
}
Console.WriteLine($"Чисел больше 0: {result}");

void PrintArray(int[] array, string[] string1)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(string1[i]);
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}