# Mobile Development with .NET - Second Edition

<a href="https://www.packtpub.com/product/mobile-development-with-net-second-edition/9781800204690?utm_source=github&utm_medium=repository&utm_campaign=9781800204690"><img src="https://static.packt-cdn.com/products/9781800204690/cover/smaller" alt="Mobile Development with .NET - Second Edition" height="256px" align="right"></a>

This is the code repository for [Mobile Development with .NET - Second Edition](https://www.packtpub.com/product/mobile-development-with-net-second-edition/9781800204690?utm_source=github&utm_medium=repository&utm_campaign=9781800204690), published by Packt.

**Build cross-platform mobile applications with Xamarin.Forms 5 and ASP.NET Core 5**

## What is this book about?
The .NET 5 framework is a unified framework with capabilities that enable you to use Microsoft’s developer ecosystem on a single platform. Xamarin, used for developing mobile applications, is one of the app model implementations for .NET Core infrastructure.

This book covers the following exciting features: 
* Discover the latest features of .NET 5 which can be used in mobile application development
* Explore Xamarin.Forms Shell for building cross-platform mobile UIs
* Understand the technical requirements of a consumer mobile app for your app design
* Focus on advanced concepts in mobile development such as app data management, push notifications, and graph APIs
* Manage app data with Entity Framework Core
* Use Microsoft's Project Rome for creating cross-device experiences with Xamarin
* Become well-versed with how to implement machine learning in your mobile apps

If you feel this book is for you, get your [copy](https://www.amazon.com/dp/1800204698) today!

<a href="https://www.packtpub.com/?utm_source=github&utm_medium=banner&utm_campaign=GitHubBanner"><img src="https://raw.githubusercontent.com/PacktPublishing/GitHub/master/GitHub.png" 
alt="https://www.packtpub.com/" border="5" /></a>


## Instructions and Navigations
All of the code is organized into folders. For example, Chapter01.

The code will look like the following:
```
static char[] _numberChars = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
static char[] _opChars = new[] { '+', '-', '*', '/', '=' };
static void Main(string[] args)
{
var calculator = new Calculator();
calculator.ResultChanged = (result) =>
{
Console.Clear();
Console.WriteLine($"{Environment.NewLine}{result}");
};
// TODO: Get input.
}
```

**Following is what you need for this book:**

This book is for ASP.NET Core developers who want to get started with mobile development using Xamarin and other Microsoft technologies. Working knowledge of C# programming is necessary to get started.

With the following software and hardware list you can run all code files present in the book (Chapter 1-18).

### Software and Hardware List

| Chapter  | Software required                   | OS required                        |
| -------- | ------------------------------------| -----------------------------------|
| 1-18     | .NET 5.0 and above                  | Windows, Mac OS X, and Linux (Any) |
| 1-18     | Xamarin.Forms 5.0                   | Windows, Mac OS X, and Linux (Any) |
| 1-18     | Python                              | Windows, Mac OS X, and Linux (Any) |
| 1-18     | Docker                              | Mac OS X, and Linux (Any)          |
| 1-18     | Visual Studio                       | Windows, Mac OS X, and Linux (Any) |
| 7-18     | Microsoft Azure (free trial)        | Windows                            |


### Related products <Other books you may enjoy>
* ASP.NET Core 5 and React - Second Edition [[Packt]](https://www.packtpub.com/product/asp-net-core-5-and-react-second-edition/9781800206168?utm_source=github&utm_medium=repository&utm_campaign=9781800206168) [[Amazon]](https://www.amazon.com/dp/180020616X)

* Customizing ASP.NET Core 5.0 [[Packt]](https://www.packtpub.com/product/customizing-asp-net-core-5-0/9781801077866?utm_source=github&utm_medium=repository&utm_campaign=9781801077866) [[Amazon]](https://www.amazon.com/dp/180107786X)

## Get to Know the Author
**Can Bilgin**
is a solution architect, working for Authority Partners Inc. He has been working in the software industry for almost two decades on various consumer- and enterprise-level engagements for high-profile clients using technologies such as BizTak, Service Fabric, Orleans, Dynamics CRM, Xamarin, WCF, Azure services, and other web/cloud technologies. His passion lies in mobile and IoT development using modern tools available to developers. He shares his experience on his blog, on social media, and through speaking engagements at local and international community events. He was recognized as a Microsoft MVP for his technical contributions between 2014 and 2018.




