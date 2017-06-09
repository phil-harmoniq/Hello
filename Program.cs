using System;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using ConsoleColors;

namespace ArgTest
{
    class Program
    {
        public static bool IsWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        public static bool IsMacOS = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
        public static bool IsLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        public static string Info = RuntimeInformation.OSDescription;
        public static string OS = GetOSTag();

        static void Main(string[] args)
        {
            Clr.WriteLine(string.Format("\n------------ Hello from {0}{2}C#{3}/{1}{2}.NET Core{3}! ------------",
                Clr.Magenta,
                Clr.Cyan,
                Clr.Bold,
                Clr.Reset
            ));
            Clr.WriteLine($"Looks like you're using {Clr.Green}{Clr.Bold}{OS}{Clr.Reset}! More detailed info:");
            Clr.WriteLine($"{Info}");
            if (args.Length > 0)
                Clr.WriteLine($"Arguments detected: {string.Join(", ", args)}");
            Clr.WriteLine("--------------------------------------------------\n");
        }

        public static string GetOSTag()
        {
            if (IsWindows) return "Windows";
            if (IsMacOS) return "macOS";
            if (IsLinux) return "Linux";
            return "Unknown";
        }
    }
}
