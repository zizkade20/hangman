
char[] StringToCharArray(string s)
{
    char[] arr = new char[s.Length];

    if (s.Length > 0)
    {
        for (int i = 0; i < s.Length; i++)
        {
            arr[i] = s[i];
        }
    }
    return arr;
}


Random rnd = new Random();
int n = rnd.Next(5, 20);

bool gg = true;
Console.WriteLine("VÍTEJ VE HŘE HANGMAN\n\nstiskni enter");
Console.ReadLine();

do
{
    

    Console.WriteLine("Menu:\n(H)Hrát\n(N)Nápověda\n(E)Exit");
    Console.Write("->");
    string input = Console.ReadLine().ToLower();

    switch (input)
    {
        case "h":
            Console.WriteLine(StringToCharArray("jablicko"));   
            break;
        case "n":
            Console.WriteLine("Toto je nápověda");
            Console.ReadLine();
            break;
        case "e":
            Console.WriteLine("EXITING NOW...");
            gg = false;
            break;
        default:
            Console.WriteLine("vyber z nabídky\n");
            break;
    }


} while (gg);