using System;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

namespace ArgTest
{
    class Program
    {
        public static bool IsWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        public static bool IsMacOS = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
        public static bool IsLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        public static string Arch = RuntimeInformation.OSArchitecture.ToString();
        public static string OS = GetOSTag();

        static void Main(string[] args)
        {
            Console.WriteLine("\n---------- Hello from C#/.NET Core! ----------");
            Console.WriteLine($"Looks like you're using {OS}");
            if (args != null && args.Length > 0)
                Console.WriteLine($"Arguments detected: {string.Join(", ", args)}");
            Console.WriteLine("----------------------------------------------\n");
        }

        public static string GetOSTag()
        {
            if (IsWindows) return $"Windows {Environment.OSVersion.Version}";
            if (IsMacOS) return $"MacOS {Environment.OSVersion.Version}";
            if (IsLinux) return $"Linux {Environment.OSVersion.Version}";
            return "Unknown";
        }
    }
}
