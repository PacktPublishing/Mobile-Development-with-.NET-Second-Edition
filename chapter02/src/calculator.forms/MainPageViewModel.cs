using System;
using System.ComponentModel;
using System.Windows.Input;
using calculator.core;
using Xamarin.Forms;

namespace calculator.forms
{
public class MainPageViewModel : INotifyPropertyChanged
{
    private Calculator _calculator = new Calculator();

    private string result;

    public event PropertyChangedEventHandler PropertyChanged;

    public MainPageViewModel()
    {

        PushNumberCommand = new Command<string>(_ => _calculator.PushNumber(_));
        PushOperationCommand = new Command<string>(_ => _calculator.PushOperation(_[0]));

        _calculator.ResultChanged = _ => { Result = _; };
    }

    public Command<string> PushNumberCommand { get; set; }

    public Command<string> PushOperationCommand { get; set; }

    public string Result
    {
        get => result;
        set
        {
            result = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
        }
    }
}
}
