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
            root = app
                .GetWindow(SearchCriteria.ByAutomationId("RocketLauncherUI"), InitializeOption.WithCache);
        }


        public void SetMainTab(MainTabs tab)
        {
            string sTabAID = null;
            switch(tab)
            {
                case MainTabs.Emulators:
                    break;
                case MainTabs.Games:
                    sTabAID = "tabGames";
                    break;
                case MainTabs.GeneralSettings:
                    break;
                case MainTabs.Keymapper:
                    break;
                case MainTabs.LogViewer:
                    break;
                case MainTabs.Modules:
                    break;
                case MainTabs.Pause:
                    break;
                case MainTabs.RocketLauncherUI:
                    sTabAID = "tabRLUI";
                    break;
                case MainTabs.Settings:
                    sTabAID = "tabSettings";
                    break;

            }

            root.Get<Tab>(SearchCriteria.ByAutomationId("tabMain")).Pages.Where(x => x.AutomationElement.Current.AutomationId.Equals(sTabAID)).Single().Click();
        }

    }
}
