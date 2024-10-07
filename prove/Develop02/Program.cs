using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        List<string> menu = new List<string> {"Write","Display","Load","Save","Quit"};
        int menuInput = 0;
        Journal journal = new Journal();
        void displayMenu(){
            System.Console.WriteLine("What would you like to do?");
            int index = 0;
            foreach(string item in menu){
                index +=1;
                System.Console.WriteLine($"{index}. {item}");
            }
        }
        void handleMenu(){
            while(menuInput != 5){
                menuInput = 0;
                displayMenu();
                menuInput = int.Parse(Console.ReadLine());
                if(menuInput == 1){
                    journal.inputEntry();
                }else if(menuInput == 2){
                    journal.displayJournal();
                }else if(menuInput == 3){
                    System.Console.WriteLine("Do you have unsaved entries? (y/n): ");
                    string confirm = Console.ReadLine();
                    if(confirm.ToLower() == "n"){
                        journal.readEntries();
                    }else{
                        System.Console.WriteLine("Okay, save your entries before loading an old file!");
                        menuInput = 2;
                    }
                }else if(menuInput == 4){
                    journal.writeEntries();
                }
            }
        }
        handleMenu();
    }
}