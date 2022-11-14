Console.WriteLine("VÍTEJ VE HŘE HANGMAN\n\nstiskni enter");
Console.ReadLine();
/*
file.readalltext
*/


void menu()
{
    Console.WriteLine("(H)Hrát\n(Z)ebricek\n(S)tatistika\n(N)Nápověda\n(E)Exit");
    Console.Write("->");
}

/*
void slovnikos()
{
    string slovo = "jahoda";
    char[] charArr = slovo.ToCharArray();
    foreach (char ch in charArr)
    {

        Console.Write(ch + " ");
    }
    Console.WriteLine();
}
*/

Random rnd = new Random();
int n = rnd.Next(5, 20);

bool gg = true;
int pokusy = 5;

List<string> slovnik = new List<string> { "jahoda", "brambor", "kocka", "houba" };
int index = rnd.Next(slovnik.Count);
string randomWord = slovnik[index];

do
{
    
    menu();
    string input = Console.ReadLine().ToLower();

    switch (input)
    {
        case "h":
            while(pokusy > 0)
            {
                foreach (char x in randomWord)
                {
                    Console.Write("_ ");
                }
                Console.WriteLine();
                Console.WriteLine("Hadej pismenko");
                Console.Write("->");
                string guess = Console.ReadLine();
                
                
            }
            Console.WriteLine("\nPROHRÁL JSI\n");
            break;


        case "z":
            break;
        case "s":
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