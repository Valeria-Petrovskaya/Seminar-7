int[,] matrix = new int[3, 4];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(); // [1, 10]
         //Console.WriteLine(matrix[i, j]);
        }
        Console.WriteLine();
    }

Console.WriteLine("Введите координату x: ");
int xcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
int ycoord = Convert.ToInt32(Console.ReadLine());

if (xcoord <= matrix.GetLength(0) && ycoord <= matrix.GetLength(1))
{
    Console.WriteLine(matrix[xcoord, ycoord]);
} else
{
    Console.WriteLine("Такого элемента нет");
}