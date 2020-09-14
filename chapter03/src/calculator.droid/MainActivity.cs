using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using calculator.core;

namespace calculator.droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button _btnNumber0, _btnNumber1, _btnNumber2, _btnNumber3, _btnNumber4, _btnNumber5, _btnNumber6, _btnNumber7, _btnNumber8, _btnNumber9;

        Button _btnOpAdd, _btnOpSubstract, _btnOpMultiply, _btnOpDivide, _btnOpEqual;

        TextView _txtResult;

        Calculator _calculator;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            _btnNumber0 = FindViewById<Button>(Resource.Id.number0);
            _btnNumber1 = FindViewById<Button>(Resource.Id.number1);
            _btnNumber2 = FindViewById<Button>(Resource.Id.number2);
            _btnNumber3 = FindViewById<Button>(Resource.Id.number3);
            _btnNumber4 = FindViewById<Button>(Resource.Id.number4);
            _btnNumber5 = FindViewById<Button>(Resource.Id.number5);
            _btnNumber6 = FindViewById<Button>(Resource.Id.number6);
            _btnNumber7 = FindViewById<Button>(Resource.Id.number7);
            _btnNumber8 = FindViewById<Button>(Resource.Id.number8);
            _btnNumber9 = FindViewById<Button>(Resource.Id.number9);

            _btnOpAdd = FindViewById<Button>(Resource.Id.opAdd);
            _btnOpSubstract = FindViewById<Button>(Resource.Id.opSubstract);
            _btnOpMultiply = FindViewById<Button>(Resource.Id.opMultiply);
            _btnOpDivide = FindViewById<Button>(Resource.Id.opDivide);
            _btnOpEqual = FindViewById<Button>(Resource.Id.opEqual);

            _txtResult = FindViewById<TextView>(Resource.Id.txtResult);

            _calculator = new Calculator();

            _btnNumber0.Click += (_, __) => _calculator.PushNumber("0");
            _btnNumber1.Click += (_, __) => _calculator.PushNumber("1");
            _btnNumber2.Click += (_, __) => _calculator.PushNumber("2");
            _btnNumber3.Click += (_, __) => _calculator.PushNumber("3");
            _btnNumber4.Click += (_, __) => _calculator.PushNumber("4");
            _btnNumber5.Click += (_, __) => _calculator.PushNumber("5");
            _btnNumber6.Click += (_, __) => _calculator.PushNumber("6");
            _btnNumber7.Click += (_, __) => _calculator.PushNumber("7");
            _btnNumber8.Click += (_, __) => _calculator.PushNumber("8");
            _btnNumber9.Click += (_, __) => _calculator.PushNumber("9");

            _btnOpAdd.Click += (_, __) => _calculator.PushOperation('+');
            _btnOpSubstract.Click += (_, __) => _calculator.PushOperation('+');
            _btnOpMultiply.Click += (_, __) => _calculator.PushOperation('*');
            _btnOpDivide.Click += (_, __) => _calculator.PushOperation('/');
            _btnOpEqual.Click += (_, __) => _calculator.PushOperation('=');

            _calculator.ResultChanged = (result) =>
            {
                _txtResult.Text = result;
            };
        }
    }
}