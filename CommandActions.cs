using System.Diagnostics;

class CommandActions
{
    // Open browser to my ko-fi page 
    public static void Donate()
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = "https://ko-fi.com/rayanereteo",
            UseShellExecute = true,
        });
    }

    public static void Change(string flag)
    {
        Console.WriteLine(flag);
    }
}