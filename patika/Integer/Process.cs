class Process
{
    public void ProcessNumbers()
    {
        Console.Clear();

        if (IntList.IntegerList.Count >= 2)
        {
            for (int i = 0; i < IntList.IntegerList.Count - 1; i += 2)
            {
                int thisNum = IntList.IntegerList[i];
                int nextNum = IntList.IntegerList[i + 1];

                if (thisNum != nextNum)
                {
                    IntList.FinishedList.Add(thisNum + nextNum);
                }
                if (thisNum == nextNum)
                {
                    IntList.FinishedList.Add((thisNum + nextNum) * (thisNum + nextNum));
                }
            }

            int LastIndex = IntList.IntegerList.Count - 1;
            if (IntList.IntegerList.Count % 2 != 0)
            {
                Console.WriteLine($"\nNote: The last number has no pair and was skipped! Number: {IntList.IntegerList[LastIndex]}");
            }

            Methods.PrintList();

        }
        else
        {
            Console.WriteLine("Must be at least two numbers on the list!\nPress any key to exit");
            Console.ReadKey();
        }
    }
}