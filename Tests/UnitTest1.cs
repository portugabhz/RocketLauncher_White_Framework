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
                .SetMainTab(MainTabs.Pause)
                .SelectEachSystem();
                //.SetSystem(Systems.Atari5200)
                //.SetSystem(Systems.AtariLynx)
                //.SetSystem(Systems.Daphne)
                //.SetSystem(Systems.Dreamcast)
                //.SetSystem(Systems.GameCube)
                //.SetSystem(Systems.GameGear)
                //.SetSystem(Systems.GBA)
                //.SetSystem(Systems.Genesis)
                //.SetSystem(Systems.Global)
                //.SetSystem(Systems.MAME)
                //.SetSystem(Systems.MasterSystem)
                //.SetSystem(Systems.N64)
                //.SetSystem(Systems.NECTurboGrafx16)
                //.SetSystem(Systems.NeoGeo)
                //.SetSystem(Systems.NeoGeoPocketColor)
                //.SetSystem(Systems.NES)
                //.SetSystem(Systems.Panasonic3DO)
                //.SetSystem(Systems.Playstation)
                //.SetSystem(Systems.Sega32X)
                //.SetSystem(Systems.SegaCD)
                //.SetSystem(Systems.SegaModel2)
                //.SetSystem(Systems.SNES);



        }
    }
}
