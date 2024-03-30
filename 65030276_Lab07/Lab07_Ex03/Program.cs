using System;

class MyClass
{
    private double My_PI;

    public MyClass()
    {
        My_PI = Math.PI;
    }

    public double MyValue
    {
        get
        {
            return My_PI;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // ตัวอย่างการใช้งาน MyClass
        MyClass mc = new MyClass();
        Console.WriteLine($"Value of Pi: {mc.MyValue}");
    }
}