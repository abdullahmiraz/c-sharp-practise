class MyClass {
    public int PublicField;
    private string PrivateField;
    protected bool ProtectedField;
    internal double InternalField;

    public void PublicMethod() {
        Console.WriteLine("This is a public method");
    }

    private void PrivateMethod() {
        Console.WriteLine("This is a private method");
    }

    protected void ProtectedMethod() {
        Console.WriteLine("This is a protected method");
    }

    internal void InternalMethod() {
        Console.WriteLine("This is an internal method");
    }
}

class Program {
    static void Main() {
        MyClass myObj = new MyClass();

        myObj.PublicField = 10;
        myObj.PublicMethod();

        // The following will cause compilation errors
        // myObj.PrivateField = "private value";
        // myObj.PrivateMethod();
        // myObj.ProtectedField = true;
        // myObj.ProtectedMethod();
        // myObj.InternalField = 3.14;
        // myObj.InternalMethod();
    }
}
