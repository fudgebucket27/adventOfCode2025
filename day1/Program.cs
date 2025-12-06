class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0 && args[0] == "2")
            Part2.Run();
        else
            Part1.Run();
    }
}