namespace AbstractionAbstractClass;

abstract class IPatient
{
    public abstract string Register(string name,int age);
}

class Patient : IPatient
{
    public override string Register(string name,int age)
    {
        return $"{name} is {age} years old";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        IPatient patient = new Patient();
        var result = patient.Register("Dennis", 22);
        Console.WriteLine(result);
    }
}