/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
using static System.Console;
Clear();
void Cube(int num){
    int index = 1;
    while(index<=num)
    {
        Write(index*index*index + ", ");
        index++;
    }
}
Write("Введите число: ");
int num = Convert.ToInt32(ReadLine()!);
if (num <= 0) Write("Неверные данные");
else Cube(num);