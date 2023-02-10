//start main
string choice = "";
bool displayMenu = true; //priming read
while (displayMenu != false) //while condition
{
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
    choice = Console.ReadLine(); //update read
    switch (choice)
    {
        case "1":
            GetFull();
            PauseAction();
            displayMenu = true;
            break;
        case "2":
            GetPartial();
            PauseAction();
            displayMenu = true;
            break;
        case "3":
            displayMenu = false;
            break;
        default:
            IsValidChoice();
            displayMenu = true;
            break;
    }
}
//end main

//Methods 

static void GetFull()
{
    Console.Clear();
    Random rnd = new Random();
    int rowCount = rnd.Next(3, 10);
    System.Console.WriteLine($"There should be {rowCount} rows");
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j <= i; j++)//update
        {
            Console.Write("O");
        }
        Console.Write("\n");
    }
}


static void GetPartial()
{
    Console.Clear();
    Random row = new Random();
    int rowCount = row.Next(3, 10);
    System.Console.WriteLine($"There should be {rowCount} rows");
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j <= i; j++) //update
        {
            Random fiftyodds = new Random();
            int num = fiftyodds.Next(2);
            if (num == 1)
            {
                System.Console.Write("O");
            }
            else Console.Write(" ");
        }
        System.Console.WriteLine();
    }
}

static void IsValidChoice()
{
    System.Console.WriteLine("Error: Invalid Choice!");
    PauseAction();
}

static void PauseAction()
{
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
}