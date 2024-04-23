using System;
using System.Numerics;
using System.Text;
using Task_003;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UnicodeEncoding.Unicode;
        Player player = new Player();

        Console.WriteLine("Запускаємо відтворення:");
        player.Play();
        player.Pause();
        player.Stop();

        Console.WriteLine("\nЗапускаємо запис:");
        player.Record();
        player.Pause();
        player.Stop();
    }
}
