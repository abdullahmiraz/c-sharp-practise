enum DayOfWeek {
    Monday, Tuesday, Wednesday, thursday, friday, saturday, sunday
}

class Program {
    static void Main() {
        DayOfWeek today = DayOfWeek.Monday;
        Console.WriteLine("Toady is: " + today);
    }
}