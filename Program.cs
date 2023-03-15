//Неявное преобразование простых типов
using System.ComponentModel;

Console.WriteLine("Введите вещественное число: ");
float a = float.Parse(Console.ReadLine());
double b = a;
Console.WriteLine($"double: {b}");

Console.WriteLine("Введите целое число: ");
int c = int.Parse(Console.ReadLine());
double d = c;
float fl = c;
long l = c;
Console.WriteLine($"double: {d}      float: {fl}      long: {l}");

char e = 'e';
int f = e;
long g = e;
/*              Таблица неявных преобразований 
sbyte  ==> short, int, long, float, double, decimal или nint
byte   ==> short, ushort, int, uint, long, ulong, float, double, decimal, nint или nuint
short  ==> int, long, float, double или decimal либо nint
ushort ==> int, uint, long, ulong, float, double или decimal, nint или nuint
int    ==> long, float, double или decimal, nint
uint   ==> long, ulong, float, double или decimal либо nuint
long   ==> float, double или decimal
ulong  ==> float, double или decimal
float  ==> double
char   ==> int, ushort, uint, long, ulong, float, double или decimal
nint   ==> long, float, double или decimal
nuint  ==> ulong, float, double или decimal*/



//Неявное преобразование ссылочных типов

Truck truck = new Truck(1.1m, 2);
Auto auto = truck;
Console.WriteLine($"Количество сидений: {auto.Seats}");

object ob = auto.Seats; // Преобразование от Auto к object

class Auto // легковой автомобиль
{
    public int Seats { get; set; } // количество сидений
    public Auto(int seats)
    {
        Seats = seats;
    }
}
class Truck : Auto // грузовой автомобиль
{
    public decimal Capacity { get ; set; } // грузоподъемность
    public Truck(decimal capacity, int seats) : base(seats)
    {
        Seats = seats;
        Capacity = capacity;
        Console.WriteLine("Truck has been created");
    }
}



