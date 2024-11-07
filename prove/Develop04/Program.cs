using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> menu = new List<string>{
            "Start Breathing Activity",
            "Start Reflecting Activity",
            "Start Listing Activity",
            "Exit"
        };
        int menuInput=0;
        Breathing breatheActivity = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Listing listActivity = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Reflection reflectActivity = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        int totalDuration =0;
        while(menuInput != 4){
            int index = 0;
            System.Console.WriteLine("Menu Options: ");
            foreach(string item in menu){
                index +=1;
                System.Console.WriteLine($"{index}. {item}");
            }
            System.Console.Write("Select an option from the menu: ");
            menuInput = int.Parse(Console.ReadLine());
            if(menuInput == 1){
                if(breatheActivity.runBreathing().ToLower() == "y"){
                    menuInput = 0;
                    totalDuration += breatheActivity.getDuration();
                    Console.Clear();
                }else{
                    menuInput = 4;
                    totalDuration += breatheActivity.getDuration();
                }
            }
            if(menuInput == 2){
                if(reflectActivity.runReflection().ToLower() == "y"){
                    menuInput = 0;
                    Console.Clear();
                    totalDuration += reflectActivity.getDuration();
                }else{
                    menuInput = 4;
                    totalDuration += reflectActivity.getDuration();
                }
            }
            if(menuInput == 3){
                if(listActivity.runListing().ToLower() == "y"){
                    menuInput = 0;
                    Console.Clear();
                    totalDuration += listActivity.getDuration();
                }else{
                    menuInput = 4;
                    totalDuration += listActivity.getDuration();
                }
            }
            if(menuInput == 4){
                Console.Clear();
                System.Console.WriteLine($"Awesome!  You spent {totalDuration} seconds relaxing this session!  Come back soon :)");
            }
        }
        // Activity test = new Activity("Test", "Test Description");
        // test.setDuration();
        // test.displayTimer(10);
        // test.endActivity();

        // Breathing breathetest = new Breathing("Breathing","That Description");
        // breathetest.runBreathing();
        
        // Listing listtest = new Listing("Listing","That Description");
        // listtest.runListing();

        // Reflection reflecttest = new Reflection("Reflection","That Description");
        // reflecttest.runReflection();
    }
}