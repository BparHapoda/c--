//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.

string a = inputInt ("Введите число ");
Console.WriteLine("Cумма цифр = "+ sumNumbers (a));


string sumNumbers (string a) {
if (a.Length==1){return a;}
int number = Convert.ToInt32(a);
int result=0;

    for(int i=0;i<a.Length;i++){
        result=result+number%10;
        number=number/10;

    }
    return Convert.ToString(result);
}

string inputInt (string n){
    Console.WriteLine("Введите число "+ n + ":");
    string a = Console.ReadLine();
    return a;
}
