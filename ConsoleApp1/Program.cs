using MyListGeneric;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClassGeneric<string> firstElement = new MyClassGeneric<string>("This is the first element");
            MyClassGeneric<string> secondElement = new MyClassGeneric<string>("This is the second element");
            MyClassGeneric<string> thirdElement = new MyClassGeneric<string>("This is the third element");

            MyList <MyClassGeneric<string> > myCollection = new MyList<MyClassGeneric<string>>();
            myCollection.Add(firstElement);
            myCollection.Add(secondElement);
            myCollection.Add(thirdElement);

            Console.WriteLine("\nВывод коллекции после добавления элементов:\n");
            foreach(var item in myCollection)
            {
                Console.WriteLine("\t" + item.Data);
            }

            myCollection.Remove(secondElement);
            Console.WriteLine("\nВывод коллекции после удаления второго элемента:\n");
            foreach (var item in myCollection)
            {
                Console.WriteLine("\t" + item.Data);
            }

        }
    }
}
