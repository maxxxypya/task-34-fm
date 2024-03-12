using System;


class StrGen : IElGen<string>
{
    private const string alphabet = "abcdefghijklmnopqrstuvwxyz";
    private static Random random = new Random();
    public string GenRandom()
    {
        int length = random.Next(0, 10);
        string a = "";
        for (int i = 0; i < length; i++)
        {
            a += alphabet[random.Next(0, 26)];
        }
        return a;
    }

    public string InputElements()
    {
        string message = Convert.ToString(Console.ReadLine());
        return message;
    }
}
