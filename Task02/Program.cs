// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
Console.WriteLine("Задаем прямоугольный массив");
int rous = NumberFromUser ("Введите количество строк массива: ","Ошибка ввода!");
int columns = NumberFromUser ("Введите количество столбцов массива (не должно совпадать с количеством строк): ","Ошибка ввода!");
if (rous!=columns)
{
    int[,] array = GetArray (rous, columns, 0, 10);
    PrintArray(array); 
    int rousIndex = IndexRousWithMinSum (array);
    Console.WriteLine($"Номер строки с минимальной суммой элементов: {rousIndex+1}");
}
else
{
    Console.WriteLine("Ошибка! Массив не прямоугольный!");
}

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

// возвращает индекс строки с наименьшей суммой элементов

int IndexRousWithMinSum (int[,] ourArray)
{
    int[] arraySum = new int[rous];
    int sumInRous = 0;
    for (int i = 0; i < ourArray.GetLength(0); i++)
    {   
        for (int j = 0; j < ourArray.GetLength(1); j++)
        {
            sumInRous += ourArray[i,j];
        }
        arraySum[i] = sumInRous;
        sumInRous = 0;
    }
    int indexRousMin = 0;
    for (int i = 0; i < arraySum.Length; i++)
    {
        if (arraySum[i]<arraySum[indexRousMin])
        indexRousMin = i;    
    }
    return indexRousMin;
}