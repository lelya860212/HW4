// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree(int Aint, int Bint)
{
// Console.WriteLine("Введите  число A");
// string A = Console.ReadLine()!;
// int Aint=Convert.ToInt32(A);
// Console.WriteLine("Введите  число B");
// string B = Console.ReadLine()!;
// int Bint=Convert.ToInt32(B);
// Console.WriteLine("Результат равен");
int Res=1;
for (int i = 1; i <=Bint; i++)
{
    Res=Res*Aint;
}
//Console.WriteLine(Res);
return Res;
}
//Degree(3,5);
int D=Degree(3,5);
Console.WriteLine(D);

