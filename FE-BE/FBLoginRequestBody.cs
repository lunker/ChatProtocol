using System.Runtime.InteropServices;

struct FBLoginRequestBody{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)] char[] id;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)] char[] password;
    bool isDummy;
}
