using System;
using System.Collections.Generic;
using ShopAcross.Mobile.Core;
using Xamarin.Forms;

namespace ShopAcross.Mobile.Client
{
    public partial class LoginView : ContentPage
    {
        private LoginViewController _controller;

        public LoginView()
        {
            InitializeComponent();

            //_controller = new LoginViewController(this);

            BindingContext = new LoginViewModel();
        }

        internal Entry UserName { get { return this.usernameEntry; } }

        internal Entry Password { get { return this.passwordEntry; } }

        internal Label Result { get { return this.messageLabel; } }

        internal Button Login { get { return this.loginButton; } }

    }

    public class LoginViewController
    {
        private LoginView _loginView;

        public LoginViewController(LoginView view)
        {
            _loginView = view;

            _loginView.Login.Clicked += LoginClicked;

            _loginView.UserName.TextChanged += UserNameTextChanged;
        }

        void LoginClicked(object sender, EventArgs e)
        {
            // TODO: Login
            _loginView.Result.Text = "Successfully Logged In!";
        }

        void SignUpClicked(object sender, EventArgs e)
        {
            // TODO: Navigate to SignUp
        }

        void UserNameTextChanged(object sender,
        TextChangedEventArgs e)
        {
            // TODO: Validate
        }
    }

}
