
namespace taskchanged3.models;

internal class Group
{
    public string groupno { get; set; }
    public int limit { get; }
    private Student[] _students { get; set; }
    private int _count;

    public Group(string Groupno,int Limit)
    {
        groupno = Groupno;
        limit = Limit;
        _students = new Student[Limit];
        _count = 0;
    }
    public void AddStudent(Student student)
    {
        if (_count >= limit)
        {
            Console.WriteLine($"qrubdaki teleber:{groupno} {student.Name} telebeden basqa secilmir");
            return;
        }
        _students[_count] = student;
        _count++;
    }
    public void Getstudents()
    {
        for(int i=0; i< _count;i++)
        {
            Console.WriteLine($"{_students[i].Name}{_students[i].Surname}");
        }
    }
}
