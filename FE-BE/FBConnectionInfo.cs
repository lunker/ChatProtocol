 using System.Runtime.InteropServices;
 struct FBConnectionInfo
{
    [MarshalAs(UnmanagedType.LPArray, SizeConst = 15)]
    public char[] ip;
    public int port; //lenght of next body 
}
