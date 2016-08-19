using System.Runtime.InteropServices;

int healthCheckTimeOut = 30;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
struct CFHeader
{
    public CFMessageType type;
    public CFMessageState state;
    public int length;
}

enum Protocol
    {
        Tcp = 0,
        Web
    }

enum CFMessageType : short
{
    Id_Dup = 110,
    Signup = 120,
     Delete = 130,
    Change_Password = 140,

    Login = 210,
    Logout = 220,

    ChangePassword = 230,
    RemoveAccound = 240,
    
    Room_Create = 310,
    Room_Leave = 320,
    Room_Join = 330,
    Room_List = 340,
    ConnectionPass =350,

    Chat_MSG_From_Client = 410,
    Chat_MSG_Broadcast = 420,
    
    Health_Check = 510
};

enum CFMessageState : short
{
    REQUEST = 100,
    SUCCESS = 200,
    FAIL = 400
}

