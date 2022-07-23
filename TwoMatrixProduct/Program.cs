/*Задача 58: Задайте две матрицы.Напишите программу, которая будет находить 
произведение двух матриц.
 Например, заданы 2 массива:
 1 4 7 2
 5 9 2 3
 8 4 2 4
 5 2 6 7
и
 1 5 8 5
 4 9 4 2
 7 2 2 6
 2 3 4 7
 Их произведение будет равно следующему массиву:
 1 20 56 10
 20 81 8 6
 56 8 4 24
 10 6 24 49
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
int[,] InitMatrix1(int k, int l)
{
    int[,] matrix1 = new int[k, l];
    Random randomizer = new Random();
    for (int i = 0; i < k; i++)// счетчик строк
    {
        for (int j = 0; j < l; j++)// счетчик столбцов 
        {
            matrix1[i,j] = randomizer.Next(0, 100);
        }
    }
return matrix1;
}
int[,] InitMatrix2(int k, int l)
{
    int[,] matrix2 = new int[k, l];
    Random randomizer1 = new Random();
    for (int i = 0; i < k; i++)// счетчик строк
    {
        for (int j = 0; j < l; j++)// счетчик столбцов 
        {
            matrix2[i, j] = randomizer1.Next(-99, 99);
        }
    }
return matrix2;
}
void PrintMatrix(int[,] matrix2)
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
int[,] ResMatrix(int[,] myArray1, int[,] myArray2) //умножение элементов матрицы
{
    int[,] res = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i,j] = myArray1[i, j] * myArray2[i,j];
        }
    }
return res;
}
int[,] myMatrix1 = InitMatrix1(m, n);//заполняем массив 1
Console.WriteLine($"Матрица1 размером {m}x{n}:");
Console.WriteLine();
PrintMatrix(myMatrix1);
int[,] myMatrix2 = InitMatrix2(m,n);//заполняем массив 2
Console.WriteLine($"Матрица2 размером {m}x{n}:");
Console.WriteLine();
PrintMatrix(myMatrix2);
int[,] resArray = ResMatrix(myMatrix1, myMatrix2);
Console.WriteLine();
Console.WriteLine("Массив произведений:");//печатаем результирующий массив
Console.WriteLine();
PrintMatrix(resArray);
 
