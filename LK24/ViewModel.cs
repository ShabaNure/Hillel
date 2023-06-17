using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace LK24
{
    public class ViewModel :INotifyPropertyChanged
    {
        private string _message;
        public ICommand ShowSinCommand { get; }
        public ICommand ShowCosCommand { get; }
        public ICommand ShowFactCommand { get; }
        public string _inputText;

        public string Message 
        {
            get { return _message; }
            set { 
                _message = value;
                OnPropertyChanged(nameof(Message));
            }
        }
        public string InputText
        {
            get { return _inputText; }
            set
            {
                _inputText = value;
                OnPropertyChanged(nameof(InputText));
            }
        }
        public ViewModel() 
        {
            ShowSinCommand = new RelayCommand(ShowSinMessage);
            ShowCosCommand = new RelayCommand(ShowCosMessage);
            ShowFactCommand = new RelayCommand(ShowFactMessage);
        }
        public void ShowSinMessage()
        {
            Message = Sin();
        }
        public void ShowCosMessage()
        {
            Message = Cos();
        }
        public void ShowFactMessage()
        {
            Message = Fact();
        }
        public string Sin()
        {
            var message = Math.Sin(Convert.ToInt32(InputText)).ToString();
            return message;
        }
        public string Cos()
        {
            var message = Math.Cos(Convert.ToInt32(InputText)).ToString();
            return message;
        }
        public string Fact()
        {
            int num = Convert.ToInt32(InputText);
            int res = 1;
            for (int i = num; i > 0; i--)
            {
                res *= i;
            }
            var message = res.ToString();
            return message;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
