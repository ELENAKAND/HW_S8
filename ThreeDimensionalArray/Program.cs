/*Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
             которая будет построчно выводить массив, добавляя индексы каждого элемента.
 
 массив размером 2 x 2 x 2
 
 12(0, 0, 0) 22(0, 0, 1)
 
 45(1, 0, 0) 53(1, 0, 1)
 
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
int[,,] InitMatrix1(int k, int l, int m)
{
    int[,,] matrix1 = new int[k, l, m];
    Random randomizer = new Random();
    for (int i = 0; i < k; i++)// счетчик строк
    {
        for (int j = 0; j < l; j++)// счетчик столбцов 
        {
            for(int y=0; y<m; y++)
                matrix1[i, j, y] = randomizer.Next(-99, 100);
        }
    }
return matrix1;
}
int[,,] UnRepit(int[,,] matrix2)
{
    Random randomizer = new Random();
    for (int i = 0; i < matrix2.GetLength(0); i++)// счетчик строк
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)// счетчик столбцов 
        {
            for (int y = 0; y < matrix2.GetLength(2); y++)//счетчик слоев
            {
                int argument = matrix2[i, j, y];
                void Search(int arg)
                {
                    for (int q = 0; q < matrix2.GetLength(0); q++)// счетчик строк
                    {
                        for (int w = 0; w < matrix2.GetLength(1); w++)// счетчик столбцов 
                        {
                            for (int e = 0; e < matrix2.GetLength(2); e++)//счетчик слоев
                            {
                                if (argument == matrix2[q, w, e] && (i != q || j != w || y != e))
                                {
                                    matrix2[q, w, e] = randomizer.Next(0, 100);
                                    Search(matrix2[q, w, e]);
 
                                }
                            }
                        }
                    }
                }
                Search(argument);
            }
        }
    }
return matrix2;
}
 //функция вывода на печать:
void PrintMatrix(int[,,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)// счетчик строк
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)// счетчик столбцов 
        {
            for (int y = 0; y < matrix2.GetLength(2); y++)//счетчик слоев
            {
                Console.Write($"{matrix2[i, j, y]} ({i}, {j}, {y}) \t");
            }
            Console.WriteLine();
        }
    }
}
int o = GetNumber("Введите количество строк :");
int n = GetNumber("Введите количество столбцов :");
int p = GetNumber("Введите количество слоев :");
 
int[,,] myArray = InitMatrix1(o, n, p);
 
int[,,] resArray = UnRepit(myArray);
 
PrintMatrix(resArray);