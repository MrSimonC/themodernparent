using System;
using System.Timers;

namespace TheModernParent.Shared
{
    // https://wellsb.com/csharp/aspnet/blazor-timer-navigate-programmatically/

    public sealed class BlazorTimer
    {
        private Timer _timer;

        public void SetTimer(double intervalMilliseconds, bool repeat)
        {
            _timer = new Timer(intervalMilliseconds);
            _timer.Elapsed += NotifyTimerElapsed;
            _timer.AutoReset = repeat;
            _timer.Enabled = true;
        }

        public event Action OnElapsed;

        private void NotifyTimerElapsed(object source, ElapsedEventArgs e)
        {
            OnElapsed?.Invoke();
            if (!_timer.AutoReset)
            {
                _timer.Stop();
                _timer.Dispose();
                _timer = null;
            }
        }
    }
}
