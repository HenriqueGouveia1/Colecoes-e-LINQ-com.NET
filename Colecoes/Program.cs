using Colecoes.Helper;

static void ArraySort()
{
    OperacoesArray op2 = new OperacoesArray();
    int[] array = new int[5] { 2, 1, 3, 4, 5 };
    op2.ImprimirArray(array);

    op2.OrdenarArraySort(ref array);
    op2.ImprimirArray(array);
}

static void BubbleEimprime()
{
    OperacoesArray op = new OperacoesArray();
    int[] array = new int[5] { 2, 1, 3, 4, 5 };
    System.Console.WriteLine("Original");
    op.ImprimirArray(array);

    op.OrdenarBubbleSorte(ref array);
    System.Console.WriteLine("Ordenado");
    op.ImprimirArray(array);
}

static void ImprimeMatriz()
{
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
            System.Console.WriteLine(matriz[i, j]);
        }
    }

}