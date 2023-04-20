using static System.Console;


Calculator calc = new Calculator();
calc.Add(3,5);
calc.Add(6,2,5);
calc.Add(3,8,5,12);
calc.Add(4.6,7.21);




//перегрузка методов
class Calculator
{
    public void Add(int a, int b)
    {
        int result = a + b;
        Write(result);
    }
    public void Add(int a, int b, int c)
    {
        int result = a + b + c;
        WriteLine(result);
    }
    public void Add(int a, int b, int c, int d)
    {
        int result = a + b + c + d;
        WriteLine(result);
    }
    public void Add(double a, double b)
    {
        double result = a + b;
        WriteLine(result);
    }
}