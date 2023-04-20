using System.Security.Cryptography;
using static System.Console;

Employye Joe = new Employye("Joe", "KFC");
Joe.Print();

Research_Associate Ted = new Research_Associate("Ted", "LG", 4);
Ted.Print();



class Person
{
    string _name;

    public Person(string name)
    {
        _name = name;  
    }
    public string Name
    {
        get { return _name; }
        set {  
                try
                {
                    _name = value;
                }
                catch (Exception ex)
                {
                    WriteLine($"Ошибка: {ex.Message}");
                }
            }
    }
    public virtual void Print()
    {
        WriteLine(Name);
    }
}
class Employye:Person//указываем, что он потомок класса Person
{
    public string Company { get; set; }
    public Employye(string name, string company):base(name)//слово base отсылает нас к родительскому конструктору
    {
        Company = company;
    }
    public sealed override void Print()
    {
        base.Print();
        WriteLine(Company);
    }
}

class Student:Person
{
    public string Specialization { get; set; }
    public string Years_of_study { get; set; }
    public Student(string name, string spec, string years):base(name)
    {
        Specialization = spec;
        Years_of_study = years;
    }

    public override void Print()
    {
        base.Print();
        WriteLine(Specialization);
        WriteLine(Years_of_study);
    }
}

class Teacher: Person
{
    public string Subject_of_teaching { get; set; }

    public Teacher(string name, string Subject):base(name)
    {
        Subject_of_teaching = Subject;
    }

    public override void Print()
    {
        base.Print();
        Write(Subject_of_teaching);
    }

}

class Research_Associate: Employye
{
    public int Work_experience { get; set; }
    public Research_Associate (string name, string comp, int work_ex) : base(name, comp)
    {
        Work_experience = work_ex;
    }
    public new void Print()
    {
        base.Print();
        WriteLine(Work_experience);
    }
}