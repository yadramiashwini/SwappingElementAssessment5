namespace SwappingElementAssessment5
{
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };

            SwapElements(numbers, 1, 3);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void SwapElements<T>(List<T> list, int index1, int index2)
        {
            if (index1 >= 0 && index1 < list.Count && index2 >= 0 && index2 < list.Count)
            {
                T temp = list[index1];
                list[index1] = list[index2];
                list[index2] = temp;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid indices.");
            }
        }
    }
}
