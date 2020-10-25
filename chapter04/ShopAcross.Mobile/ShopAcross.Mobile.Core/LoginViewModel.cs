using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShopAcross.Mobile.Core
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _userName = "Test";

        private string _password;

        private string _result;

        private Command _loginCommand;

        public LoginViewModel()
        {
            _loginCommand = new Command(Login, Validate);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string UserName
        {
            get { return _userName; }
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    _loginCommand.ChangeCanExecute();
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    _loginCommand.ChangeCanExecute();
                }
            }
        }

        public string Result
        {
            get { return _result; }
            set
            {
                if (_result != value)
                {
                    _result = value;
                    PropertyChanged?.Invoke(this, new
                    PropertyChangedEventArgs(nameof(Result)));
                }

            }
        }

        public ICommand LoginCommand { get { return _loginCommand; } }

        public void Login()
        {
            //TODO: Login
            Result = "Successfully Logged In!";
        }

        public bool Validate()
        {
            return !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password);
        }
    }
}