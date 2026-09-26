namespace PolymorphismMethodOverriding;

class Patient
{
    public virtual string Register(string name)
    {
        return $"{name} is here";
    }
}

class PatientService : Patient
{
    public override string Register(string name)
    {
        return $"{name} is registered";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Patient patient = new PatientService();
        Console.WriteLine(patient.Register("Dennis"));
    }
}
