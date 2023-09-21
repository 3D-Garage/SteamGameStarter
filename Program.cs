using System.Diagnostics;

namespace SteamGameStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            LaunchGame();
        }

        static void LaunchGame()
        {
            string steamPath = @"C:\Program Files (x86)\Steam\Steam.exe";
            string appID = "2225070";

            try
            {
                Process.Start(steamPath, "-applaunch " + appID);
                Console.WriteLine($"A játék (AppID: {appID}) elindult.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt a játék indítása közben: {ex.Message}");
            }
        }
    }
}