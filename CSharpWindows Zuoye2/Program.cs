public class Student : IComparable
{
    public double mygrade;
    public string mysubject, myID;
    public Student() { }
    public Student(double grade, string subject, string id)
    {
        mygrade = grade;
        mysubject = subject;
        myID = id;
    }
    //请在此处添加关键代码···
    public int CompareTo(object obj)
    {
        if (obj is Student)
        { 
            Student student = obj as Student;
            //return mygrade.CompareTo(student.mygrade);此代码为默认排序方式，小的排在前面
            //下面代码能把大的排在前面
            if (this.mygrade > student.mygrade)
                return -1;
            else if (this.mygrade < student.mygrade)
                return 1;
            else
                return 0;
        }else
            throw new ArgumentException("比较对象不是Student类");
    }
}

internal class Program
{

    private static void Main(string[] args)
    {
        Student[] students = new Student[5];
        students[0] = new Student(50.0, "windows程序设计", "001");
        students[1] = new Student(90.0, "windows程序设计", "002");
        students[2] = new Student(100.0, "windows程序设计", "003");
        students[3] = new Student(70.0, "windows程序设计", "004");
        students[4] = new Student(80.0, "windows程序设计", "005");
        //请在此处添加关键代码···
        Array.Sort(students);
        Console.WriteLine("下面是成绩由高到低排序:");
        foreach (Student student in students)
        {
            Console.WriteLine("成绩:{0}  课程:{1}  学号: {2}",student.mygrade,student.mysubject,student.myID);
        }
    }
}