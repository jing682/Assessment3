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

        public static int BinarySearch(string[] list, string item, ref bool found)  //changes item from int to string
        {
            int midPoint;
            int first = 0;
            int last = list.Length - 1;
            bool moreToSearch = first <= last;

            while (moreToSearch && !found)
            {
                midPoint = (first + last) / 2;

                if (string.Compare(item, list[midPoint]) < 0)  // translated to c++ = item < list.info[midPoint]
                {
                    last = midPoint - 1;
                    moreToSearch = first <= last;
                }
                else if (string.Compare(item, list[midPoint]) > 0)  // translated to c++ = item > list.info[midPoint]
                {
                    first = midPoint + 1;
                    moreToSearch = first <= last;
                }
                else
                {
                    found = true;
                    return midPoint;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            string[] stringArray = {"Jon", "Dot", "Eva", "Roy", "Guy", "Jan", "Tom", "Jim", "Ann", "Kim", "Ron", "Tim", "Kay", "Amy"};
            bool found = false;

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
            Console.WriteLine();
            Console.Write("Enter name to search : ");
            string name = Console.ReadLine();

            int indexFound = BinarySearch(stringArray, name, ref found);
            if (found)
            {
                Console.WriteLine($"{name} has been found at index {indexFound}");
            }
            else 
            {
                Console.WriteLine($"{name} cant be found");
            }

        }
    }
}
