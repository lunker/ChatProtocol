using System.Runtime.InteropServices;


// FE ~ BE' Header
[StructLayout(LayoutKind.Sequential, Pack = 2)]
struct FBHeader
{
    public FBMessageType type; // message type
    public FBMessageState state; // message state 
    public int length; // body length
    public int sessionId; // session id 
}

// message type const
enum FBMessageType : short
{
    Id_Dup = 110,
    Signup = 120,

    Login = 210,

    Room_Create = 310,
    Room_Leave = 320,
    Room_Join = 330,
    Room_List = 340,

    Chat_Count = 410,
    
    Health_Check = 510,
    
    Connection_Info = 610
    
};

// message state const
enum FBMessageState : short
{
    Request = 100,
    Success = 200,
    Fail = 400
}
