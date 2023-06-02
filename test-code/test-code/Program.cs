abstract class Animal {
    public void Eat() {
        Console.WriteLine("Animal is eating");
    }
}

interface ISwim {
    void Swim();
}

class Dolphin : Animal, ISwim {
    public void Swim() {
        Console.WriteLine("Dolphin is swimming underwater");
    }
}

class Program {
    static void Main() {
        Dolphin dolphin = new Dolphin();
        dolphin.Eat();
        dolphin.Swim();
    }
}
