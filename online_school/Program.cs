using online_school.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        ServiceStudent service = new ServiceStudent();
        service.ShowStudents();
    }
}