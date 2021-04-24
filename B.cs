using System;

namespace Task12_4
{
    class B : ICutDownNotifier
    {
        Timer timer;

        public B(int time, string timerName)
        {
            timer = new Timer(time, timerName);
        }

        void ICutDownNotifier.Init()
        {
            timer.Start += delegate (object sender, string name)
            {
                Console.WriteLine($"B[Таймер {name} запущен]");
            };
            timer.Countdown += delegate (int time)
            {
                Console.WriteLine($"B[Осталось {time} секунд]");
            };
            timer.Finish += delegate (string name)
            {
                Console.WriteLine($"B[Таймер {name} закончил отсчёт]");
            };
        }

        void ICutDownNotifier.Run()
        {
            timer.Count();
        }
    }
}
