using MyListGeneric;
using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void ShowCollection(MyList<MyClassGeneric<string>> myCollection)
        {
            foreach (var item in myCollection)
            {
                Console.WriteLine("\t" + item.Data);
            }
            Console.WriteLine("\nЭлементов в коллекции " + myCollection.Count);
        }
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
            ShowCollection(myCollection);

            myCollection.Remove(secondElement);
            Console.WriteLine("\nВывод коллекции после удаления второго элемента:\n");
            ShowCollection(myCollection);


            myCollection.AppendFirst(secondElement);
            Console.WriteLine("\nВывод коллекции после добавления второго элемента в начало списка:\n");
            ShowCollection(myCollection);

            Console.WriteLine("\nКоллкеция содержит \"first element\"\t" + myCollection.Contains(firstElement));
            Console.WriteLine("Коллкеция содержит \"second element\"\t" + myCollection.Contains(secondElement));
            Console.WriteLine("Коллкеция содержит \"third element\"\t" + myCollection.Contains(thirdElement));

            myCollection.Clear();
            Console.WriteLine("\n\nКоллекция очищенна: " + myCollection.IsEmpty);


        }
    }
}
