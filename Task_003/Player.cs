using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_003
{
    internal class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Відтворення музики");
        }

        public void Pause()
        {
            Console.WriteLine("Пауза під час відтворення");
        }

        public void Stop()
        {
            Console.WriteLine("Зупинка відтворення");
        }

        public void Record()
        {
            Console.WriteLine("Запис музики");
        }
    }
}
