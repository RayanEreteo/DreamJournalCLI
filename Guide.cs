class Guide
{
    public static void ShowGuide()
    {
        Console.WriteLine("Dream Journal CLI\n");
        Console.WriteLine("=================\n\n");

        Console.WriteLine("USAGE:\n");
        Console.WriteLine("  command [options] [arguments]\n\n");

        Console.WriteLine("COMMANDS:\n");

        Console.WriteLine("  add <title> <content> <lucid>\n");
        Console.WriteLine("    Add a new dream entry to the journal.\n");
        Console.WriteLine("    - title   : String (use quotes if it contains spaces)\n");
        Console.WriteLine("    - content : String (use quotes if it contains spaces)\n");
        Console.WriteLine("    - lucid   : Boolean (true or false)\n");
        Console.WriteLine("    Example:\n");
        Console.WriteLine("      add \"Flying Dream\" \"I was flying over a city\" true\n\n");

        Console.WriteLine("  remove <title>\n");
        Console.WriteLine("    Remove a dream entry by its title.\n");
        Console.WriteLine("    Example:\n");
        Console.WriteLine("      remove \"Flying Dream\"\n\n");

        Console.WriteLine("  journal\n");
        Console.WriteLine("    Display all journal entries.\n\n");

        Console.WriteLine("  journal -limit <number>\n");
        Console.WriteLine("    Display the last <number> of entries.\n");
        Console.WriteLine("    Example:\n");
        Console.WriteLine("      journal -limit 5\n\n");

        Console.WriteLine("  change -path <path>\n");
        Console.WriteLine("    Set the folder where the journal is saved.\n");
        Console.WriteLine("    Example:\n");
        Console.WriteLine("      change -path C:\\\\DreamJournal\n\n");

        Console.WriteLine("  change -startup-launch <Y/N>\n");
        Console.WriteLine("    Enable or disable launch on Windows startup.\n");
        Console.WriteLine("    Example:\n");
        Console.WriteLine("      change -startup-launch Y\n\n");

        Console.WriteLine("  donate\n");
        Console.WriteLine("    Open the Ko-fi donation page in your browser.\n");
    }
}