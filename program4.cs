//Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами.
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).
// Реализовать  через функции. (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог 
 //случайных значений”, “Введите максимальный порог случайных значений”)

//Задача *: Напишите программу, которая из массива случайных чисел.
 //Ищет второй максимум (число меньше максимального элемента, но больше всех остальных).
 // Сделать одним циклом


int [] abc =fillArray(
                        inputInt ("размерности массива "),
                        inputInt ("мин порога случайных значений"),
                        inputInt ("макс порога случайных значений ")
                    );
Console.Write("Заполненный массив :");                    
printArray(abc);
findMaxArray(abc);

    

int inputInt (string n){
    Console.WriteLine("Введите число "+ n + ":");
    string a = Console.ReadLine();
    return Convert.ToInt32(a);
    
}

int [] fillArray (int n ,int min,int max){
Random random = new Random();
    int []array =new int [n];
    for(int i =0;i<n;i++){
        array[i]=random.Next(min,max);
    }
    return array;
}

int [] printArray (int [] array ){

    for(int i =0;i<array.Length;i++){
        Console.Write(array [i]+" ");
    }
    return array;
}

void findMaxArray (int [] array ){
    Console.Write("\n");
    int temp=0;
    int count =0;
    while(true){
    for(int i =0;i<array.Length-1;i++){
        temp=array[i+1];
        if (array[i]>array[i+1]){
array[i+1]=array[i];
array[i]=temp;
count++;
        }
    }
    if(count!=0){count=0;continue;}
    else{break;}


    }
    Console.WriteLine("Максимальный элемент = "+ array[array.Length-1]);
   Console.WriteLine("Второй максимальный элемент = "+ findSecondMax(array));
   
}

int findSecondMax (int [] array){
     for(int i=array.Length-2;i>=0;i--){
if(array[i]<array[array.Length-1]){
  return array[i]; 
}
    }
    return array[0];
}
