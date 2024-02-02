
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
