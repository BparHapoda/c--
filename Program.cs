//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать через функции.

while (true){
Console.WriteLine (intPow(inputInt ("A"),inputInt("B")));
}


double intPow (int a,int b) {
    return Math.Pow (a,b);
}

int inputInt (string   n){
    Console.WriteLine("Введите число "+ n + ":");
    string a = Console.ReadLine();
    return Convert.ToInt32(a);
}
