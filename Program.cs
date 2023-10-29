// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Linq;

public class program
{
    static void Main()
    {

        Console.WriteLine("Bir cümle yazınız.");
        string input = Console.ReadLine();
        

        SwapLetter( input);

        Console.ReadLine();
        
    }


    static void SwapLetter(string text)
    {
        string[] words = text.Split(' ');

        string vowel = "z, y, v, t, ş, s, r, p, n, r, m, l, k, h, j, ğ, g, d, ç, c, b";


        foreach (var item in words)
        {
            bool result = false;

            for (int i = 0; i < item.Length-1; i++)
            {
                if (vowel.Contains(item[i].ToString ()) && vowel.Contains(item[i+1].ToString()))
                {
                    result = true;
                    break;
                }
               
            }
            Console.Write(result + " " );
        }
      
    
    }
}

