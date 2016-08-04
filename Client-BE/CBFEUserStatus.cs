// struct for monitoring FE 
// struct contains information for 1 FE 
// FE Monitoring information will be sent to Client as struct CBFEUserStatus array 
public struct CBFEUserStatus
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
    char[] ip;
    int port;

    int num;


}
