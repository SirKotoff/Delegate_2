using System.Threading;

namespace Task12_4
{
    delegate void StartEvent(object sender, string name);
    delegate void TimerEvent(int time);
    delegate void FinishEvent(string name);

    class Timer
    {
        public event StartEvent Start = null;
        public event TimerEvent Countdown = null;
        public event FinishEvent Finish = null;

        string timerName;
        int time;

        public Timer(int time, string timerName)
        {
            this.time = time;
            this.timerName = timerName;
        }

        public void Count()
        {
            if (Start != null && Countdown != null && Finish != null)
            {
                Start(this, timerName);
                for (int i = time; i != 0; i--)
                {
                    Countdown(i);

                    Thread.Sleep(1000);
                }
                Finish(timerName);
            } 
        }
    }
}