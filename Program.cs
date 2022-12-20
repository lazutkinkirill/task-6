
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("введите число");
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("число чётное");
        }
        else
        {
            Console.WriteLine("число нечётное");
        }
    }
}