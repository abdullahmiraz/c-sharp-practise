class Person {
    private string name;
    private int age;

    public string Name {
        get { return name; }
        set { name = value; }

    }
    public int Age {
        get { return age; }
        set { age = value; }
    }
}

class Program {
    static void Main() {
        Person person1 = new Person();
        person1.Name = "Alice";
        person1.Age = 25;

        Console.WriteLine("Name: " + person1.Name);
        Console.WriteLine("Name: " + person1.Age);
    }
}