// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.
// Для остальных чисел вернуть True или False.
// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное

Console.WriteLine ("Введите пятизначное число: ");
string number = Console.ReadLine();
int plnd = number.Length;

if (plnd == 5)
{
    if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine(number + " Это число палиндромом");
    }

    else
    {
        Console.WriteLine(number + " Это число не палиндром");
    }
}
else
{
    Console.WriteLine ("Вы ввели не пятизначное число!");
}