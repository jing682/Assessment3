namespace Assessment3
{
    internal class Program
    {
        public static void BubbleSort(string[] array, int n) {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(array[j], array[j + 1]) > 0)
                    {
                        string temp;
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string[] stringArray = {"Jon", "Dot", "Eva", "Roy", "Guy", "Jan", "Tom", "Jim", "Ann", "Kim", "Ron", "Tim", "Kay", "Amy"};

            BubbleSort(stringArray, stringArray.Length);

            foreach (string str in stringArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (i >= 10)
                {
                    Console.Write(i + "  ");
                }
                else 
                {
                    Console.Write(" " + i + "  ");
                }
            }

        }
    }
}
