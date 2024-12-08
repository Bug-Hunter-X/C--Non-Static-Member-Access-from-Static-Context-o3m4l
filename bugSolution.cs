public class MyClass
{
    //Solution 1: Make the member static
    public static int MyStaticProperty { get; set; }

    public int MyProperty { get; set; }

    public static void MyStaticMethod()
    {
        Console.WriteLine(MyStaticProperty);
    }

    //Solution 2: Create an instance of the class
    public void MyMethod()
    {
        MyClass instance = new MyClass();
        Console.WriteLine(instance.MyProperty);
    }
}