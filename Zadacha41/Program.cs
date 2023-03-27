// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Numb(string message)
{
    Console.WriteLine(message);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

void Array(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"Ваше число: ");
        arg[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"Ваши числа: {string.Join(", ", arg)}");
}

void PrintSum(int[] arg)
{
        int sum = 0;
        for (int i = 0; i < arg.Length; i++)
        {
            if (arg[i] > 0)
            sum += +1;
        }
        Console.Write($"Количество положительных чисел равно {sum}");
}

Console.Clear();
int size = Numb($"Введите количество чисел, которые хотите ввести: ");
int[] array = new int[size];
Array(array);
PrintSum(array);
