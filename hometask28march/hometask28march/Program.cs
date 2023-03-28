// See https://aka.ms/new-console-template for more information
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        #region MyRegion
        string[] aylar_otuzbir = { "Yanvar", "Mart", "May", "Iyul", "Avqust", "Oktyabr", "Dekabr" };
        string[] aylar_otuz = { "Aprel", "Iyun", "Sentyabr", "Noyabr" };
        string[] fevral = { "fevral" };
        string input = Console.ReadLine();
        foreach (var item in fevral)
        {
            if (input==item)
            {
                Console.WriteLine("ayin 28 ve ya 29 gunu var");
            }
        }

        foreach (var item in aylar_otuzbir)
        {
            if (input == item)
            {
                Console.WriteLine("ayin 31 gunu var");

            }

        }
        foreach (var item in aylar_otuz)
        {
            if (input == item)
            {
                Console.WriteLine("ayin 30 gunu var");

            }

        }
    }
}
#endregion


