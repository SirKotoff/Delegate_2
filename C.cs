using System;

namespace Task12_4
{
    class C : ICutDownNotifier
    {
        Timer timer;

        public C(int time, string timerName)
        {
            timer = new Timer(time, timerName);
        }

        void ICutDownNotifier.Init()
        {
            timer.Start += (object sender, string name) => Console.WriteLine($"C[Таймер {name} запущен]");
            timer.Countdown += (int time) => Console.WriteLine($"C[Осталось {time} секунд]");
            timer.Finish += (string name) => Console.WriteLine($"C[Таймер {name} закончил отсчёт]");
        }

        void ICutDownNotifier.Run()
        {
            timer.Count();
        }
    }
}
