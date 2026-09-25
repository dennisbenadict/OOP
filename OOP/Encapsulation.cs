namespace Encapsulation;

class Patient
{
    public string Name { get; set; }
    private int Age;
    public int SetAge
    {
        get
        {
            return Age;
        }
        set
        {
            if(value<0 || value > 25)
            {
                throw new ArgumentException("Age must be between 0 and 25");
            }
            else
            {
                Age = value;
            }
        }
    }
    public string Display()
    {
        return $"{Name} is {Age} years old";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Patient patient = new Patient();
        patient.Name = "Dennis";
        patient.SetAge = 26;
        var result=patient.Display();
        Console.Write(result);
    }
}