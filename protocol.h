using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
struct Header
{
    public MessageType type;
    public int length;
    
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
struct Packet
{
    public Header header;
    public byte[] body;
    
}

enum MessageType : short
{
    ERROR,
    MESSAGE,
};


