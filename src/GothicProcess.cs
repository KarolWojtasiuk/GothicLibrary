using System;
using System.Linq;
using System.Diagnostics;

namespace GothicLibrary
{
    public enum GothicVersion
    {
        Gothic1,
        Gothic2NotR
    }

    public class GothicProcess
    {
        public GothicVersion GameVersion { get; private set; }
        private IntPtr ProcessHandle { get; set; }

        public GothicProcess(GothicVersion gameVersion, String processName)
        {
            this.GameVersion = gameVersion;
            this.ProcessHandle = Kernel32.OpenProcess(Kernel32.ProcessAccessFlags.All, false, Process.GetProcessesByName(processName).FirstOrDefault().Id);
        }

        ~GothicProcess()
        {
            Kernel32.CloseHandle(ProcessHandle);
        }
    }
}
