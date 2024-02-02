
// ********** PRO TIP ***********
// Use events to let others know about state change
// or other significant events.

class Program
{
    public static void Main(string[] args)
    {
        CollegeClassModel history = new CollegeClassModel("History 101", 3);
        CollegeClassModel math = new CollegeClassModel("Math 201", 2);

        history.EnrollmentFull += CollegeClass_EnrollmentFull;
        history.EvenStudents += CollegeClass_EvenStudent;

        history.SignUpStudent("Tim Corey").PrintToConsole();
        history.SignUpStudent("Sue Smith").PrintToConsole();
        history.SignUpStudent("Jonm Stones").PrintToConsole();
        history.SignUpStudent("Kary Petty").PrintToConsole();
        history.SignUpStudent("Sanda Shmeichel").PrintToConsole();

        math.EnrollmentFull += CollegeClass_EnrollmentFull;
        math.EvenStudents += CollegeClass_EvenStudent;


        math.SignUpStudent("Sue Smith").PrintToConsole();
        math.SignUpStudent("Jonm Stones").PrintToConsole();
        math.SignUpStudent("Kary Petty").PrintToConsole();

    }

    private static void CollegeClass_EvenStudent(object sender, string e)
    {
        System.Console.WriteLine();
        System.Console.WriteLine(e);
        System.Console.WriteLine();
    }

    private static void CollegeClass_EnrollmentFull(object sender, string e)
    {
        CollegeClassModel model = (CollegeClassModel)sender;

        System.Console.WriteLine();
        System.Console.WriteLine($"{model.CourseTitle}: full");
        System.Console.WriteLine();
    }
}

public static class ConsoleHelper
{
    public static void PrintToConsole(this string message)
    {
        System.Console.WriteLine(message);
    }
}

public class CollegeClassModel
{

    public event EventHandler<string> EnrollmentFull;
    public event EventHandler<string> EvenStudents;
    private List<string> enrolledStudents = new List<string>();
    private List<string> waitingStudents = new List<string>();

    public string CourseTitle { get; private set; }
    public int MaximumStudents { get; private set; }

    public CollegeClassModel(string title, int maximumStudents)
    {
        CourseTitle = title;
        MaximumStudents = maximumStudents;
    }

    public string SignUpStudent(string studentName)
    {
        string output = "";
        if (enrolledStudents.Count < MaximumStudents)
        {
            enrolledStudents.Add(studentName);
            output = $"{studentName} was enrolled in {CourseTitle}";
            if (enrolledStudents.Count == MaximumStudents)
            {
                EnrollmentFull?.Invoke(this, $"{CourseTitle} is full");
            }

            if (enrolledStudents.Count % 2 == 0)
            {
                EvenStudents?.Invoke(this, $"{studentName} is even student");
            }
        }
        else
        {
            waitingStudents.Add(studentName);
            output = $"{studentName} was added in waiting list {CourseTitle}";

        }
        return output;
    }
}