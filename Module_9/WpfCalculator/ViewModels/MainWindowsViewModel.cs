using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WpfCalculator.ViewModels
{
    public class MainWindowsViewModel : INotifyPropertyChanged
    {
        public List<Sum> History = new List<Sum>();
        private int a;
        private int b;
        private int answer;

        public int Answer
        {
            get { return answer; }
            set 
            { 
                answer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Answer)));
            }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
