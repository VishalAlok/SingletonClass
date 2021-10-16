using System;

class Singleton
{
    public static Singleton obj = new Singleton();

    public void Display()
    {
        Console.WriteLine(true);
    }
    Singleton() { } //Private So cannot create object outside
}

class SingletonDemo
{
    public static void Main()
    {
        //Singleton _obj = new Singleton(); //Wont Allow as constructor is private
        Singleton.obj.Display(); //Calling static CLass Object
    }
}