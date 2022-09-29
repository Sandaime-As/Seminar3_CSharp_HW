/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
using static System.Console;
Clear();
void Palindrom(int n){
    string num = Convert.ToString(n);
    if (num[0] == num[4] & num[1] == num[3]) WriteLine("Да");
    else WriteLine("Нет");
}
Write("Введите пятизначное число: ");
int num = Convert.ToInt32(ReadLine()!);
if (num <= 99999 & num >= 10000) Palindrom(num);
else WriteLine("Неверные данные");