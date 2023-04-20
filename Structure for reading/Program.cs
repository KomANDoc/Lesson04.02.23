using static System.Console;

//может выдавать ошибку при создание переменной с null
//потому стоит отключать nullable где надо, а потом включать
#nullable disable
string name = null;
char[] chars = null;
#nullable enable

//как проверить null ли 

/*
Print(9);
Print(null);
void Print(int? number)
{
    if(number.HasValue)
        WriteLine(number.Value);
    else
        WriteLine("параметр равен null");
}
 */

string? text = null;
string name1 = text ?? "Не определено";
WriteLine(name1);
int? id = null;
int humanid = id ?? 1;
WriteLine(humanid);
text ??= "ivan";
WriteLine(text);
////////

//int? number = null;
//WriteLine(number.Value);
//WriteLine(number);