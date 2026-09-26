namespace PolymorphismMethodOverloading;

class Patient
{
    public string Register(string name)
    {
        return $"{name} is here";
    }
    public string Register(string name,int age)
    {
        return $"{name} is {age} years old";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Patient patient = new Patient();
        Console.WriteLine(patient.Register("Dennis"));
        Console.WriteLine(patient.Register("Dennis",22));
    }

}