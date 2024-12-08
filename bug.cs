public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a non-static member from a static context
        Console.WriteLine(MyProperty); 
    }
}