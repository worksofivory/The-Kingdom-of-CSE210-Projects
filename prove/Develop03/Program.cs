using System;

class Program
{
    static void Main(string[] args)
    {
        // List<string> testList = new List<string>
        // {
        //     "this", "that", "went"
        // };
        // Content test = new Content(testList);
        // test.displayWords();
        // test.changeWord(2);
        // test.displayWords();
        Content initialVerse = new Content("Adam fell that men might be; and men are, that they might have joy.");
        Reference initialRef = new Reference("2 Nephi", 2, 25, 0);
        Scripture first = new Scripture(initialRef, initialVerse);
        string menuInput = "";
        string trueInput ="";
        first.displayScripture();
        while(trueInput != "quit"){
            Console.Clear();
            first.displayScripture();
            System.Console.WriteLine("Press enter to remove a word, press R to reset, or enter quit to exit!");
            menuInput = Console.ReadLine();
            trueInput = menuInput.ToLower();
            if(trueInput == "r"){
                first.resetScripture();
            }else if(trueInput!="quit"){
                first.removeWord();
            }
        }
    }
}