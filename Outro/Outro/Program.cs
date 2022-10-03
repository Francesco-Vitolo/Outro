using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Outro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "recorded.wav";
            player.Play();
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"Shutting down in {i} seconds");
                Thread.Sleep(1000);
            }
            Process.Start("shutdown.exe", "-s -t 00");
        }
    }
}
