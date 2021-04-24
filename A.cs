using System;

namespace Task12_4
{
    class A : ICutDownNotifier
    {
        Timer timer;

        public A(int time, string Name)
        {
            timer = new Timer(time, Name);
        }
        
        void ICutDownNotifier.Init()
        {
            timer.Start += ListenerStart;
            timer.Countdown += ListenerCountdown;
            timer.Finish += ListenerCountdown;
        }

        void ICutDownNotifier.Run()
        {
            timer.Count();
        }

        private void ListenerStart(object sender, string name)
        {
            Console.WriteLine($"A[Таймер {name} запущен]");
        }

        private void ListenerCountdown(int time)
        {
            Console.WriteLine($"A[Осталось {time} секунд]");
        }

        private void ListenerCountdown(string name)
        {
            Console.WriteLine($"A[Таймер {name} закончил отсчёт]");
        }
    }
}
//by Alex Kotyukov