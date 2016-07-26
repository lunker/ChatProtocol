struct Header
{
    short type;
    int length;
}

struct Packet
{
    public Header header;
    public byte[] body;
}
