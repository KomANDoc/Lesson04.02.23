using static System.Console;

WriteLine(Operations.Add(5, 6));
WriteLine(Operations.Sub(5, 6));
WriteLine(Operations.Mul(5, 6));
static class Operations
{
    public static int Add(int x, int y) => x + y;
    public static int Sub(int x, int y) => x - y;
    public static int Mul(int x, int y) => x * y;
}