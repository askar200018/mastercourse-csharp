
// ********** PRO TIP ***********
// Use events to let others know about state change
// or other significant events.

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