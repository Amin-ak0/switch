
// Amin Ahmadkhah

Console.WriteLine("._. Wellcome to the bank subsidy system ._.");
Console.WriteLine();
Console.WriteLine("Please answer the questions so that we can see if you are eligible for the subsidy or not !!");
Console.WriteLine();



Console.WriteLine("Do you have job ?? (y/n)");
string ch = Console.ReadLine();

switch (ch.ToLower())
{
    case "y":
        Console.WriteLine("Is your monthly income more than 10 million Tomans ?? (y/n)");
        ch = Console.ReadLine();

        switch (ch.ToLower())
        {
            case "y" or "n":
                Console.WriteLine("Are you married ?? (y/n)");
                ch = Console.ReadLine();

                switch (ch.ToLower())
                {
                    case "y":
                        Console.WriteLine("Do you have children ?? (y/n)");
                        ch = Console.ReadLine();

                        switch (ch.ToLower())
                        {
                            case "y":
                                Console.WriteLine("Do you have more than two children ?? (y/n)");
                                ch = Console.ReadLine();

                                switch (ch.ToLower())
                                {
                                    case "y" or "n":
                                        Console.WriteLine("Do you have home ?? (y/n)");
                                        ch = Console.ReadLine();

                                        switch (ch.ToLower())
                                        {
                                            case "y" or "n":
                                                Console.WriteLine("Do you have a car ?? (y/n)");
                                                ch = Console.ReadLine();

                                                switch (ch.ToLower())
                                                {
                                                    case "y":
                                                        Console.WriteLine("You are not eligible for a subsidy!!!");
                                                        break;
                                                    case "n":
                                                        Console.WriteLine("You are eligible for a subsidy!!!");
                                                        break;
                                                }
                                                break;
                                        }
                                        break;
                                }
                                break;
                            case "n":
                                Console.WriteLine("Do you have home ?? (y/n)");
                                ch = Console.ReadLine();

                                switch (ch.ToLower())
                                {
                                    case "y":
                                        Console.WriteLine("Do you have a car ?/ (y/n)");
                                        ch = Console.ReadLine();

                                        switch (ch.ToLower())
                                        {
                                            case "y":
                                                Console.WriteLine("You are not eligible for a subsidy!!!");
                                                break;
                                            case "n":
                                                Console.WriteLine("You are eligible for a subsidy!!!");
                                                break;
                                        }
                                        break;
                                    case "n":
                                        Console.WriteLine("Do you have a car ?/ (y/n)");
                                        ch = Console.ReadLine();

                                        switch (ch.ToLower())
                                        {
                                            case "y" or "n":
                                                Console.WriteLine("You are eligible for a subsidy!!!");
                                                break;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                    case "n":
                        Console.WriteLine("Do you have home ?? (y/n)");
                        ch = Console.ReadLine();

                        switch (ch.ToLower())
                        {
                            case "y":
                                Console.WriteLine("Do you have a car ?? (y/n)");
                                ch = Console.ReadLine();

                                switch (ch.ToLower())
                                {
                                    case "y":
                                        Console.WriteLine("You are not eligible for a subsidy!!!");
                                        break;
                                    case "n":
                                        Console.WriteLine("You are eligible for a subsidy!!!");
                                        break;
                                }
                                break;
                            case "n":
                                Console.WriteLine("Do you have a car ?? (y/n)");
                                ch = Console.ReadLine();

                                switch (ch.ToLower())
                                {
                                    case "y" or "n":
                                        Console.WriteLine("You are eligible for a subsidy!!!");
                                        break;
                                }
                                break;
                        }
                        break;
                }
                break;
        }
        break;

    case "n":
        Console.WriteLine("Are you married ?? (y/n)");
        ch = Console.ReadLine();

        switch (ch.ToLower())
        {
            case "y":
                Console.WriteLine("Do you have children ?? (y/n)");
                ch = Console.ReadLine();

                switch (ch.ToLower())
                {
                    case "y":
                        Console.WriteLine("Do you have more than two children ?? (y/n)");
                        ch = Console.ReadLine();

                        switch (ch.ToLower())
                        {
                            case "y" or "n":
                                Console.WriteLine("Do you have home ?? (y/n)");
                                ch = Console.ReadLine();

                                switch (ch.ToLower())
                                {
                                    case "y" or "n":
                                        Console.WriteLine("Do you have a car ?? (y/n)");
                                        ch = Console.ReadLine();

                                        switch (ch.ToLower())
                                        {
                                            case "y" or "n":
                                                Console.WriteLine("You are eligible for a subsidy!!!");
                                                break;
                                        }
                                        break;

                                }
                                break;
                        }
                        break;
                    case "n":
                        Console.WriteLine("Do you have home ?? (y/n)");
                        ch = Console.ReadLine();

                        switch (ch.ToLower())
                        {
                            case "y":
                                Console.WriteLine("Do you have a car ?? (y/n)");
                                ch = Console.ReadLine();

                                switch (ch.ToLower())
                                {
                                    case "y":
                                        Console.WriteLine("You are not eligible for a subsidy!!!");
                                        break;
                                    case "n":
                                        Console.WriteLine("You are eligible for a subsidy!!!");
                                        break;
                                }
                                break;
                            case "n":
                                Console.WriteLine("Do you have a car ?? (y/n)");
                                ch = Console.ReadLine();

                                switch (ch.ToLower())
                                {
                                    case "y" or "n":
                                        Console.WriteLine("You are eligible for a subsidy!!!");
                                        break;
                                }
                                break;
                        }
                        break;
                }
                break;
            case "n":
                Console.WriteLine("Do you have home ?? (y/n)");
                ch = Console.ReadLine();

                switch (ch.ToLower())
                {
                    case "y":
                        Console.WriteLine("Do you have a car ?? (y/n)");
                        ch = Console.ReadLine();

                        switch (ch.ToLower())
                        {
                            case "y":
                                Console.WriteLine("You are not eligible for a subsidy!!!");
                                break;
                            case "n":
                                Console.WriteLine("You are eligible for a subsidy!!!");
                                break;
                        }
                        break;
                    case "n":
                        Console.WriteLine("Do you have a car ?? (y/n)");
                        ch = Console.ReadLine();

                        switch (ch.ToLower())
                        {
                            case "y" or "n":
                                Console.WriteLine("You are eligible for a subsidy!!!");
                                break;
                        }
                        break;
                }
                break;
        }
        break;

    default:
        Console.WriteLine("Not acceptable character!!!");
        break;
}




