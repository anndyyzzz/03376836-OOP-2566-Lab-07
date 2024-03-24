using System;

class MyClass
{
    private int StoredValue;
    public int MyValue
    {
        get
        {
            return StoredValue;
        }
        set
        {
            StoredValue = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass mc = new MyClass();
        mc.MyValue = 50;
        Console.WriteLine($"My value  = {mc.MyValue}");
    }
}
