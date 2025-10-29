using static Methods;
class Check : GetString
{
    public void CheckString()
    {
        GetTheString();
        Console.Clear();
        str.Trim();
        string Output = "";

        string[] SplitedText = str.Split(" ");

        foreach (string word in SplitedText)
        {
            bool find = false;

            char[] CharArray = word.ToCharArray();

            for (int i = 0; i < CharArray.Length - 1; i++)
            {
                if (CharCheck(CharArray[i], CharArray[i + 1]))
                {
                    Output += " True";
                    find = true;
                    break;
                }
            }
            if (!find)
            {
                Output += " False";
            }
        }

        foreach (string word in SplitedText)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine($"\n\n{Output.Trim()}");
        Console.ReadKey();
    }
}