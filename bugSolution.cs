public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass()
    {
        // Initialize the property in the constructor
        MyProperty = 0; // Or another default value
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty);
    }
}