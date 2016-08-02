// struct for monitoring FE 
// struct contains information for 1 FE 
// FE Monitoring information will be sent to Client as struct CBFEUserStatus array 
public struct CBFEUserStatus
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    char[] feName; // FE Server Name ex) fe1, fe2, fe3 . . . 
    int num; // FE' user count

}
