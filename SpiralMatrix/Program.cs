/*Задача 62.Заполните спирально массив 4 на 4.
 
 Например, на выходе получается вот такой массив:
 
 1 2 3 4
 
 12 13 14 5
 
 11 16 15 6
 
 10 9 8 7 */
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
            //функция заполнения массива по спирали:
int[,] InitMatrix1(int[,] nullArray)
{
    int q = 0;
    int w = 0;
    int count = 1;
    int l = 1; 
    int m = 1;
                
    int maxNumber = nullArray.GetLength(0) * nullArray.GetLength(1);
    int numbStr = nullArray.GetLength(0);
    int numbCol = nullArray.GetLength(1);
 
    for (int i = 0; i < maxNumber; i++)
    {
        nullArray[w, q] = count;
        if (q < numbCol - l &&w < m)
        {
            q++;
        }
        else if (q == numbCol - l && w < numbStr - m)
        {
            w++;
        }
        else if (w == numbStr - m && q > l - 1)
        {
            q--;
        }
        else if (q == l - 1 && w > m - 1)
        {
            w--;
            if (w == m)
            {
                l++;
                m++;
            }
        }
    count++;
    }
return nullArray;
}
            //функция вывода на печать:
void PrintMatrix(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)// счетчик строк
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)// счетчик столбцов 
        {
            Console.Write($"{matrix2[i, j]} \t");
        }
    Console.WriteLine();
    }
}
int o = GetNumber("Введите количество строк :");
int p = GetNumber("Введите количество столбцов :");
 
int[,] matrix = new int[o, p];
 
int[,] resArray = InitMatrix1(matrix);
 
Console.WriteLine("Заполненный по спирали массив:");
PrintMatrix(resArray);
 
