
using System.Runtime.InteropServices;

struct FBChatRequestBody{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)] char[] id;
}
