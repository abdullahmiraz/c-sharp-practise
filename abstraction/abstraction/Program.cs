abstract class Animal
{
    public abstract void makeSound();
}
class Dog : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("The dog barks");
    }
}

interface Ijumpable
{
    void Jump();
}

class Cat: Animal, Ijumpable
{
    public override void makeSound()
    {
        Console.WriteLine("The cat meows");
    }     
    public void Jump()
    {
        Console.WriteLine("The cat jumps");
    }
}


class Program
{
    static void Main()
    {
        Animal dog = new Dog();
        dog.makeSound();

        Animal cat = new Cat(); 
        cat.makeSound();

        Ijumpable jumpable = (Ijumpable)cat;
        jumpable.Jump();
    }
}