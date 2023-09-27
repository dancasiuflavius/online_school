using online_school.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        ServiceCourse service = new ServiceCourse();
        service.ReadCourses();
    }
}