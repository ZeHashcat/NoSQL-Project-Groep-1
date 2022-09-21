void Main()
{
    bool exit = false;

    do
    {
        Console.WriteLine("Enter command or type ? for list of commands");
        string command = Console.ReadLine();
        exit = ExecuteCommand();
    } while (!exit);
}

bool ExecuteCommand()
{
    return false;
}