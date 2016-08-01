struct FBSignupRequestBody
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    char[] id;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    char[] password;
}
