using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Prism.Mvvm;

namespace Awesome_Clock.Models
{
    public class Clock : BindableBase
    {
        Timer _timer = new Timer(1000);

        public Clock()
        {
            CurrentTime = DateTime.Now;
            _timer.Elapsed += UpdateTime;            
            _timer.Start();
        }

        private void UpdateTime(object sender, ElapsedEventArgs e)
        {
            CurrentTime++;
#if DEBUG_WRITE
            Debug.WriteLine(CurrentTime);
#endif
        }

        private Time _currentTime;
        public Time CurrentTime
        {
            get => _currentTime;
            set => SetProperty(ref _currentTime, value);
        }
        
    }
}
