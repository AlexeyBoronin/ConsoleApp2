using static System.Console;
//void Sum(in int initValue, params int[] numbers)
//{
//    int result = initValue;
//    foreach (var n in numbers)
//        result += n;
//    WriteLine(result);
//}
//int[] nums = { 1, 2, 3, 4, 5 };
//Sum(10,nums);
//Sum(1, 2, 3, 4);
//Sum(1, 2, 3);
//Sum(20);
//void Sum(int[] numbers,in int initValue )
//{
//    int result = initValue;
//    foreach (var n in numbers)
//        result += n;
//    WriteLine(result);
//}
//int[] nums = { 1, 2, 3, 4, 5 };
//Sum(nums, 10);
//int Factorial(int n)
//{
//    if(n==1) return 1;
//    return n*Factorial(n-1);
//}
//int factorial4=Factorial(4);
//int factorial5=Factorial(5);
//int factorial6=Factorial(6);
//WriteLine($"Факториал числа 4 = {factorial4}");
//WriteLine($"Факториал числа 5 = {factorial5}");
//WriteLine($"Факториал числа 6 = {factorial6}");
//void Fibonachi(in int count,in int[] numbers)
//{
//    numbers[0] = 1;
//    numbers[1] = 1;
//    for(int i = 2; i < count; i++)
//        numbers[i] = numbers[i - 1]+numbers[i-2];
//}

//void print(in int[] numbers,in int count)
//{
//    for(int i = 0; i < count;i++)
//        Write($"{numbers[i]} ");
//}
//int Count1 = 20;
//int[] numbers=new int[Count1];
//Fibonachi(Count1, numbers);
//print(numbers,Count1);
//void Compare(int[] numbers1, int[] numbers2)
//{
//    int numbers1Sum=Sum(numbers1);
//    int numbers2Sum=Sum(numbers2);
//    if (numbers1Sum > numbers2Sum)
//        WriteLine("Сумма чисел из первого массива больше");
//    else if (numbers1Sum < numbers2Sum)
//        WriteLine("Сумма чисел из второго массива больше");
//    else
//        WriteLine("Сумма чисел массивов равна");
//    int Sum(int[] numbers)
//    {
//        int resualt = 0;
//        foreach (int number in numbers)
//            resualt += number;
//        return resualt;
//    }
//}
//int[] number1 = { 1, 2, 3 };
//int[] number2 = {3,6,9,10 };
//Compare(number1, number2);
//int Sum(int[] numbers)
//{
//    int limit = 0;
//    int result = 0;
//    foreach (int number in numbers)
//    {
//        if (Ispassed(number,limit)) result += number;
//    }
//    return result;
//   static bool Ispassed(int number,int lim)
//    {
//        return number > lim;
//    }
//}
//int[] numbers1 = { -3, -2, -1, 0, 1, 2, 3 };
//int[] numbers2 = { 3, -4, 5, -6, 7 };
//WriteLine(Sum(numbers1));
//WriteLine(Sum(numbers2));
//int DoOperation(int op, int a, int b)
//{
//    switch (op)
//    {
//        case 1: return a + b;
//        case 2: return a-b;
//        case 3: return a*b;
//        default: return 0;
//    }
//}
//WriteLine(DoOperation(1, 2, 3));
//WriteLine(DoOperation(2, 3, 4));
//WriteLine(DoOperation(3, 4, 5));
//WriteLine(DoOperation(4, 5, 6));
DoOperation(10, 5, Operation.Add);
DoOperation(10, 5, Operation.Subctract);
DoOperation(10, 5, Operation.Mutiply);
DoOperation(5, 6, Operation.Divide);
void DoOperation( double a, double b,Operation op)
{
    double result=  op switch
    {
        Operation.Add => a + b,
        Operation.Subctract => a - b,
        Operation.Mutiply => a * b,
        _=>0
    };
    WriteLine(result);
}
enum Operation
{ Add,Subctract,Mutiply,Divide }


