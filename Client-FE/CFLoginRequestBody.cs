using System.Runtime.InteropServices;

struct LoginRequestBody{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)] char[] id;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] char[] password;
    bool isDummy;
}
