public class Resume{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display(){
        System.Console.WriteLine($"{_name}");
        foreach(Job job in _jobs){
            job.Display();
        }
    }
}