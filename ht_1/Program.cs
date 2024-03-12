//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

void PrintNumbers (int n,  int m)
 {  
    if(n < m){
    return;
    }
 PrintNumbers(n-1,m);

 Console.Write($"{n} ");
 }
 PrintNumbers(5,2);