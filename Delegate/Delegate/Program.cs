delegate void printDelegate(string message);

class Program {
    static void PrintMessage(string message) {
        Console.WriteLine(message);
    }
    static void Main() {
        printDelegate print = PrintMessage;
        print("Hello World");
    }
}