 using System.Runtime.InteropServices;
 struct CFRoomRequestBody
{
    [MarshalAs(UnmanagedType.LPArray, SizeConst = 12)]
    public char[] id;
    int roomNo; 
}
