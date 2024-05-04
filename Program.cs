class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через запятую:");
        string[] initialArray = Console.ReadLine().Split(',');

        string[] newArray = FilterArrayByLength(initialArray, 3);

        Console.WriteLine("Новый массив строк с длиной меньше или равной 3 символам:");
        foreach (string str in newArray)
        {
            Console.Write(str + " ");
        }
    }

    static string[] FilterArrayByLength(string[] array, int maxLength)
    {
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= maxLength)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;
        foreach (string str in array)
        {
            if (str.Length <= maxLength)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }
}
