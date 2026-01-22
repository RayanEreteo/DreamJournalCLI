using System.Diagnostics;

class CommandActions
{
    public static void Donate()
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = "https://ko-fi.com/rayanereteo",
            UseShellExecute = true,
        });
    }
}