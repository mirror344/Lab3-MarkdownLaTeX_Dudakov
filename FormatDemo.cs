namespace Lab3_MarkdownLaTeX_Dudakov;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double b = double.Parse(Console.ReadLine());
        double sum = a + b;
        Console.WriteLine($"Результат: {sum}");
    }    
}
