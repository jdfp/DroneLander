using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace DroneLander.UITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Tap(x => x.Text("Start"));
            app.SetSliderValue(x => x.Class("FormsSeekBar"), 1000);
            System.Threading.Thread.Sleep(2000);
            app.Screenshot("Drone Lander in action");
            app.Tap(x => x.Text("Reset"));
        }
        /*
        [Test]
        public void SignIn()
        {
           // app.Repl();
            app.Tap(x => x.Marked("Sign In"));
            app.WaitForElement(c => c.WebView().Css("INPUT#i0116"));
            app.EnterText(x => x.WebView().Css("INPUT#i0116"), "dronelanderdummy@outlook.pt");
            app.TapCoordinates(0, 0);

            app.WaitForElement(c => c.WebView().Css("INPUT#idSIButton9"));

            app.Tap(x => x.WebView().Css("INPUT#idSIButton9"));

            app.WaitForElement(c => c.WebView().Css("INPUT#i0118"));
            app.EnterText(x => x.WebView().Css("INPUT#i0118"), "Dummy1234");

            app.TapCoordinates(0, 0);
            app.WaitForElement(c => c.WebView().Css("INPUT#idSIButton9"));
            app.Tap(x => x.WebView().Css("INPUT#idSIButton9"));
            

            app.Screenshot("Logged In");

            app.Tap(x => x.Marked("Sign Out"));

            app.Screenshot("Logged Out");

        }

        [Test]
        public void CheckActivity()
        { 
        

            app.Tap(x => x.Marked("Sign In"));
            app.WaitForElement(c => c.WebView().Css("INPUT#i0116"));
            app.EnterText(x => x.WebView().Css("INPUT#i0116"), "dronelanderdummy@outlook.pt");
            app.TapCoordinates(0, 0);

            app.WaitForElement(c => c.WebView().Css("INPUT#idSIButton9"));

            app.Tap(x => x.WebView().Css("INPUT#idSIButton9"));

            app.WaitForElement(c => c.WebView().Css("INPUT#i0118"));
            app.EnterText(x => x.WebView().Css("INPUT#i0118"), "Dummy1234");

            app.TapCoordinates(0, 0);
            app.WaitForElement(c => c.WebView().Css("INPUT#idSIButton9"));
            app.Tap(x => x.WebView().Css("INPUT#idSIButton9"));

        
            

            app.Tap(x => x.Marked("Activity"));
            app.Screenshot("Activity Screen");
            app.Back();
            
        }
        */
    }
}

