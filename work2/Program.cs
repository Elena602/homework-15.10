// Написать программу масштабирования фигуры
int[,] matr = new int [4, 2];
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random random = new Random();
            matr[i, j] = random.Next(-5, 5);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        Console.Write("");
        }
    }
Console.Write("("+ matr[0,0] + "," + matr[0,1] + ")");
Console.Write("("+ matr[1,0] + "," + matr[1,1] + ")");
Console.Write("("+ matr[2,0] + "," + matr[2,1] + ")");
Console.Write("("+ matr[3,0] + "," + matr[3,1] + ")");
}
FillArray(matr);
PrintArray(matr);
Console.WriteLine();
Console.WriteLine("Введите k: ");
System.Double k = System.Double.Parse(Console.ReadLine() ?? "0");

double[,] matrix = new double [4, 2];
void ChangeArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i,j] = matr[i,j] * k;
        }
    }
}

void PrintArray1(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i,j] = matr[i,j] * k;
        }
    
    }
Console.Write("("+ matrix[0,0] + "," + matrix[0,1] + ")");
Console.Write("("+ matrix[1,0] + "," + matrix[1,1] + ")");
Console.Write("("+ matrix[2,0] + "," + matrix[2,1] + ")");
Console.Write("("+ matrix[3,0] + "," + matrix[3,1] + ")");
}
ChangeArray(matrix);
PrintArray1(matrix);