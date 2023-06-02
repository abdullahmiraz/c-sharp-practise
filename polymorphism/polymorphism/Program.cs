class Animal
{
    public virtual void makeSound()
    {
        Console.WriteLine("The animal makes a sound") ;
    }
}
class Dog:Animal
{
    public override void makeSound()
    {
        Console.WriteLine("The dog barks");
    }
}

class Cat : Animal
{
    public override void makeSound()
    {
        // base.makeSound();
        Console.WriteLine("The cat meows");
    }
}


class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        animal.makeSound();

        Animal dog = new Dog(); 
        dog.makeSound();

        Animal cat = new Cat(); 
        cat.makeSound();
    }
}