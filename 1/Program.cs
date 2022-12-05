//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Random random = new Random();
int n =random.Next(1,21);
int [] array = new int[n];
fillArray(array);
printArray(array);

void fillArray (int [] array){
for(int i=0;i<array.Length;i++){
    array[i]=random.Next(100,1000);

}


}

void printArray (int [] array){
for(int i=0;i<array.Length;i++){
    Console.Write(array[i]+" ");
}
}
int findNumbers(int [] array){
    
}