# Co-Win site automation for OTP login page.
Powered By: Selenium Web Driver & DotnetCore.

NOTE: This script doesn't automate the OTP login process or removes human intervention. This script is only intended to remove the manual steps shown below.

#### Q: What will this script do ?
It will do the following.
- Open Chrome browser.
- Will navigate to the Co-Win Otp login page.
- Will enter your phone number in the input field.
- Then you have to enter your OTP and take over the slot booking process manually yourself.

#### Q: What do I need to do to run this script?
Requirements:
1. [Dotnet core CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/) installed in your machine.
2. Latest ChromeDriver matching your Chrome version from [here](https://chromedriver.chromium.org/downloads).

Steps:
1. Refer this helpful [article](https://swimburger.net/blog/dotnet/how-to-ui-test-using-selenium-and-net-core-on-windows-ubuntu-and-maybe-macos) to quickly setup the project.
2. Make sure to paste the `chromedriver.exe` file in correct bin folder. For me using Dotnet5 the folder path looked like this `Test\bin\Debug\net5.0\chromedriver.exe`
3. Copy the complete code from `MainScript.cs` file in your test class file.
4. Enter your phone number.
5. Now we are good to go and to start automation run `dotnet test`.
6. To make it even more snappier I highly suggest adding a powershell script in a `PATH` folder to trigger the code from anywhere. Refer below my 2 liner powershell script (cowin.ps1) which is executed whenever I type `cowin` in my PowerShell terminal.
```
cd "D:\Automations\CowinRegistration\Test"
dotnet test
```

#### Q: What to do if I am no able to setup this in my machine?
Create a issue in this repo and describe about the problem together with screenshots and error messages. I ll respond as soon as I can.
