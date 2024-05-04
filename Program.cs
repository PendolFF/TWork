class Program
{
    static void Main(string[] args)
    {
        // Пользователю предлагается ввести элементы массива через запятую
        Console.WriteLine("Введите элементы массива через запятую:");
        // Считывается введенная строка с консоли и разбивается на массив строк по запятой
        string[] initialArray = Console.ReadLine().Split(',');

        // Фильтруется начальный массив строк по длине, оставляя только те строки, которые имеют длину меньше или равную 3 символам
        string[] newArray = FilterArrayByLength(initialArray, 3);

        // Выводится на экран новый массив строк с длиной меньше или равной 3 символам
        Console.WriteLine("Новый массив строк с длиной меньше или равной 3 символам:");
        foreach (string str in newArray)
        {
            Console.Write(str + " ");
        }
    }

    static string[] FilterArrayByLength(string[] array, int maxLength)
    {
        // Подсчитывается количество строк в массиве, удовлетворяющих условию
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= maxLength)
            {
                count++;
            }
        }

        // Создается новый массив подходящей длины и условию
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

        // Возвращается новый массив строк, прошедших фильтрацию
        return result;
    }
}