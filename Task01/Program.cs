// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int rous = NumberFromUser ("Введите количество строк массива: ","Ошибка ввода!");
int columns = NumberFromUser ("Введите количество столбцов массива: ","Ошибка ввода!");
int[,] array = GetArray (rous, columns, 0, 10);
PrintArray(array);
FromMaxToMinInRous (array);
Console.WriteLine();
PrintArray(array);

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

// возвращает упорядоченнo по убыванию элементы каждой строки массива

void FromMaxToMinInRous (int[,] ourArray)
{
for (int i = 0; i < ourArray.GetLength(0); i++)
{   
    for (int j = 0; j < ourArray.GetLength(1); j++)
    {
        for (int k = ourArray.GetLength(1)-1; k > j; k--)
        {
            if (ourArray[i,k] > ourArray[i,k-1])
            {
                int max = ourArray[i,k];    
                ourArray[i,k] = ourArray[i,k-1];    
                ourArray[i,k-1] = max;      
            }    
        }        
    } 
}
}