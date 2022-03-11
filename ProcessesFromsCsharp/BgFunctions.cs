using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;


// TODO complete addProcess function to right click and exit any of the for list.
namespace ProcessesFromsCsharp
{
    public class BgFunctions
    {
        public List<string> process_names_useless = new List<string>
        {
            "System", "Registry", "winitt", "services", "svchost", "NVDisplay.Container", "Memory Compression", "dwm",
            "Microsoft.Photos", "YourPhone", "NisSrv", "HelpPane", "SystemSettings", "Idle", "wininit", "wlanext", "igfxCUIServiceN",
            "spoolsv", "SearchIndexer", "taskhostw", "RstMwService", "RtkAudUService64", "conhost", "MSBuild", "WebViewHost",
            "ServiceHub.VSDetouredHost", "ServiceHub.IdentityHost", "ServiceHub.SettingsHost", "ServiceHub.Host.CLR.x86",
            "ServiceHub.ThreadedWaitDialog", "ServiceHub.RoslynCodeAnalysisService", "ServiceHub.Host.CLR.x64", "ServiceHub.Host.CLR.x86",
            "ServiceHub.DataWarehouseHost", "msedgewebview2", "Microsoft.ServiceHub.Controller", "SecurityHealthService",
            "SecurityHealthSystray", "ApplicationFrameHost", "SgrmBroker", "StartMenuExperienceHost", "SearchApp", "TextInputHost",
            "jhi_service", "MsMpEng", "WUDFHost", "fontdrvhost", "winlogon", "LsaIso", "lsass", "rundll32", "PerfWatson2",
            "Secure System", "sihost", "NVIDIA Web Helper", "GoogleCrashHandler", "GoogleCrashHandler64", "SettingSyncHost",
            "explorer", "ShellExperienceHost", "LockApp", "SystemSettingsBroker", "TrustedInstaller", "cmd", "MpCopyAccelerator",
            "fodhelper", "TiWorker", "devenv", "dasHost", "DataExchangeHost", "python", "MusNotifyIcon", "StandardCollector.Service",
            "VsDebugConsole", "VBCSCompiler", "SearchProtocolHost", "SearchFilterHost", "smss", "UserOOBEBroker", "Time",
            "deskpins", "RuntimeBroker", "csrss", "WmiPrvSE", "audiodg", "GameBarPresenceWriter", "smartscreen",
            "vmcompute", "RtkUWP", "OfficeClickToRun", "dllhost", "MoUsoCoreWorker", "CompPkgSrv", "Video.UI", "PaintStudio.View", "Calculator",
            "IntelCpHDCPSvc", "nvcontainer", "LMS", "ELANFPService", "ctfmon", "notepad", "YourPhoneServer", "SnippingTool",
            "steamwebhelper", "steamservice", "chrome"
        };
        public List<string> process_names = new List<string>
        {
            "chrome", "csgo", "Cities", "Bannerlord", "steam", "Teams"
        };
        
        public bool inProcesses(string word)
        {
            bool toggle = false;
            foreach (string s in process_names)
            {
                if (s == word)
                {
                    toggle = true;
                }
            }
            return toggle;
        }

    }
}

