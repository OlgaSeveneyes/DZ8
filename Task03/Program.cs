// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
Console.WriteLine("Задайте две матрицы");
int rous1 = NumberFromUser ("Введите количество строк первой матрицы: ","Ошибка ввода!");
int columns = NumberFromUser ("Введите количество столбцов первой матрицы (равно количеству строк второй матрицы): ","Ошибка ввода!");
int columns2 = NumberFromUser ("Введите количество столбцов второй матрицы: ","Ошибка ввода!");
int[,] array1 = GetArray (rous1, columns, 0, 10);
PrintArray(array1);
Console.WriteLine(); 
int[,] array2 = GetArray (columns, columns2, 0, 10);
PrintArray(array2); 
Console.WriteLine(); 
int [,] multiplicationMatrix = multiplicationArray (array1, array2);
PrintArray(multiplicationMatrix);

// возвращает количество элементов (строк и столбцов) массива, либо сообщение об ошибке

int NumberFromUser (string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

// возвращает массив размером mxn 

int[,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

// выводит массив в консоль

void PrintArray (int [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t"); 
        }
        Console.WriteLine();
    }
}

// возвращает произведение двух массивов

int [,] multiplicationArray (int[,] ourArray1, int[,] ourArray2)
{
    int[,] arrayMultiplication = new int[rous1, columns2];
    for (int i = 0; i < arrayMultiplication.GetLength(0); i++)
    {   
        for (int j = 0; j < arrayMultiplication.GetLength(1); j++)
        {
            arrayMultiplication[i,j] = 0;
            for (int n = 0; n < ourArray1.GetLength(1); n++)
            {
                arrayMultiplication[i,j] += ourArray1[i,n]*ourArray2[n,j];    
            }
        }
    }
    return arrayMultiplication;
}