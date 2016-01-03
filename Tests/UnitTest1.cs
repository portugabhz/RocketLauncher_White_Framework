using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using ScreenObjects;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"E:\RocketLauncher\RocketLauncherUI";

            Application app = Application.Launch(path + @"\RocketLauncherUI.exe");

            System.Threading.Thread.Sleep(5000);
            new MainWindow(app).SetMainTab(MainTabs.Games);

        }
    }
}
