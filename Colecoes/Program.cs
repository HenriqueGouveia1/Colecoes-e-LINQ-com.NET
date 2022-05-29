int[,] matriz = new int[4, 2]
    {
        {1,2},
        {1,2},
        {1,2},
        {1,2}
    };

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            System.Console.WriteLine($"Elemento {matriz[i,j]}");
        }
    }
