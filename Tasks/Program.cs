// Задача 25
//
// int Exponentiation(int a,int b){
//     int res = a;
//     for(int i = 1;i < b;i++){
//         res *= a;
//     }
//     return res;

// }
// Console.WriteLine("Введите число a и b: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Exponentiation(a,b));

// Задача 27
//
// int SumOfNumb(int n){
//     if(n < 0){
//         n *= -1;
//     }
//     int sum = 0;
//     while(n != 0){
//         sum += n % 10;
//         n /= 10;
//     }
//     return sum;
// }
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма элементов числа: {SumOfNumb(a)}");

// Задача 29
//
// string RandomArr(){
//     int [] array = new int [8];
//     string a = "| ";
//     for(int i = 0;i < array.Length;i++){
//         Random random = new Random();
//         array[i] = random.Next(0,1001);
//         a += $" {array[i]} | ";
//     }
//     return a;
    
// }
// Console.WriteLine($"Случайный массив: {RandomArr()}");
