# Lab 7 Exercise 1

## Properties calculation

1. สร้าง console application project

```cmd
dotnet new console --name Lab07_Ex01
```

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
MyClass mc = new MyClass();
mc.MyValue = 50;
System.Console.WriteLine($"mc.MyValue = {mc.MyValue}");
mc.MyValue = 150;
System.Console.WriteLine($"mc.MyValue = {mc.MyValue}");

class MyClass
{
    private int StoredPercentValue;
    public int MyValue
    {
        set
        {   
            if(value > 100)
                StoredPercentValue = 100;
                else
                StoredPercentValue = value;
        }
        get
        {
            return StoredPercentValue;
        }
    }
}
```

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab07_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab07_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

7. อธิบายสิ่งที่พบในการทดลอง
