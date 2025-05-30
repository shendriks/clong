using System;
using Clong.Kni.Adapter;

namespace Clong.Kni.DesktopGL;
/// <summary>
/// The main class.
/// </summary>
public static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        using (var game = new MainGame())
            game.Run();
    }
}