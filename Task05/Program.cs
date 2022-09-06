// Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();
int rous = 4;
int columns = 4;
int[,] array = new int[rous, columns];
for (int i = 0; i < array.GetLength(0); i++)
{   
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[0,0] = 0;
        for (int k = array.GetLength(1)-1; k > j; k--)
        {
            array[i,k] += 1;
        }
    }    
}        
for (int i = 0; i < array.GetLength(0); i++)
{    
    int j = array.GetLength(1)-1;
    array[i,j] += i;  
}
int count = 0;
for (int j = array.GetLength(1)-2; j >=0; j--)
{    
    int i = array.GetLength(0)-1;
    array[i,j] = array[array.GetLength(0)-1,array.GetLength(1)-1] + 1 + count;
    count++;  
} 
count = 0;
for (int i = array.GetLength(1)-2; i > 0; i--)
{    
    int j = 0;
    array[i,j] = array[array.GetLength(0)-1,j] + 1 + count;
    count++;    
}
count = 0;
for (int j = 0; j < array.GetLength(1)-1; j++)
{    
    int i = 1;
    array[i,j] = array[1,0] + count; 
    count++;  
}
count = 1;
for (int j = array.GetLength(1)-2; j > 0; j--)
{    
    int i = 2;
    array[i,j] = array[1,2] + count; 
    count++;  
}
PrintArray(array);

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