
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

bool gg = true;
int pokusy = 5;

/*
string path = "C:\\Users\\zizkade20\\source\\repos\\hangman\\hangman\\TextFile1.txt";

string readText = File.ReadAllText(path);


int index = rnd.Next(readText.Length);
string randomWord = readText[index];
*/

List<string> slovnik = new List<string> { "abc", "abcd", "abcde", "abcdef" };
int index = rnd.Next(slovnik.Count);
string randomWord = slovnik[index];


List<string> pouzitaPismena = new List<string>();

List<string> abc = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };



do
{
    menu();
    string input = Console.ReadLine().ToLower();

    switch (input)
    {
        case "h":
            while(pokusy > 0)
            {
                Console.WriteLine("Počet životů: " + pokusy);
                foreach (char x in randomWord)
                {
                    Console.Write("_ ");
                }
                Console.WriteLine();
                Console.WriteLine("Hadej pismenko");
                Console.Write("->");
                string guess = Console.ReadLine();
                if (abc.Contains(guess))
                {
                    if (randomWord.Contains(guess[0]))
                    {
                        Console.WriteLine("spravne");
                    } else
                    {
                        pouzitaPismena.Add(guess);
                        Console.Write("pouzita pismena: ");

                        foreach (string p in pouzitaPismena)
                        {
                            Console.Write(p+ " ");
                        }
                        pokusy--;
                        Console.WriteLine();
                    }
                
                }
                
                
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