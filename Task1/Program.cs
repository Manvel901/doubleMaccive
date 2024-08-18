using System.Diagnostics;
using System.Globalization;

int[,] matrix = new int[5, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        string value = Console.ReadLine();
         matrix[i, j] = Convert.ToInt32(value);
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
         Console.Write($"{matrix[i, j] } ");
    }
    Console.WriteLine();
}

     
   
