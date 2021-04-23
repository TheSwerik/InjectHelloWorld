using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace InjectHelloWorldConsole
{
    internal static class Program
    {
        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        private static extern int MessageBox(IntPtr h, string m, string c, int type);

        private static void Main(string[] args)
        {
            Task.Run(() =>
                     {
                         Console.Beep(1500, 200);
                         Console.Beep(1000, 200);
                         Console.Beep(2000, 200);
                     });
            while (MessageBox((IntPtr) 0, "Sees", "Soos", 0x00011014) != 0) ;
            // MessageBox((IntPtr) 0, "Sees", "Soos", 0x00012212);
        }
        // [DllImport("kernel32.dll", EntryPoint = "Beep", SetLastError = true, ExactSpelling = true)]
        // public static extern bool Beep(uint frequency, uint duration);
        //
        // static void Main(string[] args)
        // {
        //     while (Beep((uint) new Random().Next(300, 2000), 120)) ;
        //     SystemSounds.Beep();
        // }
        //
        // static void beep(int f, int t)
        // {
        //     if (f > 0) Console.Beep(f, t);
        //     else System.Threading.Thread.Sleep(t);
        // }
    }
}