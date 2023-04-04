//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Потрібно: Створити статичний клас FindAndReplaceManager з методом void FindNext(string str)
//    для пошуку за книгою з прикладу уроку 005_Book. При виклику цього методу проводиться 
//    послідовний пошук рядка в книзі.
namespace Essenial6
{
    static class FindAndReplaceManager
    {
        public static void FindNext(string str)
        {
            Book book = new Book();
            book.FindNext(str);
        }
    }
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("Text");
        }
    }
}