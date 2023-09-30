// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summa(int A)
{
int Res=A;
int Summ=0;
while (Res>0)
{
    int Dig=Res%10;
Summ=Summ+Dig;
    Res=Res/10;
}
Console.WriteLine(Summ);
return Summ;
}
Summa(452);
