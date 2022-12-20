double [,] matrix = new double[3, 4];
    for ( int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //matrix[i, j] = new Random().Next(); // [1, 10]
            matrix[i, j] = new Random().NextDouble();
         Console.WriteLine(matrix[i, j]);
        }
        Console.WriteLine();
    }
