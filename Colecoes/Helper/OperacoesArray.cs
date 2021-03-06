namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        public bool ExisteElemento(int[]array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        public void CopiaArray(ref int[]array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino,array.Length);
        }
        public void OrdenarBubbleSorte(ref int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);
        }
    
        public void OrdenarArraySort(ref int[] array)
        {
            Array.Sort(array);
        }
    }
}