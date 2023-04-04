//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//    Розширте приклад уроку 005_Book, створивши в класі Book вкладений клас Notes, 
//    який дозволить зберігати нотатки читача.
using System.Security.Cryptography;

namespace EssentialEx3
{
    class Book
    {
        public class Note
        {
            string[] note;

            public Note()
            {
                note = new string[1];
            }

            private void ResizeArray(int index)
            {
                Array.Resize(ref note, index);

            }

            public string this[int index]
            {
                get { return this.note[index]; }
                set
                {
                    ResizeArray(index);
                    this.note[index-1] = value;
                }
            }
            public void FindNext(string str)
            {
                Console.WriteLine("Пошук рядка : " + str);
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                Book.Note newNote = new Book.Note();
                newNote[1] = "example note 1";
                newNote[2] = "example note 2";
                newNote[3] = "example note 3";

                Console.WriteLine(newNote[0]);
                Console.WriteLine(newNote[1]);
                Console.WriteLine(newNote[2]);
            }
        }

    }
}