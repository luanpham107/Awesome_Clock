using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Awesome_Clock.Models;
using Prism.Mvvm;

namespace Awesome_Clock.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        public string Title { get; set; } = "Awesome Clock";

        public ShellViewModel()
        {
            Clock = new Clock();
        }

        private Clock _clock;
        public Clock Clock
        {
            get => _clock;
            set => SetProperty(ref _clock, value);            
        }
    }
}
