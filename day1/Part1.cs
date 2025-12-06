class Part1
{
    public static void Run()
    {
        var input = File.ReadAllLines("input.txt");
        var dialPosition = 50;
        var password = 0;
        foreach (var line in input)
        {
            //Get rotation info
            var rotationDirection = line[0];
            var rotationAmount = Int32.Parse(line.Substring(1, line.Length - 1));

            //ROTATE!
            for (int i = 1; i <= rotationAmount; i++)
            {
                if (rotationDirection == 'L')
                {
                    if (dialPosition == 0)
                    {
                        dialPosition = 99;

                    }
                    else
                    {
                        dialPosition = dialPosition - 1;
                    }
                }
                else
                {
                    if (dialPosition == 99)
                    {
                        dialPosition = 0;
                    }
                    else
                    {
                        dialPosition = dialPosition + 1;
                    }
                }
            }

            if (dialPosition == 0)
            {
                password++;
            }
        }
        Console.WriteLine($"Password {password}");
    }
}

