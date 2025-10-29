namespace AbsoluteSquaring;
class Project
{

    public static void GetAndCalculateValues()
    {
        System.Console.WriteLine("Enter how many numbers you will enter.");
        int n = int.Parse(Console.ReadLine());
        int[] Numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine("Enter {0}.th number ", i + 1);
            Numbers[i] = int.Parse(Console.ReadLine());

        }

        int sumofDifferences = 0;
        double absoluteSquaring = 0;

        for (int i = 0; i < n; i++)
        {
            if (Numbers[i] < 67)
            {
                sumofDifferences += 67 - Numbers[i];
            }
            else
            {
                absoluteSquaring += Math.Pow((Numbers[i] - 67), 2);
            }
        }

        System.Console.WriteLine(sumofDifferences + " " + absoluteSquaring);

    }
}