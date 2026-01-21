class DreamJournalCLI
{
    static void Main(string[] args)
    {
        // If no arguments, show the guide explaining all the commands.
        if (args.Length == 0)
        {
            Guide.ShowGuide();
            return;
        }

        // Get the main command from the user.
        string command = args[0];

        CommandHandling.CommandInit(command);
    }
}