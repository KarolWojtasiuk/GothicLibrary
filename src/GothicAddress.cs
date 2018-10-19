using System;

namespace GothicLibrary
{
    public abstract class GothicAddress
    {
        public IntPtr pointer { get; set; }
        public Int32 offset { get; set; }
    }

    public class Gothic1Address : GothicAddress
    {
        public Gothic1Address(Int32 pointer, Int32 offset)
        {
            this.pointer = new IntPtr(pointer);
            this.offset = offset;
        }
    }

    public class Gothic2Address : GothicAddress
    {
        public Gothic2Address(Int32 pointer, Int32 offset)
        {
            this.pointer = new IntPtr(pointer);
            this.offset = offset;
        }
    }
}