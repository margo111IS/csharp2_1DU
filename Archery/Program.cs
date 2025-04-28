using Archery;

public class Program
{
    public static void Main()
    {
        int number = 0;
        var archer = new Archer("Archer1", 2);
        while (true)
        {
            bool flag = true;
            archer.ShowState();

            while (flag)
            {
                try
                {
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1. Fire arrow \n2. Add arrows \n3. End");
                    Console.Write("Option: ");
                    number = int.Parse(Console.ReadLine());
                    if (number < 1 || number > 3)
                    {
                        Console.WriteLine("Invalid option! Try again.");
                    }
                    else
                    {
                        flag = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
            switch (number)
            {
                case 1:
                    archer.Fire();
                    break;

                case 2:
                    Console.Write("Write a valid number of arrows to add: ");
                    ReadWholeNumberFromConsole(Console.ReadLine(), archer);
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("\nInvalid option! Try again.");
                    break;
            }
        }
    }


    public static void ReadWholeNumberFromConsole(string call, Archer archer)
    {
        bool flag = true;
        while (flag)
        {
            if (int.TryParse(call, out int input))
            {
                if (input >= 0)
                {
                    archer.AddArrows(input);
                    flag = false;
                }
                else
                {
                    Console.WriteLine("The given number is less than zero! Try again.");
                }
            }
            else
            {
                Console.WriteLine("The given number is not valid! Try again.");

            }

            if (flag)
            {
                Console.Write("Write a valid number of arrows to add: ");
                call = Console.ReadLine();
            }
        }
    }
}

