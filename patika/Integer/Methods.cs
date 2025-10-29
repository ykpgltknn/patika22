public class Methods
{
    public static void AddNumber()
    {
        GetNumbers get = new GetNumbers();
        get.GetTheNumbers();
    }
    public static void ProcessNumbers()
    {
        Process news = new Process();
        news.ProcessNumbers();
    }
    public static void PrintList()
    {
        Console.WriteLine("\nReceived List:");
        Console.WriteLine(string.Join(", ", IntList.IntegerList));

        Console.WriteLine("\nProcessed List:");
        Console.WriteLine(string.Join(", ", IntList.FinishedList));

        IntList.IntegerList.Clear();
        IntList.FinishedList.Clear();

        Console.WriteLine("\nList cleared! Press any key to exit");
        Console.ReadKey();
    }
    public static int IsItIntegerOrQ(string num)
    {
        while (true)
        {
            if (!string.IsNullOrWhiteSpace(num) && int.TryParse(num, out int number))
            {
                return number;
            }
            if (num.ToLower() == "q")
            {
                return 000;
            }
            Console.WriteLine("please enter a valid integer!");
            Console.Write("Try again: ");
            num = Console.ReadLine();
        }
    }
    public static void ShowInstructions()
    {
        Console.WriteLine("The operation will be performed with consecutive numbers, starting from the first element");
        Console.WriteLine("* If the numbers are the same, they will be added.");
        Console.WriteLine("* If the numbers are different, their sums are squared.\n");
    }

}