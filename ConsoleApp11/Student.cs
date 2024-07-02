using System.Collections;

namespace ConsoleApp11;

public class Student:IEnumerable<int>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public List<int> Scores { get; set; }
    public Student(string name, string surname, List<int> scores)
    {
        Name = name;
        Surname = surname;
        Scores = scores;
    }
    public Student()
    {
       
    }
    public IEnumerator<int> GetEnumerator()
    {
        foreach (var item in Scores) yield return item;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
