using System.Diagnostics;

class CommandHandling()
{
    public static void CommandInit(string command)
    {
        switch (command)
        {
            case "donate":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://ko-fi.com/rayanereteo",
                    UseShellExecute = true,
                });
                return;
            default:
                Console.WriteLine("Invalid Command");
                return;
        }
    }

    private static void CommandActions()
    {
        
    }
}