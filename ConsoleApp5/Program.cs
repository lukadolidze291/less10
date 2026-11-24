namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = new int[] { 15, 42, 7, 88, 23, 56, 91, 34, 12, 67, 45, 82 };
            Array array1 = new Array(numbers1);
            Console.WriteLine("Test 1:");
            array1.ShowEven();
            array1.ShowOdd();
            Console.WriteLine("Distinct numbers: " + array1.CountDistinct());
            Console.WriteLine("Count of 45: " + array1.EqualToValue(45));
            Console.WriteLine("Count of 88: " + array1.EqualToValue(88));

            Console.WriteLine();

            int[] numbers2 = new int[] { 33, 76, 19, 64, 48, 21, 85, 39, 72, 11, 29, 58, 41, 33, 76 };
            Array array2 = new Array(numbers2);
            Console.WriteLine("Test 2:");
            array2.ShowEven();
            array2.ShowOdd();
            Console.WriteLine("Distinct numbers: " + array2.CountDistinct());
            Console.WriteLine("Count of 33: " + array2.EqualToValue(33));
            Console.WriteLine("Count of 76: " + array2.EqualToValue(76));

            Console.WriteLine();

            int[] numbers3 = new int[] { 98, 27, 61, 44, 13, 79, 52, 8, 36, 69, 14, 84, 22, 97, 50, 44, 27 };
            Array array3 = new Array(numbers3);
            Console.WriteLine("Test 3:");
            array3.ShowEven();
            array3.ShowOdd();
            Console.WriteLine("Distinct numbers: " + array3.CountDistinct());
            Console.WriteLine("Count of 44: " + array3.EqualToValue(44));
            Console.WriteLine("Count of 27: " + array3.EqualToValue(27));

            Console.WriteLine();

            int[] numbers4 = new int[] { };
            Array array4 = new Array(numbers4);
            Console.WriteLine("Test 4:");
            array4.ShowEven();
            array4.ShowOdd();
            Console.WriteLine("Distinct numbers: " + array4.CountDistinct());
            Console.WriteLine("Count of 5: " + array4.EqualToValue(5));
        }
    }
}
