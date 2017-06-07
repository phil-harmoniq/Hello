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
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
        }

        public static string GetOSTag()
        {
            if (IsWindows) return "Windows";
            if (IsMacOS) return "MacOS";
            if (IsLinux) return Environment.GetEnvironmentVariable("OS_PNAME");
            return "Unknown";
        }
    }
}
