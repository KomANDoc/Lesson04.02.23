using static System.Console;


//псевдонимы

using cout = System.Console;
using User = Person;
cout.WriteLine("Hello world");
User ted = new User("Ted");
cout.WriteLine(ted.Name);




class Person
{
    public string Name { get; set; }   

    public Person(string name)=> Name = name;
}