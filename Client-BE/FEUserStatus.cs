// struct for monitoring FE 
public struct FEUserStatus
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    char[] feName;
    int num;

}
