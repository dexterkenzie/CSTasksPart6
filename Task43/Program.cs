// Задача 43 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] factor = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients()
{
    for (int i = 0; i < factor.GetLength(0); i++)
    {
        Console.WriteLine($"Введите коэффициенты {i + 1}-го уравнения (y = k * x + b):");
        for (int j = 0; j < factor.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите коэффициент k: ");
            else Console.Write($"Введите коэффициент b: ");
            factor[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Decision(double[,] factor)
{
    crossPoint[0] = (factor[1, 1] - factor[0, 1]) / (factor[0, 0] - factor[1, 0]);
    crossPoint[1] = crossPoint[0] * factor[0, 0] + factor[0, 1];
    return crossPoint;
}

void OutputResponse(double[,] factor)
{
    if (factor[0, 0] == factor[1, 0] && factor[0, 1] == factor[1, 1])
    {
        Console.Write($"\nПрямые совпадают");
    }
    else if (factor[0, 0] == factor[1, 0] && factor[0, 1] != factor[1, 1])
    {
        Console.Write($"\nПрямые параллельны");
    }
    else
    {
        Decision(factor);
        Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

InputCoefficients();
OutputResponse(factor);