using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.TabItems;
using TestStack.White.UIItems.TableItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WPFUIItems;
using TestStack.White.Utility;


public enum MainTabs
{
    Keymapper,
    LogViewer,
    RocketLauncherUI,
    GeneralSettings,
    Settings,
    Emulators,
    Modules,
    Games,
    Pause
}

public enum Systems
{
    Global,
    Atari5200,
    AtariLynx,
    Daphne,
    MAME,
    NECTurboGrafx16,
    N64,
    NES,
    GBA,
    GameCube,
    Panasonic3DO,
    Sega32X,
    SegaCD,
    Dreamcast,
    GameGear,
    Genesis,
    MasterSystem,
    SegaModel2,
    NeoGeo,
    NeoGeoPocketColor,
    Playstation,
    SNES
}
namespace ScreenObjects
{
    public class MainWindow
    {
        Window root;
        public MainWindow(TestStack.White.Application app)
        {
            Retry.For(() => root = app.GetWindow(SearchCriteria.ByAutomationId("RocketLauncherUI"), InitializeOption.WithCache), TimeSpan.FromSeconds(5));

            root.LogStructure();
        }


        public MainWindow SetMainTab(MainTabs tab)
        {
            string sTabAID = null;
            switch(tab)
            {
                case MainTabs.Emulators:
                    sTabAID = "tabEmulators";
                    break;
                case MainTabs.Games:
                    sTabAID = "tabGames";
                    break;
                case MainTabs.GeneralSettings:
                    sTabAID = "tabGeneralSettings";
                    break;
                case MainTabs.Keymapper:
                    sTabAID = "tabKeymapper";
                    break;
                case MainTabs.LogViewer:
                    sTabAID = "tabLogViewer";
                    break;
                case MainTabs.Modules:
                    sTabAID = "tabModules";
                    break;
                case MainTabs.Pause:
                    sTabAID = "tabPause";
                    break;
                case MainTabs.RocketLauncherUI:
                    sTabAID = "tabRLUI";
                    break;
                case MainTabs.Settings:
                    sTabAID = "tabSettings";
                    break;

            }

            root.Get<Tab>(SearchCriteria.ByAutomationId("tabMain")).Pages.Where(x => x.AutomationElement.Current.AutomationId.Equals(sTabAID)).Single().Click();

            return this;
        }

        public MainWindow SetSystem(Systems system)
        {
            string sSystem = null;

            switch (system)
            {
                case Systems.Atari5200:
                    sSystem = "Atari 5200";
                    break;
                case Systems.AtariLynx:
                    sSystem = "Atari Lynx";
                    break;
                case Systems.Daphne:
                    sSystem = "Daphne";
                    break;
                case Systems.Dreamcast:
                    sSystem = "Sega Dreamcast";
                    break;
                case Systems.GameCube:
                    sSystem = "Nintendo GameCube";
                    break;
                case Systems.GameGear:
                    sSystem = "Sega Game Gear";
                    break;
                case Systems.GBA:
                    sSystem = "Nintendo Game Boy Advance";
                    break;
                case Systems.Genesis:
                    sSystem = "Sega Genesis";
                    break;
                case Systems.Global:
                    sSystem = "GLOBAL";
                    break;
                case Systems.MAME:
                    sSystem = "MAME";
                    break;
                case Systems.MasterSystem:
                    sSystem = "Sega Master System";
                    break;
                case Systems.N64:
                    sSystem = "Nintendo 64";
                    break;
                case Systems.NECTurboGrafx16:
                    sSystem = "NEC TurboGrafx-16";
                    break;
                case Systems.NeoGeo:
                    sSystem = "SNK Neo Geo";
                    break;
                case Systems.NeoGeoPocketColor:
                    sSystem = "SNK Neo Geo Pocket Color";
                    break;
                case Systems.NES:
                    sSystem = "Nintendo Entertainment System";
                    break;
                case Systems.Panasonic3DO:
                    sSystem = "Panasonic 3DO";
                    break;
                case Systems.Playstation:
                    sSystem = "Sony PlayStation";
                    break;
                case Systems.Sega32X:
                    sSystem = "Sega 32X";
                    break;
                case Systems.SegaCD:
                    sSystem = "Sega CD";
                    break;
                case Systems.SegaModel2:
                    sSystem = "Sega Model 2";
                    break;
                case Systems.SNES:
                    sSystem = "Super Nintendo Entertainment System";
                    break;
            }

            return SetSystem(sSystem);
        }

        public MainWindow SetSystem(string sSystem)
        {
            root.Get<ListView>().Select(sSystem);
            return this;
        }

        public MainWindow SelectEachSystem()
        {
            for(int i=0; i <root.Get<ListView>().Rows.Count; i++)
            {
                root.Get<ListView>().Select(i);
            }

            return this;
        }


    }
}
