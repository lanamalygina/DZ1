Console.WriteLine("Программа принимает число (N) и показывает все чётные числа от 1 до N.");
Console.WriteLine("Введите число: ");
int h = int.Parse(Console.ReadLine());
int startNumber = 1;
int i = 0;
for (i = startNumber; i <= h; i++) {
    if(i % 2 == 0){
        Console.WriteLine("Четное число: "+ i);
    }
}