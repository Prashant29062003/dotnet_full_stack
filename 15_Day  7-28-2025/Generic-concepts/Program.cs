using System;
using System.Collections.Generic;

// for single type
class myGeneralClass<T>
{
    public T Value { get; set; }
    public myGeneralClass(T val)
    {
        Value = val;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Hello {Value}!");
    }
}

// Genaric class
class Student
{
    public string Name { get; set; }
    public override string ToString()
    {
        return $"My name is {Name}";
    }
}


// List Implementaion 
class MyArray<T>
{
    public List<T> items { get; set; }

    public MyArray()
    {
        items = new List<T>();
    }

    public void AddItem(T item)
    {
        items.Add(item);
    }
    public void ShowItems()
    {
        foreach(T item in items)
        {
            Console.WriteLine(item);
        }
    }

}

// Dictionary
class myDict<TKey, TVal>
{
    public Dictionary<TKey, TVal> Data { get; set; }
    public myDict()
    {
        Data = new Dictionary<TKey, TVal>();
    }
    public void AddItems(TKey key, TVal val)
    {
        Data[key] = val;
    }

    public void ShowDict()
    {
        foreach (var pair in Data)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}

// for multiple types
//class myList<TKey, TVal>
//{
//    public 
//}
class Program
{
    public static void Main()
    {
        // string
        Console.WriteLine("Generic String: ");
        string myName = "Prashant";
        myGeneralClass<string> myClass = new myGeneralClass<string>(myName);
        myClass.DisplayDetails();

        // int
        Console.WriteLine("------------------------------");
        Console.WriteLine("Generic int: ");
        myGeneralClass<int> myInt = new myGeneralClass<int>(7);
        myInt.DisplayDetails();

        // bool
        Console.WriteLine("------------------------------");
        Console.WriteLine("Generic bool: ");
        myGeneralClass<bool> myBool = new myGeneralClass<bool>(true);
        myBool.DisplayDetails();

        // custom class
        Console.WriteLine("------------------------------");
        Console.WriteLine("Generic class: ");
        myGeneralClass<Student> myStudent = new myGeneralClass<Student>(new Student { Name = "Prashant"});
        myStudent.DisplayDetails();


        // list 
        Console.WriteLine("------------------------------");
        Console.WriteLine("Generic list: ");
        MyArray<string> myArr = new MyArray<string>();
        myArr.AddItem("Prashant");

        myArr.AddItem("Ved");
        myArr.AddItem("Rahul");
        myArr.ShowItems();



        // my Dictionary
        Console.WriteLine("------------------------------");
        Console.WriteLine("Generic Dictionary: ");
        myDict<int, string> newDict = new myDict<int, string>();

        newDict.AddItems(101, "Prashant");
        newDict.AddItems(102, "Rahul");
        newDict.AddItems(103, "Ved");

        newDict.ShowDict();


        Console.ReadLine();
    }
}
