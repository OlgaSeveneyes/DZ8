// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();
Console.WriteLine("Задайте параметры трехмерного массива");
int m = NumberFromUser ("Введите m: ","Ошибка ввода!");
int n = NumberFromUser ("Введите n: ","Ошибка ввода!");
int k = NumberFromUser ("Введите k: ","Ошибка ввода!");
int[,,] array = GetArray (m, n, k, 0, 100);
PrintArray(array);

// возвращает количество элементов массива, либо сообщение об ошибке

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

// возвращает трехмерный массив  

int[,,] GetArray (int i, int j, int z, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, k];
    for (int m = 0; m < result.GetLength(0); m++)
    {
        for (int n = 0; n < result.GetLength(1); n++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            result[m,n,k] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

// выводит массив в консоль (с указанием индекса элементов массива)

void PrintArray (int [,,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
       for (int z = 0; z < inArray.GetLength(2); z++)
       {
            Console.Write($"{inArray[i,j,z]} ({i},{j},{z})\t");
       } 
    }
    Console.WriteLine();
}
}