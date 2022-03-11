class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 5, 10, 43, 101, 202 };
        int objective = 101;
        int sizeArray = array.Length;

        //var res = BinarySearchIterative(array, 0, sizeArray - 1, objective);
        var res = BinarySearchRecursive(array, 0, sizeArray - 1, objective);
        if (res == -1)
            Console.WriteLine($"El elemento {objective} no se ha encontrado");
        else
            Console.WriteLine($"El elemento {objective} se ha encontrado en el indice {res}");
    }



    //Metodo Binary Search Iterativo
    public static int BinarySearchIterative(int[] array, int left, int right, int objective)
    {
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (array[mid] == objective)
                return mid;

            if (array[mid] < objective)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }


    //Metodo Binary Search Recursivo
    public static int BinarySearchRecursive(int[] array, int left, int right, int objective)
    {
        if (right >= left)
        {
            int mid = left + (right - left) / 2;
            if (array[mid] == objective)
                return mid;

            if (array[mid] > objective)
                return BinarySearchRecursive(array, left, mid - 1, objective);
            else
                return BinarySearchRecursive(array, mid + 1, right, objective);
        }

        return -1;
    }
}