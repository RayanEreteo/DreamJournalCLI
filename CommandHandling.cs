class CommandHandling
{
    public static void CommandInit(string command, string[] args)
    {
        switch (command)
        {
            case "donate":
                // Open browser to ko-fi link for donation.
                CommandActions.Donate();
                return;
            case "change":
                string flag = Helpers.FlagRequired(args);

                CommandActions.Change(flag);
                return;
            default:
                // Exit with a message if invalid command.
                Console.WriteLine("Invalid Command");
                return;
        }
    }
}