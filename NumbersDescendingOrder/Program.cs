/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
 Например, задан массив:
 1 4 7 2
 5 9 2 3
 8 4 2 4
 В итоге получается вот такой массив:
 1 2 4 7
 2 3 5 9
 2 4 4 8
 */
 // проверка чисел, вводимых с консоли:
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
    for (int i = 0; i < k; i++)// счетчик строк
    {
        for (int j = 0; j < l; j++)// счетчик столбцов 
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
 
double[,] ChangeMatrix(double[,]myArray)
{
    for (int i = 0; i < m; i++)// счетчик строк
    {
        for (int j = 0; j < n ; j++)// счетчик столбцов 
        {
            double Max = myArray[i, j];
            for (int k = j; k < n ; k++)
            {
                if (myArray[i, k] > Max)
                {
                    myArray[i,j] = myArray[i, k];
                    myArray[i, k] = Max;
                }
            }
        }
    }
return myArray;
}
double[,] oldMatrix = InitMatrix(m, n);
Console.WriteLine($"Массив размером {m}x{n}:");
Console.WriteLine();
PrintMatrix(oldMatrix);
Console.WriteLine("Упорядоченный массив:");
double[,] newMatrix = ChangeMatrix(oldMatrix);
PrintMatrix(newMatrix);
 