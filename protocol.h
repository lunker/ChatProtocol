using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct Header
{
    public short type;
    public int length;
}

struct Packet
{
    public Header header;
    public byte[] body;
}


