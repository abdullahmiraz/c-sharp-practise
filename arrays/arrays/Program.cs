int[] numbers = new int[3];
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
 
string[] names = { "Alice", "Bob", "Charlie" };

for(int i = 0; i < numbers.Length; i++) {
    Console.WriteLine(numbers[i]);
}

foreach(string name in names) {
    Console.WriteLine(name);
}