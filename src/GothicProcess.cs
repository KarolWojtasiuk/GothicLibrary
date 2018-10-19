using System;
using System.Linq;
using System.Diagnostics;

namespace GothicLibrary
{
    public enum GothicVersion
    {
        Gothic1,
        Gothic2
    }

    public class GothicProcess
    {
        public GothicVersion GameVersion { get; private set; }
        private IntPtr ProcessHandle { get; set; }
        private Process Process { get; set; }

        public GothicProcess(GothicVersion gameVersion, String processName)
        {
            this.GameVersion = gameVersion;
            this.Process = Process.GetProcessesByName(processName).FirstOrDefault();
            this.ProcessHandle = Kernel32.OpenProcess(Kernel32.ProcessAccessFlags.All, false, this.Process.Id);
        }

        ~GothicProcess()
        {
            Kernel32.CloseHandle(ProcessHandle);
        }

        public Int32 ReadVariable(Address address)
        {
            GothicAddress gothicAddress;

            if (this.GameVersion == GothicVersion.Gothic1)
            {
                gothicAddress = address.Gothic1Address;
            }
            else if (this.GameVersion == GothicVersion.Gothic2)
            {
                gothicAddress = address.Gothic2Address;
            }
            else
            {
                throw new Exception("Unsupported game version");
            }

            IntPtr addressToRead = IntPtr.Add(this.Process.MainModule.BaseAddress, gothicAddress.pointer);
            Byte[] buffer = new byte[4];
            Int32 bytesReaded;
            Kernel32.ReadProcessMemory(this.ProcessHandle, addressToRead, buffer, 4, out bytesReaded);

            addressToRead = IntPtr.Add(new IntPtr(BitConverter.ToInt32(buffer, 0)), gothicAddress.offset);
            buffer = new byte[4];
            bytesReaded = 0;
            Kernel32.ReadProcessMemory(this.ProcessHandle, addressToRead, buffer, 4, out bytesReaded);

            return BitConverter.ToInt32(buffer, 0);
        }
    }
}
