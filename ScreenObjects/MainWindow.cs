using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.TabItems;
using TestStack.White.UIItems.WindowItems;
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
namespace ScreenObjects
{
    public class MainWindow
    {
        Window root;
        public MainWindow(TestStack.White.Application app)
        {
            Retry.For(() => root = app.GetWindow(SearchCriteria.ByAutomationId("RocketLauncherUI"), InitializeOption.WithCache), TimeSpan.FromSeconds(5));
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




    }
}
