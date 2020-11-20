using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace WpfCalculator.ViewModels
{
    public class MainWindowsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Sum> History = new ObservableCollection<Sum>(new List<Sum> { new Sum { A = 10, B = 20, Answer = 30 } });
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
