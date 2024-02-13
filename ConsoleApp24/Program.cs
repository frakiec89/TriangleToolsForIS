// track
using ConsoleApp24;

Console.WriteLine("я калькулятор  могу  посчитать  площадь треугольника");
while (true)
{
    StratProgramm();
}
static void StratProgramm()
{
    double x1 = GetDoubleForConsole("введите  длинну  стороны  а ");
    double x2 = GetDoubleForConsole("введите  длинну  стороны  b ");
    double x3 = GetDoubleForConsole("введите  длинну  стороны  c ");
    double otvet = TriangleTools.GetSquare(x1, x2, x3);
    Console.WriteLine("площадь  трегольника  равна: " + otvet);
    Console.WriteLine("_____");
}

static double GetDoubleForConsole (string message)
{
    Console.WriteLine(message);
    double x;
    try
    {
        x= Convert.ToDouble(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message); 
        Console.WriteLine("Попробуем еще раз...");
        return GetDoubleForConsole(message);
    }
    return x;
}
