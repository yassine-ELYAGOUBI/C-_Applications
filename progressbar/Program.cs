using System;
using System.Threading;

namespace ProgressBarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Progress bar example:");
            ShowProgressBar(100, 50); // Total 100% with 50 updates
        }

        static void ShowProgressBar(int total, int delay)
        {
            const int progressBarWidth = 50; // Width of the progress bar
            for (int i = 0; i <= total; i++)
            {
                // Calculate the number of completed blocks
                int completedBlocks = (i * progressBarWidth) / total;

                // Draw the progress bar
                Console.Write("\r[");
                Console.Write(new string('#', completedBlocks)); // Completed blocks
                Console.Write(new string('-', progressBarWidth - completedBlocks)); // Remaining blocks
                Console.Write($"] {i}%");

                // Delay to simulate work
                Thread.Sleep(delay);
            }

            Console.WriteLine("\nDone!");
        }
    }
}
