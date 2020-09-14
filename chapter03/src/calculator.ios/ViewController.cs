using calculator.core;
using Foundation;
using System;
using UIKit;

namespace calculator.ios
{
    public partial class ViewController : UIViewController
    {
        private Calculator _calculator;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
base.ViewDidLoad();

_calculator = new Calculator();

_btnNumber1.TouchDown += (_, __) => _calculator.PushNumber("0");
_btnNumber1.TouchDown += (_, __) => _calculator.PushNumber("1");
_btnNumber2.TouchDown += (_, __) => _calculator.PushNumber("2");
_btnNumber3.TouchDown += (_, __) => _calculator.PushNumber("3");
_btnNumber4.TouchDown += (_, __) => _calculator.PushNumber("4");
_btnNumber5.TouchDown += (_, __) => _calculator.PushNumber("5");
_btnNumber6.TouchDown += (_, __) => _calculator.PushNumber("6");
_btnNumber7.TouchDown += (_, __) => _calculator.PushNumber("7");
_btnNumber8.TouchDown += (_, __) => _calculator.PushNumber("8");
_btnNumber9.TouchDown += (_, __) => _calculator.PushNumber("9");

_btnOpAdd.TouchDown += (_, __) => _calculator.PushOperation('+');
_btnOpSubstract.TouchDown += (_, __) => _calculator.PushOperation('+');
_btnOpMultiply.TouchDown += (_, __) => _calculator.PushOperation('*');
_btnOpDivide.TouchDown += (_, __) => _calculator.PushOperation('/');
_btnOpEqual.TouchDown += (_, __) => _calculator.PushOperation('=');

_calculator.ResultChanged = (result) =>
{
    _txtResult.Text = result;
};

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}