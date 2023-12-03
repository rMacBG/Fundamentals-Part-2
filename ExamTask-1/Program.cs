namespace ExamTask_1
{/*
//Thi5 I5 MY 5trING!//
Translate 5 s
Includes string
Start //This
Lowercase
FindIndex i
Remove 0 10
End
  */

    /*
*S0ftUni is the B3St Plac3**
Translate 2 o
Includes best
Start the
Lowercase
FindIndex p
Remove 2 7
End
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();
                string command = arguments[0];
                if (command == "Translate")
                {
                    string charToReplace = arguments[1];
                    string replacement = arguments[2];

                    str = str.Replace(charToReplace, replacement);

                    Console.WriteLine(str);
                }
                else if (command == "Includes")
                {
                    string containedSubstring = arguments[1];
                    bool ifExists = false;
                    if (str.Contains(containedSubstring))
                    {
                        ifExists = true;
                        Console.WriteLine(ifExists);
                    }
                    else
                    {
                        Console.WriteLine(ifExists);
                    }
                    
                }
                else if (command == "Start")
                {
                    string startingString = arguments[1];

                    bool ifStarts = false;
                    if (str.Contains(startingString))
                    {
                        ifStarts = true;
                        Console.WriteLine(ifStarts);
                    }
                    else
                    Console.WriteLine(ifStarts);
                }
                else if (command == "Lowercase")
                {
                    str = str.ToLower();
                    Console.WriteLine(str);
                }
                else if (command == "FindIndex")
                {
                    string searchedChar = arguments[1];
                    int lastIndexOf = str.LastIndexOf(searchedChar);
                    Console.WriteLine(lastIndexOf);
                }
                else if (command == "Remove")
                {
                    int startIndex = int.Parse(arguments[1]);
                    int count = int.Parse(arguments[2]);

                    str = str.Remove(startIndex, count);
                    Console.WriteLine(str);
                }
            }
            Console.WriteLine(str);
        }
    }
}