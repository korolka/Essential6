//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//    Потрібно: створити розширюючий метод для цілого масиву, який сортує елементи масиву за зростанням. 
namespace EssentialEx4
{
    static class MyClass
    {

        public static void ArraySort(this int[] array)
        {
            Array.Sort(array);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 6, 3, 67, 5, 2,315 };

            Console.WriteLine("Array before sort");
            for(int i=0;i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            array.ArraySort();

            Console.WriteLine("Array before sort");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}