using System.Data;
using System.Numerics;
string[] Matrix(int n)
{
    string[] strArr = new string[n];
    for (int i = 0; i < n; i++)
    {
    strArr[i] = Console.ReadLine()!;
    }
    return strArr;
}

void PrintMatrix (string[] strArr)
{
    for (int i = 0; i < strArr.Length; i++)
    Console.Write($"\"{strArr[i]}\"  ");
}


string[] Filtr (int n, string[] strArr)
{
 string[] Arr = new string[n];
 for (int i = 0; i < n; i++) 
 {
    if (strArr[i].Length < 4)
    
    Arr[i] = strArr[i];
    
    Console.Write($"\"{Arr[i]}\" ");
 }
  return Arr;
 }


Console.WriteLine("Введите количество строк");
int n = int.Parse(Console.ReadLine()!);
string[] kool = Matrix(n);
PrintMatrix(kool);
Console.Write("->  ");
Console.WriteLine(Filtr(n, kool));