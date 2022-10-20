//Написать программу копирования массива
void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
   Random losk = new Random();
   collection[index] = losk.Next(-100,100);
    }
}

void PrintArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
    Console.Write($"{collection[index]} ");
    }
}

int[] collection = new int[10];
FillArray(collection);
Console.Write("Оригинальный массив: ");
PrintArray(collection);
Console.WriteLine();

int[] copy = new int [10];
void FillArray1(int[] copy)
{
    for (int index = 0; index < collection.Length; index++)
    {
    copy[index] = collection[index];
    }
}

void PrintArray1 (int[] copy)
{
    
for (int index = 0; index < collection.Length; index++)
    {
    Console.Write($"{copy[index]} ");
    }
}
FillArray1(copy);
Console.Write("Скопированный массив: ");
PrintArray1(copy);