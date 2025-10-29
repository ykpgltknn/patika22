using System.Text.RegularExpressions;
public static class Methods
{
    public static string GetSTR()
    {
        string str;
        Console.WriteLine("Enter a sentence or word");
        while (true)
        {
            Console.Write("Text: "); str = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(str))
            {
                return str;
            }
            else
            {
                Console.WriteLine("Please enter a valid text!");
            }
        }
    }

    public static bool CharCheck(char a, char b)
    {
        string Vowels = "[aeıioöuüAEIİOÖUÜ]";
        if (!Regex.IsMatch(a.ToString(), Vowels) && !Regex.IsMatch(b.ToString(), Vowels))
        {
            return true;
        }
        return false;
    }
}