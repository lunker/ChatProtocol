using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
struct Header
{
    public MessageType type;
    public int length;
    
}

enum MessageType : short
{
    ERROR,
    MESSAGE,
};


