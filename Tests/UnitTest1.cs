using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using ScreenObjects;
using TestStack.White.Utility;

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

            new MainWindow(app).SetMainTab(MainTabs.Keymapper)
                .SetMainTab(MainTabs.LogViewer)
                .SetMainTab(MainTabs.RocketLauncherUI)
                .SetMainTab(MainTabs.GeneralSettings)
                .SetMainTab(MainTabs.Settings)
                .SetMainTab(MainTabs.Emulators)
                .SetMainTab(MainTabs.Modules)
                .SetMainTab(MainTabs.Games)
                .SetMainTab(MainTabs.Pause);



        }
    }
}
