class CommandHandling
{
    public static void CommandInit(string command)
    {
        switch (command)
        {
            case "donate":
                // Open browser to ko-fi link for donation.
                CommandActions.Donate();
                return;
            default:
                // Exit with a message if invalid command.
                Console.WriteLine("Invalid Command");
                return;
        }
    }
}