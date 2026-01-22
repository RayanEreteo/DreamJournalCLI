class Helpers
{
    public static string FlagRequired(string[] args)
    {
        if (args.Length <= 1)
        {
            Console.WriteLine("Flag required for this command.");
            return string.Empty;
        }

        return args[1];
    }
}