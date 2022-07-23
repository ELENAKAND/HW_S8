/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
 
 Например, задан массив:
 
 1 4 7 2
 
 5 9 2 3
 
 8 4 2 4
 
 5 2 6 7
 
 Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 
*/
int GetNumber(string message)
{
    int result = 0;
    string errorMessage = ("Вы ввели не число. Введите корректное число.");
        while (true)
        {
            Console.WriteLine(message);
            if (int.TryParse(Console.ReadLine(), out result))
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
        }
return result;
}
double[,] InitMatrix(int k, int l)
{
    double[,] matrix1 = new double[k, l];
    Random randomizer = new Random();
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < l; j++)
            {
                double z = randomizer.Next(-99, 100);
                matrix1[i, j] = z / 10;
            }
        }
return matrix1;
}
void PrintMatrix(double[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($"{matrix2[i, j]} ");
        }
            Console.WriteLine();
    }
}
int m = GetNumber("Введите количество строк :");
int n = GetNumber("Введите количество столбцов :");
int MinSumString(double[,] myArray)
{
    double[] Sum = new double[m];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Sum[i] += myArray[i, j];                                                                     
            }                    
        }
    double Min = Sum[0];
    int NumberString = 0;
        for (int i = 0; i < m; i++)
        {
            if (Sum[i] < Min)
            {
                Min = Sum[i];
                NumberString = i;
            }
        }
return NumberString;
}
double[,] oldMatrix = InitMatrix(m, n);
Console.WriteLine($"Массив размером {m}x{n}:");
Console.WriteLine();
PrintMatrix(oldMatrix);
int number = MinSumString(oldMatrix);
 
Console.WriteLine($"Номер строки с минимальной суммой: {number + 1}");

