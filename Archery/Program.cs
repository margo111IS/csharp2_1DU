using Archery;

public class Program
{
    public static void Main()
    {
        var archer = new Archer("Archer1", 2);
        while (true)
        {
            archer.ShowState();
            Console.WriteLine("Choose an option:");
            try
            {
                Console.WriteLine("1. Fire arrow \n2. Add arrows \n3. End");
                Console.Write("Option: ");
                string? option = Console.ReadLine();
                int number = int.Parse(option);
                if (number != null && number > 0)
                {
                    switch (number)
                    {
                        case 1:
                            archer.Fire();
                            break;

                        case 2:
                            int result;
                            while (true)
                            {
                                Console.Write("Write a valid number of arrows to add: ");
                                string count = Console.ReadLine();
                                result = Program.ReadWholeNumberFromConsole(count);
                                if (result >= 0)
                                {
                                    archer.AddArrows(result);
                                    break;
                                }
                            }
                            break;

                        case 3:
                            return;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public static int ReadWholeNumberFromConsole(string call)
    {
        if (int.TryParse(call, out int input))
        {
            if (input >= 0)
            {
                return input;
            }
            Console.WriteLine("The given number is less than zero! Try again.");
            return -1;
        }
        else
        {
            Console.WriteLine("The given number is not valid! Try again.");
            return -1;
        }
    }
}
