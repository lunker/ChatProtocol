using System.Runtime.InteropServices;

struct SignRequestBody{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)] char[] id;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)] char[] password;
}
