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
            Printer.WriteLine(string.Format("\n------------ Hello from {0}{2}C#{3}/{1}{2}.NET Core{3}! ------------",
                Clr.Magenta,
                Clr.Cyan,
                Frmt.Bold,
                Reset.Code
            ));
            Printer.WriteLine($"Looks like you're using {Clr.Green}{Frmt.Bold}{OS}{Reset.Code}! More detailed info:");
            Printer.WriteLine($"{Info}");
            if (args.Length > 0)
                Printer.WriteLine($"Arguments detected: {string.Join(", ", args)}");
            Printer.WriteLine("--------------------------------------------------\n");
        }

        static string GetOSTag()
        {
            if (IsWindows) return "Windows";
            if (IsMacOS) return "macOS";
            if (IsLinux) return "Linux";
            return "Unknown";
        }
    }
}
