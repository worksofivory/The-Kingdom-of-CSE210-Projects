public class Breathing : Activity{

    public Breathing(string name, string description) : base(name, description){}
    public void startBreathing(){
        System.Console.Write("Breathe in until the timer runs out...");
        displayTimer(4);
    }
    public void stopBreathing(){
        System.Console.Write("Breathe out until the timer runs out...");
        displayTimer(7);
    }
    public string runBreathing(){
        int duration = startActivity();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while(DateTime.Now < endTime){
            startBreathing();
            Console.WriteLine();
            System.Console.Write("Hold");
            Thread.Sleep(1000);
            System.Console.Write(".");
            Thread.Sleep(500);
            System.Console.Write(".");
            Thread.Sleep(500);
            System.Console.WriteLine(".");
            Thread.Sleep(500);
            stopBreathing();
            Console.WriteLine();
        }
        System.Console.WriteLine();
        return endActivity();
        }
}